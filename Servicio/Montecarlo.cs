using SimulacionTP4.Modelo;
using System;

namespace SimulacionTP4.Servicio
{
    public class Montecarlo
    {
        private string[][] filasMostrar;
        private double[][] puntosGrafica;
        private double ganancia;
        private double media;

        public void Calcular(long iteraciones, long diaDesde, int cantidadDiasMostrar, double precioCompra, double precioVenta, 
            double precioReventa, bool usarDemandaAnterior, int docenasComprar, bool comprarFaltante, double precioFaltante)
        {           
            Fila actual, previa, temp;
            Generador generador;
            ProbabilidadClima probabilidadClima = new ProbabilidadClima();
            long diaHasta;

            actual = new Fila();
            previa = new Fila { Dia = 0, Demanda = docenasComprar, GananciaAcumulada = 0, Media = 0 };
            generador = new Generador();
            diaHasta = diaDesde + cantidadDiasMostrar;

            filasMostrar = new string[cantidadDiasMostrar][];
            puntosGrafica = new double[cantidadDiasMostrar][];

            for (int i = 1; i < iteraciones; i++)
            {

                actual.Dia = i;
                actual.RNDClima = generador.GenerarUniforme();
                actual.Clima = probabilidadClima.DeterminarClima(actual.RNDClima);
                actual.RNDDemanda = generador.GenerarUniforme();
                actual.CalcularDemanda();

                actual.CantidadCompra = usarDemandaAnterior ? previa.Demanda : docenasComprar;
                actual.CostoCompra = -precioCompra * actual.CantidadCompra;

                if (actual.Demanda > actual.CantidadCompra) 
                {
                    actual.CantidadSobrante = 0;

                    if (comprarFaltante)
                    {
                        actual.CantidadVenta = actual.Demanda;
                        actual.CostoCompra -= precioFaltante * (actual.Demanda - actual.CantidadCompra);
                    }
                    else
                        actual.CantidadVenta = actual.CantidadCompra;
                }
                else
                {
                    actual.CantidadVenta = actual.Demanda;
                    actual.CantidadSobrante = actual.CantidadCompra - actual.CantidadVenta;
                }

                actual.IngresosDiarios = precioVenta * actual.CantidadVenta;
                actual.CostoSobrante = precioReventa * actual.CantidadSobrante;
                actual.GananciaDiaria = actual.IngresosDiarios + actual.CostoCompra + actual.CostoSobrante;
                actual.GananciaAcumulada = actual.GananciaDiaria + previa.GananciaAcumulada;
                actual.Media = ((actual.Dia - 1) * previa.Media + actual.GananciaDiaria) / actual.Dia;

                if (diaDesde <= i && i < diaHasta)
                {
                    filasMostrar[i - diaDesde] = actual.GetFila();
                    puntosGrafica[i - diaDesde] = actual.GetPuntoGrafica();
                }

                temp = previa;
                previa = actual;
                actual = temp;
            }

            ganancia = previa.GananciaAcumulada;
            media = previa.Media;
        }

        public double[][] GetDatosGrafica()
        {
            return puntosGrafica;
        }

        public string[][] GetFilasMostrar()
        {
            return filasMostrar;
        }

        public double GetGananciaTotal()
        {
            return Math.Round(ganancia, 2);
        }

        public double GetMedia()
        {
            return Math.Round(media, 2);
        }
    }
}

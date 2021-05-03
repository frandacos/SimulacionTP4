using SimulacionTP4.Modelo;

namespace SimulacionTP4.Servicio
{
    public class Montecarlo
    {
        private string[][] filasMostrar;
        private double ganancia;
        private double media;

        public void Calcular(int iteraciones, int diaDesde, int cantidadDiasMostrar, double precioCompra, double precioVenta, 
            double precioReventa, bool usarDemandaAnterior, int docenasComprar, bool comprarFaltante, double precioFaltante)
        {           
            Fila actual, previa, temp;
            Generador generador;
            ProbabilidadClima probabilidadClima = new ProbabilidadClima();
            int diaHasta;

            actual = new Fila();
            previa = new Fila { Dia = 0, Demanda = docenasComprar, GananciaAcumulada = 0, Media = 0 };
            generador = new Generador();
            diaHasta = diaDesde + cantidadDiasMostrar;

            filasMostrar = new string[cantidadDiasMostrar + 1][];

            for (int i = 1; i <= iteraciones; i++)
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

                if (diaDesde <= i && i <= diaHasta)
                    filasMostrar[i - diaDesde] = actual.GetFila();

                temp = previa;
                previa = actual;
                actual = temp;
            }

            ganancia = previa.GananciaAcumulada;
            media = previa.Media;
        }

        public string[][] GetFilasMostrar()
        {
            return filasMostrar;
        }

        public double GetGananciaTotal()
        {
            return ganancia;
        }

        public double GetMedia()
        {
            return media;
        }
    }
}

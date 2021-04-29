using SimulacionTP4.Modelo;

namespace SimulacionTP4.Servicio
{
    public class Montecarlo
    {
        private string[][] filasMostrar;
        private double ganancia;
        private double media;

        public void Calcular(int iteraciones, int diaDesde, int cantidadDiasMostrar, double compra, double venta, double reventa)
        {
            Fila actual, previa, temp;
            Generador generador;
            ProbabilidadClima probabilidadClima = new ProbabilidadClima();
            int diaHasta;

            actual = new Fila();
            previa = new Fila();
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

                // SEGUIR ACÁ
                //
                // ...

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

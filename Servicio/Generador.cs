using System;

namespace SimulacionTP4.Servicio
{
    public class Generador
    {
        private double[] serie;
        //private long semilla;
        private readonly Random r;

        public Generador()
        {
            //semilla = DateTime.Now.Ticks;
            r = new Random();
        }

        public double GenerarUniforme()
        {
            return r.NextDouble();
            //semilla = (37845 * semilla + 4194303) % 4194304;
            //return semilla / 4194304;
        }

        public double[] GenerarUniforme(double a, double b, int cantidad)
        {
            serie = new double[cantidad];
            double ancho = b - a;

            for (int i = 0; i < cantidad; i++)
                serie[i] = a + GenerarUniforme() * ancho;

            return serie;
        }

        public double[] GenerarExponencial(double media, int cantidad)
        {
            serie = new double[cantidad];
            media *= -1;

            for (int i = 0; i < cantidad; i++)
                serie[i] = media * Math.Log(1 - GenerarUniforme());

            return serie;
        }

        public double[] GenerarPoisson(double media, int cantidad)
        {
            double p, x, a;

            serie = new double[cantidad];
            a = Math.Exp(-media);

            for (int i = 0; i < cantidad; i++)
            {
                p = 1;
                x = -1;

                do
                {
                    p *= GenerarUniforme();
                    x++;

                } while (p >= a);

                serie[i] = x;
            }

            return serie;
        }

        public double[] GenerarNormalBM(double media, double desviacion, int cantidad)
        {
            double temp1, temp2, dosPI;
            int iteraciones;

            serie = new double[cantidad];
            dosPI = 2 * Math.PI;
            iteraciones = cantidad % 2 == 0 ? cantidad : cantidad - 1;

            for (int i = 0; i < iteraciones; i += 2)
            {
                temp1 = Math.Sqrt(-2 * Math.Log(GenerarUniforme()));
                temp2 = dosPI * GenerarUniforme();

                serie[i] = temp1 * Math.Cos(temp2) * desviacion + media;
                serie[i + 1] = temp1 * Math.Sin(temp2) * desviacion + media;
            }

            if (cantidad % 2 == 1)
                serie[cantidad - 1] = Math.Sqrt(-2 * Math.Log(GenerarUniforme())) * Math.Cos(dosPI * GenerarUniforme()) * desviacion + media;
            
            return serie;
        }

        public double[] GenerarNormalConvolucion(double media, double desviacion, int cantidad)
        {
            double suma;

            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                suma = -6;
                for (int j = 0; j < 12; j++)
                    suma += GenerarUniforme();

                serie[i] = suma * desviacion + media;
            }
            return serie;
        }
    }
}

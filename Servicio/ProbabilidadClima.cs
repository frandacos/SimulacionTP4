using SimulacionTP4.Modelo;

namespace SimulacionTP4.Servicio
{
    public class ProbabilidadClima
    {
        private readonly IClima soleado, nublado;

        public ProbabilidadClima()
        {
            soleado = new ClimaSoleado();
            nublado = new ClimaNublado();
        }

        public IClima DeterminarClima(double random)
        {
            double r = random;

            if (r >= 0.75 && r < 1)
                return nublado;

            return soleado;
        }
    }
}

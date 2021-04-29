using SimulacionTP4.Modelo;

namespace SimulacionTP4.Servicio
{
    public class ProbabilidadClima
    {
        private IClima soleado, nublado;

        public ProbabilidadClima()
        {
            soleado = new ClimaSoleado();
            nublado = new ClimaNublado();
        }

        public IClima DeterminarClima(double random)
        {
            return null;
        }
    }
}

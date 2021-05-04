using System;

namespace SimulacionTP4.Modelo
{
    public class ClimaNublado : IClima
    {
        public int GetDemanda(double random)
        {
            {
                double r = random;
                int demanda = 0;

                if (0.2 <= r && r < 0.6)
                    demanda = 5;

                if (0.05 <= r && r < 0.2)
                    demanda = 4;

                if (0.85 <= r && r < 1)
                    demanda = 7;

                if (0.6 <= r && r < 0.85)
                    demanda = 6;
 
                if (0 <= r && r < 0.05)
                    demanda = 3;

                return demanda;
            }

        }

        public string GetNombre()
        {
            return "Nublado";
        }
    }
}

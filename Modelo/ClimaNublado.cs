namespace SimulacionTP4.Modelo
{
    public class ClimaNublado : IClima
    {
        public int GetDemanda(double random)
        {
            if (random < .05) return 3;
            if (random < .2) return 4;
            if (random < .6) return 5;
            if (random < .85) return 6;
            return 7;
        }

        public string GetNombre()
        {
            return "Nublado";
        }
    }
}

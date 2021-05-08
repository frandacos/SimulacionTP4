namespace SimulacionTP4.Modelo
{
    public class ClimaSoleado : IClima
    {
        public int GetDemanda(double random)
        {
            if (random < .1) return 6;
            if (random < .3) return 7;
            if (random < .75) return 8;
            return 9;
        }

        public string GetNombre()
        {
            return "Soleado";
        }
    }
}

namespace SimulacionTP4.Modelo
{
    public class ClimaSoleado : IClima
    {
        public int GetDemanda(double random)
        {
            double r = random;
            int demanda = 0;

            if (0.3 <= r && r < 0.75)
                demanda = 8;

            if (0.75 <= r && r < 1)
                demanda = 9;
           
            if (0.1 <= r && r < 0.3)
                demanda = 7;

            if (0 <= r && r < 0.1)
                demanda = 6;

            return demanda;
        }

        public string GetNombre()
        {
            return "Soleado";
        }
    }
}

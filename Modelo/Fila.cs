using System;

namespace SimulacionTP4.Modelo
{
    public class Fila
    {
        public int Dia { get; set; }
        public double RNDClima { get; set; }
        public IClima Clima { get; set; }
        public double RNDDemanda { get; set; }
        public int Demanda { get; set; }
        public int CantidadVenta { get; set; }
        public int CantidadSobrante { get; set; }
        public int CantidadCompra { get; set; }
        public double IngresosDiarios { get; set; }
        public double CostoCompra { get; set; }
        public double CostoSobrante{ get; set; }
        public double GananciaDiaria { get; set; }
        public double GananciaAcumulada { get; set; }
        public double Media { get; set; }

        public void CalcularDemanda()
        {
            Demanda = Clima.GetDemanda(RNDDemanda);
        }

        public string[] GetFila()
        {
            return new string[] 
            {
                $"{Dia}",
                $"{Math.Round(RNDClima, 2)}",
                $"{Clima.GetNombre()}",
                $"{Math.Round(RNDDemanda, 2)}",
                $"{Demanda}",
                $"{CantidadVenta}",
                $"{CantidadSobrante}",
                $"{CantidadCompra}",
                $"{Math.Round(IngresosDiarios, 2)}",
                $"{Math.Round(CostoCompra, 2)}",
                $"{Math.Round(CostoSobrante, 2)}",
                $"{Math.Round(GananciaDiaria, 2)}",
                $"{Math.Round(GananciaAcumulada, 2)}",
                $"{Math.Round(Media, 2)}"
            };
        }
    }
}

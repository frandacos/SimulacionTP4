using SimulacionTP4.Presentacion;
using System;

namespace SimulacionTP4.Servicio
{


    public class GestorMontecarlo
    {
        private readonly FrmPrincipal form;
        private Montecarlo montecarla;
        private int CantidadDiasAMostrar, CompraDocena, DiaDesde, Iteraciones;
        private double PrecioCompra, PrecioReventa, PrecioSinStock, PrecioVenta;
        private bool usarDemandaAnterior, ComprarFaltante;

        public GestorMontecarlo(FrmPrincipal form)
        {
            this.form = form;
        }

        public void Calcular()
        {
            try
            {
                GetDatos();
                Validar(CantidadDiasAMostrar, CompraDocena, DiaDesde, Iteraciones,
                    PrecioCompra, PrecioReventa, PrecioSinStock, PrecioVenta);
                CalcularMontecarlo();
                MostrarResultado();
            }
            catch (Exception e)
            {
                form.MostrarExcepcion(e.ToString());
            }
        }

        private void MostrarResultado()
        {
            throw new NotImplementedException();
        }

        private void MostrarGrafica()
        {
            form.LimpiarGrafica();
            foreach (string[] fila in montecarla.GetFilasMostrar())
                form.MostrarGrafica(Convert.ToDouble(fila[0]), Convert.ToDouble(fila[13]));

        }

        private void CalcularMontecarlo()
        {
            montecarla = new Montecarlo();
            montecarla.Calcular(Iteraciones, DiaDesde, CantidadDiasAMostrar, PrecioCompra, PrecioVenta, PrecioReventa,usarDemandaAnterior
                , CompraDocena , ComprarFaltante, PrecioSinStock);
        }

        private void Validar(int CantidadDiasAMostrar,int CompraDocena, int DiaDesde,int Iteraciones,
                   double PrecioCompra, double PrecioReventa,double PrecioSinStock, double PrecioVenta)
        {
            try
            {
                if (CantidadDiasAMostrar <= 0 && CompraDocena <= 0 && DiaDesde <= 0 &&
                    Iteraciones <= 0 && PrecioCompra <= 0 && PrecioReventa <= 0 && PrecioSinStock <= 0 && PrecioVenta <= 0)
                    throw new Exception("No Se permiten valores No Negativos... Vuelva a ingresar los datos");
                    
                    
            }
            catch (Exception ex)
            {

                form.MostrarExcepcion(ex.Message);
            }
        }

        private void GetDatos()
        {
            int nCantidadDiasAMostrar, nCompraDocena, nDiaDesde, nIteraciones;
            double nPrecioCompra, nPrecioReventa, nPrecioSinStock, nPrecioVenta;
            bool bUsarDemandaAnterior, bComprarFaltante;

            nCantidadDiasAMostrar = form.GetCantidadDiasMostrar();
            nCompraDocena = form.GetCompraDocena();
            nDiaDesde = form.GetDiaDesde();
            nIteraciones = form.GetIteraciones();
            nPrecioCompra = form.GetPrecioCompra();
            nPrecioReventa = form.GetPrecioReventa();
            nPrecioSinStock = form.GetPrecioSinStock();
            nPrecioVenta = form.GetPrecioVenta();
            bUsarDemandaAnterior = form.UsoDemandaDiaAnterior();
            bComprarFaltante = form.UsoPrecioSinStock();

            usarDemandaAnterior = bUsarDemandaAnterior ; 
            ComprarFaltante =  bComprarFaltante;
            CantidadDiasAMostrar = nCantidadDiasAMostrar;
            CompraDocena = nCompraDocena;
            DiaDesde = nDiaDesde;
            Iteraciones = nIteraciones;
            PrecioCompra = nPrecioCompra;
            PrecioReventa = nPrecioReventa;
            PrecioSinStock = nPrecioSinStock;
            PrecioVenta = nPrecioVenta;

        }
    }
}

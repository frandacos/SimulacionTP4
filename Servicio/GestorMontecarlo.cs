using SimulacionTP4.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP4.Servicio
{
    public class GestorMontecarlo
    {
        private readonly FrmPrincipal form;
        private Montecarlo montecarla;
        private int mostrarCantidad, docenas, mostrarDesde, iteraciones;
        private double costoCompra, precioReventa, costoCompraSinStock, precioVenta;
        private bool usarDemandaAnterior, comprarStockFaltante;

        public GestorMontecarlo(FrmPrincipal form)
        {
            this.form = form;
        }

        public void Calcular()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GetDatos();
                Validar();
                CalcularMontecarlo();
                MostrarResultado();
            }
            catch (Exception e)
            {
                form.MostrarExcepcion(e.ToString());
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MostrarResultado()
        {
            MostrarGrafica();
            form.MostrarResultado(
                montecarla.GetGananciaTotal().ToString(), 
                montecarla.GetMedia().ToString());
            form.MostrarTabla(montecarla.GetFilasMostrar());
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
            
            montecarla.Calcular(
                iteraciones, 
                mostrarDesde, 
                mostrarCantidad, 
                costoCompra, 
                precioVenta, 
                precioReventa,
                usarDemandaAnterior,
                docenas, 
                comprarStockFaltante,
                costoCompraSinStock
                );
        }

        private void Validar()
        {
            if (mostrarDesde > iteraciones) throw new ApplicationException("El primer día para mostrar debe ser menor al total de días a simular.");
            if (iteraciones == 0) throw new ApplicationException("La simulación debe ser de por lo menos un día.");
        }

        private void GetDatos()
        {
            mostrarCantidad = form.GetCantidadDiasMostrar();
            docenas = form.GetCompraDocena();
            mostrarDesde = form.GetDiaDesde();
            iteraciones = form.GetIteraciones();
            costoCompra = form.GetPrecioCompra();
            precioReventa = form.GetPrecioReventa();
            costoCompraSinStock = form.GetPrecioSinStock();
            precioVenta = form.GetPrecioVenta();
            usarDemandaAnterior = form.UsoDemandaDiaAnterior();
            comprarStockFaltante = form.UsoPrecioSinStock();
        }
    }
}

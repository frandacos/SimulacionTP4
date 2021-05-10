using SimulacionTP4.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP4.Servicio
{
    public class GestorMontecarlo
    {
        private readonly FrmPrincipal form;
        private Montecarlo montecarla;
        private int mostrarCantidad, docenas;
        private long iteraciones, mostrarDesde;
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
                form.MostrarExcepcion(e.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MostrarResultado()
        {
            form.HabilitarGrafica(true);
            form.MostrarTablaCalculo(true);
            form.MostrarTablaMuchos(false);

            MostrarGrafica();
            MostrarTabla();

            form.MostrarResultado(
                $"$ {montecarla.GetGananciaTotal()}", 
                $"$ {montecarla.GetMedia()}");
        }

        private void MostrarTabla()
        {
            form.LimpiarTablaCalculo();
            foreach (string[] fila in montecarla.GetFilasMostrar())
            {
                if (fila == null) break;

                form.MostrarTabla(fila);
            }
        }

        private void MostrarGrafica()
        {
            form.LimpiarGrafica();
            foreach (double[] punto in montecarla.GetDatosGrafica())
            {
                if (punto == null) break;

                form.MostrarGrafica(punto[0], punto[1]);
            }
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
            if (iteraciones == 0) throw new ApplicationException("La simulación debe ser de por lo menos un día.");
            if (mostrarDesde >= iteraciones) throw new ApplicationException("El primer día para mostrar no es un día simulado.");
            if (docenas == 0) throw new ApplicationException("Debe comprar por lo menos una docena de rosas por día.");
            if (comprarStockFaltante && costoCompraSinStock == 0) throw new ApplicationException("El costo de rosas por faltante de stock no puede ser cero.");
            if (mostrarDesde == 0) throw new ApplicationException("Debe mostrarse desde, por lo menos, el día uno.");
            if (mostrarCantidad == 0) throw new ApplicationException("Debe mostrarse por lo menos un día de simulación.");
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

        public void CalcularMuchos()
        {
            try
            {
                int repeticiones;

                GetDatos();
                Validar();

                FrmDialogoCalcularMuchos dialogo = new FrmDialogoCalcularMuchos();
                dialogo.ShowDialog();

                if (!dialogo.Aceptado) return;

                repeticiones = dialogo.Repeticiones;

                if (repeticiones == 0) throw new ApplicationException("Debe realizar por lo menos una vez la simulación.");

                Cursor.Current = Cursors.WaitCursor;

                Calcular(repeticiones);
            }
            catch (Exception e)
            {
                form.MostrarExcepcion(e.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void Calcular(int repeticiones)
        {
            double[] medias, acumuladas;
            double mediaPromedio, acumuladaPromedio;

            medias = new double[repeticiones];
            acumuladas = new double[repeticiones];

            mediaPromedio = acumuladaPromedio = 0;

            for (int i = 0; i < repeticiones; i++)
            {
                CalcularMontecarlo();

                medias[i] = montecarla.GetMedia();
                acumuladas[i] = montecarla.GetGananciaTotal();

                mediaPromedio = (i * mediaPromedio + medias[i]) / (i + 1);
                acumuladaPromedio = (i * acumuladaPromedio + acumuladas[i]) / (i + 1);
            }
            MostrarMuchos(medias, acumuladas, mediaPromedio, acumuladaPromedio);
        }

        private void MostrarMuchos(double[] medias, double[] acumuladas, double mediaPromedio, double acumuladaPromedio)
        {
            form.HabilitarGrafica(false);
            form.MostrarTablaCalculo(false);
            form.MostrarTablaMuchos(true);
            form.LimpiarTablaMuchos();

            for (int i = 0; i < medias.Length; i++)
            {
                form.MostrarTabla(
                    $"{i + 1}",
                    $"$ {Math.Round(medias[i], 2)}",
                    $"$ {Math.Round(acumuladas[i], 2)}"
                    );
            }

            form.MostrarResultado(
                $"$ {Math.Round(acumuladaPromedio, 2)}", 
                $"$ {Math.Round(mediaPromedio, 2)}"
                );
        }
    }
}

using SimulacionTP4.Servicio;
using System;
using System.Windows.Forms;

namespace SimulacionTP4.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private readonly GestorMontecarlo gestor;

        public FrmPrincipal()
        {
            InitializeComponent();
            gestor = new GestorMontecarlo(this);
        }

        private void ClickBtnCalcular(object sender, EventArgs e)
        {
            gestor.Calcular();
        }

        public int GetCompraDocena()
        {
            return (int) txtDocenasCompra.Valor;
        }
        public long GetDiaDesde()
        {
            return txtDiaDesde.GetValorLong();
        }

        public long GetIteraciones()
        {
            return txtIteraciones.GetValorLong();
        }

        public void LimpiarTablaCalculo()
        {
            tablaCalculo.Rows.Clear();
        }

        public int GetCantidadDiasMostrar()
        {
            return (int) txtCantidadDias.Valor;
        }

        public void LimpiarGrafica()
        {
            histograma.Series[0].Points.Clear();
        }

        public double GetPrecioCompra()
        {
            return txtPrecioCompra.Valor;
        }

        public double GetPrecioVenta()
        {
            return txtPrecioVenta.Valor;
        }

        public void MostrarGrafica(double x, double y)
        {
            histograma.Series[0].Points.AddXY(x, y);
        }

        public double GetPrecioReventa()
        {
            return txtPrecioReventa.Valor;
        }

        public void MostrarResultado(string gananciaAcumulada, string media)
        {
            lblMedia.Text = media;
            lblTotal.Text = gananciaAcumulada;
            PrepararVentana();
        }

        private void PrepararVentana()
        {
            pnlResultado.Visible = true;
            picFondo.Visible = false;
            lblGUIVacio.Visible = false;
        }

        public void MostrarTabla(string[] fila)
        {
            tablaCalculo.Rows.Add(fila);
        }

        public void MostrarExcepcion(string excepcion)
        {
            MessageBox.Show(
                excepcion,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ChkClickCompraDocena(object sender, EventArgs e)
        {
            txtDocenasCompra.Texto = chkDocenaCompra.Checked 
                ? "Docenas iniciales"
                : "Docenas diarias";
        }
        public bool UsoDemandaDiaAnterior()
        {
            return chkDocenaCompra.Checked;
        }

        public int GetPrecioSinStock()
        {
            return (int) txtSinStock.Valor;
        }
        public bool UsoPrecioSinStock()
        {
            return cbSinStock.Checked;
        }

        private void ClickBtnRight(object sender, EventArgs e)
        {
            tablaCalculo.Visible = false;
            histograma.Visible = true;
        }

        private void ClickBtnLeft(object sender, EventArgs e)
        {
            histograma.Visible = false;
            tablaCalculo.Visible = true;
        }

        private void ClickBtnMenu(object sender, EventArgs e)
        {
            pnlDatos.Visible = !pnlDatos.Visible;
        }

        private void ClickCheckSinStock(object sender, EventArgs e)
        {
            txtSinStock.Visible = cbSinStock.Checked;
        }

        private void ClickBtnCalcularMuchos(object sender, EventArgs e)
        {
            gestor.CalcularMuchos();
        }

        public void HabilitarGrafica(bool habilitar)
        {
            pnlNavegacion.Visible = habilitar;
        }

        public void MostrarTablaCalculo(bool habilitar)
        {
            tablaCalculo.Visible = habilitar;
        }

        public void MostrarTablaMuchos(bool habilitar)
        {
            tablaMuchos.Visible = habilitar;
        }

        public void LimpiarTablaMuchos()
        {
            tablaMuchos.Rows.Clear();
        }

        public void MostrarTabla(string iteracion, string media, string acumulada)
        {
            tablaMuchos.Rows.Add(new string[]
            {
                iteracion,
                media,
                acumulada
            });
        }
    }
}

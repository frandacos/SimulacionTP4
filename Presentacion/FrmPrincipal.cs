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

        private void ClickBtnCalcular(object sender, System.EventArgs e)
        {
            gestor.Calcular();
            PrepararVentana();
        }
        private void PrepararVentana()
        {
            lblMedia.Visible = true;
            lblTotal.Visible = true;
            tablaCalculo.Visible = true;
            histograma.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            picFondo.Visible = false;
            lblGUIVacio.Visible = false;
            btnRightBlanca.Visible = true;
            btnLeftBlanca.Visible = true;
        }
        public int GetCompraDocena()
        {
            return txtDocenasCompra.Valor;
        }
        public int GetDiaDesde()
        {
            return txtDiaDesde.Valor;
        }

        public int GetIteraciones()
        {
            return txtIteraciones.Valor;
        }

        public int GetCantidadDiasMostrar()
        {
            return txtCantidadDias.Valor;
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
        }

        public void MostrarTabla(string[][] tabla)
        {
            tablaCalculo.Rows.Clear();
            foreach (string[] fila in tabla)
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

        private void ChkClickCompraDocena(object sender, System.EventArgs e)
        {
            txtDocenasCompra.Enabled = !chkDocenaCompra.Checked;
        }
        public bool UsoDemandaDiaAnterior()
        {
            return chkDocenaCompra.Checked;
        }
        public void chkSinStock_CheckedChanged(object sender, EventArgs e)
        {
            txtSinStock.Enabled = !chkSinStock.Checked;
        }
        public int GetPrecioSinStock()
        {
            return txtSinStock.Valor;
        }
        public bool UsoPrecioSinStock()
        {
            return chkSinStock.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tablaCalculo.Visible = false;
            histograma.Visible = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            histograma.Visible = false;
            tablaCalculo.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            if (pnlMenu.Visible)
            {
                pnlMenu.Visible = false;
            }
            else
            {
                pnlMenu.Visible = true;
            }

        }
    }
}

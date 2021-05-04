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
        }
        public int GetCompraDocena()
        {
            return Convert.ToInt32(txtDocenasCompra.Text);
        }
        public int GetDiaDesde()
        {
            return 0;
        }

        public int GetIteraciones()
        {
            return 0;
        }

        public int GetCantidadDiasMostrar()
        {
            return 0;
        }

        public void LimpiarGrafica()
        {
            graficaMedia.Series[0].Points.Clear();
        }

        public double GetPrecioCompra()
        {
            return 0;
        }

        public double GetPrecioVenta()
        {
            return 0;
        }

        public void MostrarGrafica(double x, double y)
        {

            graficaMedia.Series[0].Points.AddXY(x,y);
        }

        public double GetPrecioReventa()
        {
            return 0;
        }

        public void MostrarResultado(string gananciaAcumulada, string media)
        {

        }

        public void MostrarTabla(string[][] tabla)
        {

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
            return Convert.ToInt32(txtSinStock.Text);
        }
        public bool UsoPrecioSinStock()
        {
            return chkSinStock.Checked;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

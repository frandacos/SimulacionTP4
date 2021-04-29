using SimulacionTP4.Servicio;
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

        public double GetPrecioCompra()
        {
            return 0;
        }

        public double GetPrecioVenta()
        {
            return 0;
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
    }
}

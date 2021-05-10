using System;
using System.Windows.Forms;

namespace SimulacionTP4.Presentacion
{
    public partial class FrmDialogoCalcularMuchos : Form
    {
        public int Repeticiones { get; set; } = 0;
        public bool Aceptado { get; set; } = false;

        public FrmDialogoCalcularMuchos()
        {
            InitializeComponent();
        }

        private void ClickBtnAceptar(object sender, EventArgs e)
        {
            Repeticiones = (int) txtCantidad.Valor;
            Aceptado = true;
            Close();
        }

        private void ClickBtnCancelar(object sender, EventArgs e)
        {
            Close();
        }
    }
}

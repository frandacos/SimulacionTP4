using SimulacionTP4.Presentacion;
using System;

namespace SimulacionTP4.Servicio
{
    public class GestorMontecarlo
    {
        private readonly FrmPrincipal form;

        public GestorMontecarlo(FrmPrincipal form)
        {
            this.form = form;
        }

        public void Calcular()
        {
            try
            {
                GetDatos();
                Validar();
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

        private void CalcularMontecarlo()
        {
            throw new NotImplementedException();
        }

        private void Validar()
        {
            throw new NotImplementedException();
        }

        private void GetDatos()
        {
            throw new NotImplementedException();
        }
    }
}

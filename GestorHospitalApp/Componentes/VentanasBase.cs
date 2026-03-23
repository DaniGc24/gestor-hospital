using System.Windows.Forms;

namespace GestorHospitalApp.Componentes
{
    public class VentanaBase : Form
    {
        protected Panel ContenedorPrincipal = new Panel();
        public VentanaBase()
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            
            ContenedorPrincipal.Dock = DockStyle.Fill;
            Controls.Add(ContenedorPrincipal);

            BarraSuperior barra = new BarraSuperior(this);
            barra.Dock = DockStyle.Top;
            Controls.Add(barra);
        }

    }
}
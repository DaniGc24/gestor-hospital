using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace GestorHospitalApp.Componentes
{
    public class BarraSuperior : Panel
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public BarraSuperior(Form form)
        {
            //Tamano y personalizacion de la barra
            Dock = DockStyle.Top;
            Height = 40;
            BackColor = Color.DarkSlateBlue;

            //Creamos el botones y label de la barra superior
            Label Etiqueta_Titulo_Barra_Superior = Controles.Crear_Label("Hospital Axia","Arial",16,"Regular");
            Etiqueta_Titulo_Barra_Superior.Location = new Point(10, 10);
            Controls.Add(Etiqueta_Titulo_Barra_Superior);

            Button Boton_Cerrar = Controles.Crear_Boton_Barra_Superior("Imagenes//Cerrar_Barra_Superior.png");
            Boton_Cerrar.Click += (s, e) =>
            {
                Application.Exit();
            };

            Button Boton_Maximizar = Controles.Crear_Boton_Barra_Superior("Imagenes//Maximizar_Barra_Superior.png");

            Boton_Maximizar.Click += (s, e) =>
            {
                if (form.WindowState == FormWindowState.Normal)
                {
                    form.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    form.WindowState = FormWindowState.Normal;
                }
            };

            Button Boton_Minimizar = Controles.Crear_Boton_Barra_Superior("Imagenes//Minimizar_Barra_Superior.png");

            Boton_Minimizar.Click += (s, e) =>
            {
                form.WindowState = FormWindowState.Minimized;
            };

            MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, 0xA1, 0x2, 0);
                }
            };
            
            Controls.Add(Boton_Minimizar);
            Controls.Add(Boton_Maximizar);
            Controls.Add(Boton_Cerrar);
            
        }
    }
}
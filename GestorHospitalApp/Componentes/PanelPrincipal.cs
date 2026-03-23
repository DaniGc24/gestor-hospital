using System.Windows.Forms;
using System.Drawing;


namespace GestorHospitalApp.Componentes
{
    public class PanelPrincipal : VentanaBase
    {
        //Panel izquierdo
        Panel Panel_Izquierdo = new Panel();
        TableLayoutPanel Contenedor_Interno_Panel_Izquierdo = new TableLayoutPanel();
        TableLayoutPanel Contenedor_Interno_Subinferior_Izquierdo = new TableLayoutPanel();
        Panel SubPanelSuperior_izquierdo = new Panel();
        Panel SubPanelInferior_izquierdo = new Panel();
        

        //Panel superior
        Panel Panel_Superior = new Panel();
        TableLayoutPanel Contenedor_Interno_Panel_Superior = new TableLayoutPanel();
        //Panel de contenido el que se creara forms especiales
        Panel Panel_Contenido = new Panel();


        public PanelPrincipal()
        {
            // Panel contenido
            Panel_Contenido.Dock = DockStyle.Fill;
            Panel_Contenido.BackColor = Color.White;
            Panel_Contenido.BorderStyle = BorderStyle.FixedSingle;
            ContenedorPrincipal.Controls.Add(Panel_Contenido);
            PanelSuperior();
            PanelIzqueirdo();

            BotonHamburguesa();
        }
        void BotonHamburguesa()

        {
            Button BotonHamburguesa = new Button();
            BotonHamburguesa.Text = "☰";
            BotonHamburguesa.Width = 40;
            BotonHamburguesa.Height = 40;
            BotonHamburguesa.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            Panel_Izquierdo.SizeChanged += (s, e) =>
            {
                BotonHamburguesa.Location = new Point(Panel_Izquierdo.Width - 50, 10);
            };
            BotonHamburguesa.Click += (s, e) =>
            {
                if (Panel_Izquierdo.Width == 400)
                {
                    Panel_Izquierdo.Width = 80;
                    SubPanelInferior_izquierdo.BorderStyle = BorderStyle.None;
                }
                else
                {
                    Panel_Izquierdo.Width = 400;
                    SubPanelInferior_izquierdo.BorderStyle = BorderStyle.FixedSingle;
                }

            };

            Contenedor_Interno_Panel_Izquierdo.Controls.Add(BotonHamburguesa, 2, 0);
        }
        void PanelIzqueirdo()
        {

            Panel_Izquierdo.Width = 400;
            Panel_Izquierdo.Dock = DockStyle.Left;
            Panel_Izquierdo.BorderStyle = BorderStyle.FixedSingle;
            ContenedorPrincipal.Controls.Add(Panel_Izquierdo);
            PanelInternoIzquierdo();
        }
        void PanelInternoIzquierdo()
        {
            Contenedor_Interno_Panel_Izquierdo.Dock = DockStyle.Fill;
            Contenedor_Interno_Panel_Izquierdo.ColumnCount = 3;
            Contenedor_Interno_Panel_Izquierdo.RowCount = 2;
            Contenedor_Interno_Panel_Izquierdo.Padding = new Padding(20);

            Contenedor_Interno_Panel_Izquierdo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Contenedor_Interno_Panel_Izquierdo.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            Contenedor_Interno_Panel_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10));
            Contenedor_Interno_Panel_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Contenedor_Interno_Panel_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));

            Panel_Izquierdo.Controls.Add(Contenedor_Interno_Panel_Izquierdo);
            SubPanelSuperiorizquierdo();
            SubPanelInferiorizquierdo();
        }
        void SubPanelSuperiorizquierdo()
        {
            SubPanelSuperior_izquierdo.Dock = DockStyle.Top;
            Contenedor_Interno_Panel_Izquierdo.Controls.Add(SubPanelSuperior_izquierdo, 1, 0);

            Label Nombre_Clinica_Dashboard = Controles.Crear_Label("Hospital Axis", "Arial", 32, "Bold");
            Nombre_Clinica_Dashboard.Left = ((SubPanelSuperior_izquierdo.Width - Nombre_Clinica_Dashboard.Width) / 2) - 95;
            Nombre_Clinica_Dashboard.Top = ((SubPanelSuperior_izquierdo.Height - Nombre_Clinica_Dashboard.Height) / 2) - 10;
            Nombre_Clinica_Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            SubPanelSuperior_izquierdo.Controls.Add(Nombre_Clinica_Dashboard);
        }
        void SubPanelInferiorizquierdo()
        {

            SubPanelInferior_izquierdo.Dock = DockStyle.Fill;
            SubPanelInferior_izquierdo.BorderStyle = BorderStyle.FixedSingle;
            Contenedor_Interno_Panel_Izquierdo.Controls.Add(SubPanelInferior_izquierdo, 1, 1);

            Contenedor_Interno_Subinferior_Izquierdo.Dock = DockStyle.Fill;
            Contenedor_Interno_Panel_Izquierdo.Padding = new Padding(20);
            Contenedor_Interno_Subinferior_Izquierdo.ColumnCount = 3;
            Contenedor_Interno_Subinferior_Izquierdo.RowCount = 10;

            Contenedor_Interno_Subinferior_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10));
            Contenedor_Interno_Subinferior_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Contenedor_Interno_Subinferior_Izquierdo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10));

            Contenedor_Interno_Subinferior_Izquierdo.RowStyles.Add(new RowStyle(SizeType.Absolute, 10));

            for (int i = 1; i < 9; i++)
            {
                Contenedor_Interno_Subinferior_Izquierdo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            Contenedor_Interno_Subinferior_Izquierdo.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            SubPanelInferior_izquierdo.Controls.Add(Contenedor_Interno_Subinferior_Izquierdo);
            Button Agendar_Cita = Controles.Crear_Boton("Agendar Cita");
            Button Editar_Cita = Controles.Crear_Boton("Editar Cita");
            Button Citas_Hoy = Controles.Crear_Boton("Citas Hoy");
            Button Paciente = Controles.Crear_Boton("Paciente");
            Button Usuarios_Activos = Controles.Crear_Boton("Usuarios Activos");
            Button Horario_Laboral = Controles.Crear_Boton("Horario Laboral");
            Button Registros_Agendas = Controles.Crear_Boton("Registros Agendas");
            Button Personal = Controles.Crear_Boton("Personal");
            Button Cerra_Sesion = Controles.Crear_Boton("Cerrar Sesion");
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Agendar_Cita, 1, 1);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Editar_Cita, 1, 2);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Citas_Hoy, 1, 3);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Paciente, 1, 4);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Usuarios_Activos, 1, 5);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Horario_Laboral, 1, 6);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Registros_Agendas, 1, 7);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Personal, 1, 8);
            Contenedor_Interno_Subinferior_Izquierdo.Controls.Add(Cerra_Sesion, 1, 9);
        }

        void PanelSuperior()
        {
            Panel_Superior.Height = 80;
            Panel_Superior.Dock = DockStyle.Top;
            Panel_Superior.BorderStyle = BorderStyle.FixedSingle;
            ContenedorPrincipal.Controls.Add(Panel_Superior);

            Contenedor_Interno_Panel_Superior.Dock = DockStyle.Fill;
            Contenedor_Interno_Panel_Superior.Padding = new Padding(10, 20, 0, 20);
            Contenedor_Interno_Panel_Superior.ColumnCount = 2;
            Contenedor_Interno_Panel_Superior.RowCount = 1;

            Contenedor_Interno_Panel_Superior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            Contenedor_Interno_Panel_Superior.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            Contenedor_Interno_Panel_Superior.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Panel_Superior.Controls.Add(Contenedor_Interno_Panel_Superior);

            Label Bienvenido = Controles.Crear_Label("Bienvenido, {USUARIO}", "Arial", 32, "Bold");
            Contenedor_Interno_Panel_Superior.Controls.Add(Bienvenido, 0, 0);
            Label Hora = Controles.Crear_Label(DateTime.Now.ToShortDateString()+"    "+DateTime.Now.ToLongTimeString(), "Arial", 32, "Bold");
            var Temporizador = new System.Windows.Forms.Timer();
            Temporizador.Interval = 1000; 
            

            Temporizador.Tick += (s, e) =>
            {
                Hora.Text = DateTime.Now.ToShortDateString()+"    "+DateTime.Now.ToLongTimeString();

            };

            Temporizador.Start();
            Contenedor_Interno_Panel_Superior.Controls.Add(Hora, 1, 0);

        }

    }
}
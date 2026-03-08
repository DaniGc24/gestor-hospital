using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using GestorHospitalApp.Componentes;

namespace GestorHospitalApp.Forms
{

    public class Login : Form
    {

        TableLayoutPanel Contenedor_Login = new TableLayoutPanel(),
        Panel_Inicio_De_Sesion = new TableLayoutPanel();
        public Login()
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            //ALA optimizacion y multiples carpetas, SI DANIEL HUBIERA EMPEZADO A TRABAJAR ANTES
            // AHORITA ESTARIA JUGNADO KDC
            BarraSuperior barra = new BarraSuperior(this);
            Controls.Add(barra);

            //Creamos el contenedor esto esta dentro de forms y hacemos que llene el form y creamos un 3x3 para que este siempre en el centro
            Contenedor_Login.Dock = DockStyle.Fill;
            Contenedor_Login.RowCount = 3;
            Contenedor_Login.ColumnCount = 3;
            //Aqui hacemos que las columnas ocupen el %50 en el caso de la columna 1 y 3 (0 y 2) y el 2 (1) da igual siempre se agrandara
            Contenedor_Login.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Contenedor_Login.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Contenedor_Login.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            //Aqui hacemos que las Filas ocupen el %50 en el caso de la columna 1 y 3 (0 y 2) y el 2 (1) da igual siempre se agrandara
            Contenedor_Login.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Contenedor_Login.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Contenedor_Login.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            //Aqui agregamos el contendor al forms
            Controls.Add(Contenedor_Login);
            //Agregamos el panel al contenedor y le decimos en que columna y fila lo que queremos que es la del centro
            Contenedor_Login.Controls.Add(Panel_Inicio_De_Sesion, 1, 1);
            Panel_Inicio_De_Sesion.ColumnCount = 1;
            Panel_Inicio_De_Sesion.RowCount = 8;
            Panel_Inicio_De_Sesion.AutoSize = true;
            Panel_Inicio_De_Sesion.Anchor = AnchorStyles.None;

            Panel_Inicio_De_Sesion.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i = 0; i < 8; i++)
            {
                Panel_Inicio_De_Sesion.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            //Etiquetas creadas desde la carpeta Componenetes de las clases controles
            Label Nombre_Clinica_label = Controles.Crear_Label_Titulos("HOSPITAL AXIA"),
                Usuario_label = Controles.Crear_Label_Subtitulos("USUARIO"),
                Contrasena_label = Controles.Crear_Label_Subtitulos("CONTRASEÑA"),
                Recuperar_contrasena_Label = Controles.Crear_Label_Subtitulos("Recuperar Contraseña");
                Nombre_Clinica_label.Anchor = AnchorStyles.None;

            // Cosas que hace el label de recuperar contrasena
            // Aqui para cuando pase el cursor tenga cambio de color como las aplciaciones pro
            Recuperar_contrasena_Label.MouseEnter += (s, e) =>
            {
                Recuperar_contrasena_Label.ForeColor = Color.Purple;
            };
            Recuperar_contrasena_Label.MouseLeave += (s, e) =>
            {
                Recuperar_contrasena_Label.ForeColor = Color.Black;
            };
            // Aqui detecta cuando se hace click
            Recuperar_contrasena_Label.MouseDown += (s, e) =>
            {
                Recuperar_contrasena_Label.ForeColor = Color.Purple;
            };

            Recuperar_contrasena_Label.MouseUp += (s, e) =>
            {
                Recuperar_contrasena_Label.ForeColor = Color.Black;
            };
            //Cuando hace click lo manda a otra pagina
            Recuperar_contrasena_Label.Click += (s, e) =>
            {
                Recuperar_contrasena_Label.ForeColor = Color.Purple;
                Recuperar_Contrasena recuperar_Contrasena = new Recuperar_Contrasena();
                recuperar_Contrasena.Show();
            };

            //Botones
            Button Boton_inicio_sesion = Controles.Crear_Boton("Inicio de Sesion"),
            Boton_Salir = Controles.Crear_Boton("Salir");

            //Acciones Botones
            Boton_inicio_sesion.MouseEnter += async (s, e) =>
            {
                Boton_inicio_sesion.BackColor = Color.LightBlue;
                Boton_inicio_sesion.Cursor = Cursors.Hand;
            };

            Boton_inicio_sesion.MouseLeave += async (s, e) =>
            {
                Boton_inicio_sesion.BackColor = Color.White;
            };

            Boton_inicio_sesion.Click += (s, e) =>
            {
                Boton_inicio_sesion.ForeColor = Color.Purple;
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                //Hace falta la parte de base de datos
            };

            Boton_Salir.MouseEnter += async (s, e) =>
            {
                Boton_Salir.BackColor = Color.LightBlue;
                Boton_Salir.Cursor = Cursors.Hand;
            };
            Boton_Salir.MouseLeave += async (s, e) =>
            {
                Boton_Salir.BackColor = Color.White;
            };

            Boton_Salir.Click += (s, e) =>
            {
                Boton_Salir.ForeColor = Color.Purple;
                Application.Exit();
            };

            //TextBox
            TextBox Usuario_Textbox = Controles.Crear_TextBox("Usuario"),
            Contrasena_TextBox = Controles.Crear_TextBox("Contraseña");

            Panel_Inicio_De_Sesion.Controls.Add(Nombre_Clinica_label, 0, 0);
            Panel_Inicio_De_Sesion.Controls.Add(Usuario_label, 0, 1);
            Panel_Inicio_De_Sesion.Controls.Add(Usuario_Textbox, 0, 2);
            Panel_Inicio_De_Sesion.Controls.Add(Contrasena_label, 0, 3);
            Panel_Inicio_De_Sesion.Controls.Add(Contrasena_TextBox, 0, 4);
            Panel_Inicio_De_Sesion.Controls.Add(Recuperar_contrasena_Label, 0, 5);
            Panel_Inicio_De_Sesion.Controls.Add(Boton_inicio_sesion, 0, 6);
            Panel_Inicio_De_Sesion.Controls.Add(Boton_Salir, 0, 7);
        }

        
    }
}
using System;
using System.Windows.Forms;

namespace GestorHospitalApp.Forms
{
    public class MenuPrincipal : Form
    {    FlowLayoutPanel menu = new FlowLayoutPanel();
    Panel panelInfo = new Panel();
    Label descripcion = new Label();

    public MenuPrincipal()
    {
        Text = "Hospital Axia";
        Size = new Size(800, 500);

        // Menu de la izquierda donde se ubican los botones
        menu.Dock = DockStyle.Left;
        menu.Width = 200;
        menu.FlowDirection = FlowDirection.TopDown;
        menu.Padding = new Padding(10);
        menu.AutoScroll = true;

        // Este es el panel de la derecha, donde se muestra el panel simple con el label
        panelInfo.Dock = DockStyle.Fill;

        descripcion.Text = "Selecciona un módulo del sistema";
        descripcion.Font = new Font("Arial", 12);
        descripcion.AutoSize = true;
        descripcion.Top = 50;
        descripcion.Left = 50;

        panelInfo.Controls.Add(descripcion);

        // enserio tengo q ponerte aca una anotacion w
        Button btnPacientes = CrearBoton("Pacientes");
        Button btnDoctores = CrearBoton("Doctores");
        Button btnCitas = CrearBoton("Citas");
        Button btnUsuarios = CrearBoton("Usuarios");
        Button btnSalir = CrearBoton("Salir");

        // Esta parte es para las descripciones, Funciona solo pasando el mouse por encima, si quieres agregar mas solo es poner el boton y el texto asi como estan
        btnPacientes.MouseEnter += (s,e)=> descripcion.Text = "Registrar y consultar pacientes.";
        btnDoctores.MouseEnter += (s,e)=> descripcion.Text = "Administrar los doctores del hospital.";
        btnCitas.MouseEnter += (s,e)=> descripcion.Text = "Programar y ver citas médicas.";
        btnUsuarios.MouseEnter += (s,e)=> descripcion.Text = "Administrar usuarios del sistema.";
        btnSalir.MouseEnter += (s,e)=> descripcion.Text = "Cerrar el sistema.";

        btnSalir.Click += (s,e)=> Application.Exit();

        // Esta parte es lo de los botones pelon aunq es obvio w
        menu.Controls.Add(btnPacientes);
        menu.Controls.Add(btnDoctores);
        menu.Controls.Add(btnCitas);
        menu.Controls.Add(btnUsuarios);
        menu.Controls.Add(btnSalir);

        // Pelon esta parte es para los paneles, En dado caso que quieras agregar mas o quitar
        Controls.Add(panelInfo);
        Controls.Add(menu);
    }

    Button CrearBoton(string texto)
    {
        Button btn = new Button();
        btn.Text = texto;
        btn.Width = 160;
        btn.Height = 40;
        return btn;
    }
}
}
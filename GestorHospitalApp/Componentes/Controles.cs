namespace GestorHospitalApp.Componentes
{
    public static class Controles
    {
        public static Label Crear_Label_Titulos(String Texto)
        {
            Label label = new Label();
            label.Text = Texto;
            label.Font = new Font("Arial", 18, FontStyle.Bold);
            label.AutoSize = true;
            return label;
        }

        public static Label Crear_Label_Subtitulos(String Texto)
        {
            Label label = new Label();
            label.Text = Texto;
            label.Font = new Font("Arial", 10);
            label.AutoSize = true;
            return label;
        }
        public static Button Crear_Boton_Barra_Superior(string rutaImagen)
        {
            Button boton = new Button();
            boton.Width = 40;
            boton.Height = 40;
            boton.Dock = DockStyle.Right;
            boton.Image = Image.FromFile(rutaImagen);
            boton.ImageAlign = ContentAlignment.MiddleCenter;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.ImageAlign = ContentAlignment.MiddleCenter;
            boton.BackgroundImageLayout = ImageLayout.Zoom;

            return boton;
        }

        public static Button Crear_Boton(string Texto)
        {
            Button boton = new Button();
            boton.Text = Texto;
            boton.Font = new Font("Arial", 12);
            boton.Width = 300;
            boton.Height = 40;
            return boton;
        }

        public static TextBox Crear_TextBox(string texto)
        {
            TextBox textbox = new TextBox();
            textbox.Text = texto;
            textbox.Font = new Font("Arial", 10);
            textbox.Width = 300;
            textbox.Height = 40;
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Text = texto;
            textbox.ForeColor = Color.Gray;

            textbox.Enter += (s, e) =>
            {
                if (textbox.Text == texto)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                }
            };

            textbox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = texto;
                    textbox.ForeColor = Color.Gray;
                }
            };

            return textbox;
        }

    }
}
using System;
using System.Windows.Forms;
using GestorHospitalApp.Forms;

namespace GestorHospitalApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MenuPrincipal());
        }
    }
}
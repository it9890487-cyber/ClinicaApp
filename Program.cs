using System;
using System.Windows.Forms;
using ClinicaApp.Forms;

namespace ClinicaApp;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormPrincipal());
    }
}

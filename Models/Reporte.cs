using System;

namespace ClinicaApp
{
    public class Reporte
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Fecha { get; set; }

        public Reporte()
        {
            Titulo = "";
            Contenido = "";
            Fecha = DateTime.Now.ToString();
        }
    }
}

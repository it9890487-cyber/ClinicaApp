using System;

namespace ClinicaApp
{
    public abstract class Trabajador
    {
        public string IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Oficina { get; set; }
        public string Departamento { get; set; }
        public string TipoContrato { get; set; }
        public string Turno { get; set; }

        public Trabajador()
        {
            IdTrabajador = "T001";
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Oficina = "";
            Departamento = "";
            TipoContrato = "";
            Turno = "";
        }

        public virtual bool ActualizarDatos()
        {
            return true;
        }

        public virtual void AsignarTurno(string turno)
        {
            this.Turno = turno;
        }

        public abstract string ObtenerInfoCompleta();

        public virtual Reporte GenerarReporteLaboral()
        {
            Reporte reporte = new Reporte();
            reporte.Titulo = "Reporte Laboral";
            reporte.Contenido = Nombre + " " + ApellidoPaterno + " - Turno: " + Turno;
            return reporte;
        }
    }
}

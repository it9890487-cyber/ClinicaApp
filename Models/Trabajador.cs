namespace ClinicaApp.Models;

public abstract class Trabajador
{
    public string IdTrabajador { get; set; } = Guid.NewGuid().ToString();
    public string Nombre { get; set; } = string.Empty;
    public string ApellidoPaterno { get; set; } = string.Empty;
    public string ApellidoMaterno { get; set; } = string.Empty;
    public string Oficina { get; set; } = string.Empty;
    public string Departamento { get; set; } = string.Empty;
    public string TipoContrato { get; set; } = string.Empty;
    public string Turno { get; set; } = string.Empty;

    public virtual bool ActualizarDatos()
    {
        return !string.IsNullOrWhiteSpace(Nombre);
    }

    public virtual void AsignarTurno(string turno)
    {
        Turno = turno;
    }

    public abstract string ObtenerInfoCompleta();

    public virtual Reporte GenerarReporteLaboral()
    {
        return new Reporte
        {
            Titulo = "Reporte Laboral",
            Contenido = $"Trabajador: {Nombre} {ApellidoPaterno} - Turno: {Turno}",
            FechaGeneracion = DateTime.Now
        };
    }
}

namespace ClinicaApp.Models;

public class Reporte
{
    public string Titulo { get; set; } = string.Empty;
    public string Contenido { get; set; } = string.Empty;
    public DateTime FechaGeneracion { get; set; } = DateTime.Now;
}

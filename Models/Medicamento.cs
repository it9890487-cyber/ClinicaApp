namespace ClinicaApp.Models;

public class Medicamento
{
    public int IdMedicamento { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Dosis { get; set; } = string.Empty;
    public string Frecuencia { get; set; } = string.Empty;
    public string Presentacion { get; set; } = string.Empty;
}

namespace ClinicaApp.Models;

public class RecetaMedica
{
    public string FolioReceta { get; set; } = string.Empty;
    public DateTime FechaEmision { get; set; } = DateTime.Now;
    public Medico? Medico { get; set; }
    public Paciente? Paciente { get; set; }
    public string DiagnosticoPrincipal { get; set; } = string.Empty;
    public string IndicacionesGenerales { get; set; } = string.Empty;
    public List<Medicamento> Medicamentos { get; set; } = new();

    public RecetaMedica GenerarReceta(int idMedico, int idPaciente)
    {
        return this;
    }

    public void AgregarMedicamento(Medicamento medicamento)
    {
        Medicamentos.Add(medicamento);
    }

    public void EliminarMedicamento(int idMedicamento)
    {
        Medicamentos.RemoveAll(m => m.IdMedicamento == idMedicamento);
    }

    public void ImprimirReceta()
    {
        Console.WriteLine($"Imprimiendo receta {FolioReceta}");
    }

    public bool ValidarFirmaDigital()
    {
        return Medico is not null && !string.IsNullOrWhiteSpace(Medico.FirmaDigital);
    }

    public List<RecetaMedica> ConsultarHistorialRecetas(int idPaciente)
    {
        return new List<RecetaMedica>();
    }
}

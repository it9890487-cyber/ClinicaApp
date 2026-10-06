namespace ClinicaApp.Models;

public class Consultoria
{
    public string IdConsultoria { get; set; } = Guid.NewGuid().ToString();
    public DateTime FechaHora { get; set; } = DateTime.Now;
    public Medico? Medico { get; set; }
    public Paciente? Paciente { get; set; }
    public string MotivoConsulta { get; set; } = string.Empty;
    public string SignosVitales { get; set; } = string.Empty;
    public string Sintomas { get; set; } = string.Empty;
    public string Diagnostico { get; set; } = string.Empty;
    public string PlanTratamiento { get; set; } = string.Empty;
    public string NotasEvolucion { get; set; } = string.Empty;

    public static Consultoria IniciarConsultoria(Paciente paciente, Medico medico)
    {
        return new Consultoria
        {
            Paciente = paciente,
            Medico = medico,
            FechaHora = DateTime.Now
        };
    }

    public void RegistrarSignosVitales(string signos)
    {
        SignosVitales = signos;
    }

    public void RegistrarSintomas(string sintomas)
    {
        Sintomas = sintomas;
    }

    public void EstablecerDiagnostico(string diagnostico)
    {
        Diagnostico = diagnostico;
    }

    public void CrearPlanTratamiento(string plan)
    {
        PlanTratamiento = plan;
    }

    public void AgregarNotaEvolucion(string nota)
    {
        NotasEvolucion = nota;
    }

    public void FinalizarConsultoria()
    {
        Console.WriteLine($"Consulta finalizada para {Paciente?.Nombre}");
    }

    public string GenerarResumenClinico()
    {
        return $"Paciente: {Paciente?.Nombre} - Diagnóstico: {Diagnostico}";
    }
}

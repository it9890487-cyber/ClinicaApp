using ClinicaApp.Interfaces;

namespace ClinicaApp.Models;

public class Medico : Trabajador, IAtencionMedica
{
    public string CedulaProfesional { get; set; } = string.Empty;
    public string Especialidad { get; set; } = string.Empty;
    public string EspecialidadInstitucion { get; set; } = string.Empty;
    public string DomicilioParticular { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string FirmaDigital { get; set; } = string.Empty;
    public string HorarioAtencion { get; set; } = string.Empty;
    public bool EstatusActivo { get; set; } = true;
    public string IdMedico { get; set; } = Guid.NewGuid().ToString();

    public override string ObtenerInfoCompleta()
    {
        return $"{Nombre} {ApellidoPaterno} {ApellidoMaterno} - Médico - {Especialidad}";
    }

    public override bool ActualizarDatos()
    {
        return !string.IsNullOrWhiteSpace(Nombre) && !string.IsNullOrWhiteSpace(Especialidad);
    }

    public RecetaMedica GenerarReceta(Paciente paciente, string medicamento)
    {
        var receta = new RecetaMedica
        {
            FolioReceta = Guid.NewGuid().ToString()[..8],
            Medico = this,
            Paciente = paciente,
            DiagnosticoPrincipal = "Consulta médica",
            IndicacionesGenerales = "Tomar según indicación del médico"
        };

        receta.AgregarMedicamento(new Medicamento
        {
            IdMedicamento = 1,
            Nombre = medicamento,
            Dosis = "1 tableta",
            Frecuencia = "Cada 8 horas"
        });

        return receta;
    }

    public ExpedienteClinico ConsultarExpediente(Paciente paciente)
    {
        return paciente.ConsultarExpediente();
    }

    public Cita ProgramarCirugia(Paciente paciente, DateTime fecha)
    {
        return new Cita
        {
            Paciente = paciente,
            Medico = this,
            FechaCita = fecha,
            HoraCita = new TimeSpan(9, 0, 0),
            Estado = EstadoCita.Programada
        };
    }

    public void ActualizarDatosProfesionales() { }

    public bool ValidarFirma()
    {
        return !string.IsNullOrWhiteSpace(FirmaDigital);
    }

    public void Atender(Paciente paciente)
    {
        Console.WriteLine($"El médico {Nombre} atiende a {paciente.Nombre} {paciente.ApellidoPaterno}");
    }

    public void RegistrarDiagnostico(Paciente paciente, string diagnostico)
    {
        Console.WriteLine($"Diagnóstico registrado para {paciente.Nombre}: {diagnostico}");
    }
}

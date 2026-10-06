using ClinicaApp.Interfaces;

namespace ClinicaApp.Models;

public class Enfermero : Trabajador, IAtencionMedica
{
    public string IdEnfermero { get; set; } = Guid.NewGuid().ToString();
    public string CedulaEnfermeria { get; set; } = string.Empty;
    public string AreaEspecializacion { get; set; } = string.Empty;
    public string NivelAcademico { get; set; } = string.Empty;
    public string TurnoAsignado { get; set; } = string.Empty;
    public string EstatusLaboral { get; set; } = string.Empty;

    public override string ObtenerInfoCompleta()
    {
        return $"{Nombre} {ApellidoPaterno} {ApellidoMaterno} - Enfermero - {AreaEspecializacion}";
    }

    public void AdministrarMedicacion(Paciente paciente, string receta)
    {
        Console.WriteLine($"Administración de medicamento a {paciente.Nombre}: {receta}");
    }

    public void RegistrarSignosVitales(Paciente paciente)
    {
        Console.WriteLine($"Se registraron signos vitales de {paciente.Nombre}");
    }

    public void PrepararPacienteParaCirugia(Paciente paciente)
    {
        Console.WriteLine($"Paciente {paciente.Nombre} preparado para cirugía");
    }

    public void Atender(Paciente paciente)
    {
        Console.WriteLine($"El enfermero {Nombre} atiende a {paciente.Nombre}");
    }

    public void RegistrarDiagnostico(Paciente paciente, string diagnostico)
    {
        Console.WriteLine($"El enfermero registra observación para {paciente.Nombre}: {diagnostico}");
    }
}

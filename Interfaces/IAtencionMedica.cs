using ClinicaApp.Models;

namespace ClinicaApp.Interfaces;

public interface IAtencionMedica
{
    void Atender(Paciente paciente);
    void RegistrarDiagnostico(Paciente paciente, string diagnostico);
}

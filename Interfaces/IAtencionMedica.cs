using System;
using System.Collections.Generic;

namespace ClinicaApp
{
    public interface IAtencionMedica
    {
        void Atender(Paciente paciente);
        void RegistrarDiagnostico(Paciente paciente, string diagnostico);
    }
}

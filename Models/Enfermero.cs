using System;

namespace ClinicaApp
{
    public class Enfermero : Trabajador
    {
        public string IdEnfermero { get; set; }
        public string CedulaEnfermeria { get; set; }
        public string AreaEspecializacion { get; set; }
        public string NivelAcademico { get; set; }
        public string TurnoAsignado { get; set; }
        public string EstatusLaboral { get; set; }

        public Enfermero()
        {
            IdEnfermero = "E001";
            CedulaEnfermeria = "";
            AreaEspecializacion = "";
            NivelAcademico = "";
            TurnoAsignado = "";
            EstatusLaboral = "";
        }

        public override string ObtenerInfoCompleta()
        {
            return Nombre + " " + ApellidoPaterno + " - Enfermero - " + AreaEspecializacion;
        }

        public void AdministrarMedicacion(Paciente paciente, string medicamento)
        {
            Console.WriteLine("Administracion de medicamento a " + paciente.Nombre + ": " + medicamento);
        }

        public void RegistrarSignosVitales(Paciente paciente)
        {
            Console.WriteLine("Se registraron signos vitales de " + paciente.Nombre);
        }

        public void PrepararPacienteParaCirugia(Paciente paciente)
        {
            Console.WriteLine("Paciente " + paciente.Nombre + " preparado para cirugia");
        }

        public void Atender(Paciente paciente)
        {
            Console.WriteLine("El enfermero " + Nombre + " atiende a " + paciente.Nombre);
        }

        public void RegistrarDiagnostico(Paciente paciente, string diagnostico)
        {
            Console.WriteLine("El enfermero registra observacion para " + paciente.Nombre + ": " + diagnostico);
        }
    }
}

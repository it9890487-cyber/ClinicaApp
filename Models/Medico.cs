using System;

namespace ClinicaApp
{
    public class Medico : Trabajador
    {
        public string CedulaProfesional { get; set; }
        public string Especialidad { get; set; }
        public string EspecialidadInstitucion { get; set; }
        public string DomicilioParticular { get; set; }
        public string TelefonoMedico { get; set; }
        public string FirmaDigital { get; set; }
        public string HorarioAtencion { get; set; }
        public bool EstatusActivo { get; set; }

        public Medico()
        {
            CedulaProfesional = "";
            Especialidad = "";
            EspecialidadInstitucion = "";
            DomicilioParticular = "";
            TelefonoMedico = "";
            FirmaDigital = "";
            HorarioAtencion = "";
            EstatusActivo = true;
        }

        public override string ObtenerInfoCompleta()
        {
            return Nombre + " " + ApellidoPaterno + " - Medico - " + Especialidad;
        }

        public override bool ActualizarDatos()
        {
            return Nombre != "" && Especialidad != "";
        }

        public RecetaMedica GenerarReceta(Paciente paciente)
        {
            RecetaMedica receta = new RecetaMedica();
            receta.Medico = this;
            receta.Paciente = paciente;
            receta.DiagnosticoPrincipal = "Consulta medica";
            receta.IndicacionesGenerales = "Tomar segun indicacion del medico";
            return receta;
        }

        public void Atender(Paciente paciente)
        {
            Console.WriteLine("El medico " + Nombre + " atiende a " + paciente.Nombre);
        }

        public void RegistrarDiagnostico(Paciente paciente, string diagnostico)
        {
            Console.WriteLine("Diagnostico registrado para " + paciente.Nombre + ": " + diagnostico);
        }
    }
}

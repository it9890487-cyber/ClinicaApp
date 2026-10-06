using System;

namespace ClinicaApp
{
    public class Consultoria
    {
        public string IdConsultoria { get; set; }
        public DateTime FechaHora { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string MotivoConsulta { get; set; }
        public string SignosVitales { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string PlanTratamiento { get; set; }
        public string NotasEvolucion { get; set; }

        public Consultoria()
        {
            IdConsultoria = "CON001";
            FechaHora = DateTime.Now;
            Medico = null;
            Paciente = null;
            MotivoConsulta = "";
            SignosVitales = "";
            Sintomas = "";
            Diagnostico = "";
            PlanTratamiento = "";
            NotasEvolucion = "";
        }

        public static Consultoria IniciarConsultoria(Paciente paciente, Medico medico)
        {
            Consultoria consultoria = new Consultoria();
            consultoria.Paciente = paciente;
            consultoria.Medico = medico;
            consultoria.FechaHora = DateTime.Now;
            return consultoria;
        }

        public void RegistrarSignosVitales(string signos)
        {
            SignosVitales = signos;
        }

        public void RegistrarSintomas(string sintomas)
        {
            this.Sintomas = sintomas;
        }

        public void EstablecerDiagnostico(string diagnostico)
        {
            this.Diagnostico = diagnostico;
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
            Console.WriteLine("Consulta finalizada para " + Paciente.Nombre);
        }

        public string GenerarResumenClinico()
        {
            return "Paciente: " + Paciente.Nombre + " - Diagnostico: " + Diagnostico;
        }
    }
}

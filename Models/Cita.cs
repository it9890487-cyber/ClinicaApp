using System;

namespace ClinicaApp
{
    public class Cita
    {
        public string IdCita { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string Consultorio { get; set; }
        public EstadoCita Estado { get; set; }
        public string MotivoConsulta { get; set; }
        public string Prioridad { get; set; }

        public Cita()
        {
            IdCita = "C001";
            FechaSolicitud = DateTime.Now;
            FechaCita = DateTime.Now;
            HoraCita = new TimeSpan(9, 0, 0);
            Medico = null;
            Paciente = null;
            Consultorio = "";
            Estado = EstadoCita.Programada;
            MotivoConsulta = "";
            Prioridad = "";
        }

        public bool VerificarDisponibilidad()
        {
            return FechaCita >= DateTime.Today && HoraCita >= TimeSpan.Zero;
        }

        public void ConfirmarCita()
        {
            Estado = EstadoCita.Programada;
        }

        public void CancelarCita(string motivo)
        {
            Estado = EstadoCita.Cancelada;
            MotivoConsulta = motivo;
        }

        public void GenerarRecordatorio()
        {
            if (Paciente != null && Medico != null)
            {
                Console.WriteLine("Recordatorio: Cita para " + Paciente.Nombre + " con Dr. " + Medico.Nombre + 
                    " el " + FechaCita.ToString("dd/MM/yyyy") + " a las " + HoraCita.ToString());
            }
        }
    }
}

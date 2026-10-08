namespace ClinicaApp.DTO
{
    public class CitaDTO
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public string FechaSolicitud { get; set; }
        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public string Consultorio { get; set; }
        public string Estado { get; set; }
        public string MotivoConsulta { get; set; }
        public string Prioridad { get; set; }

        public CitaDTO()
        {
            IdCita = 0;
            IdPaciente = 0;
            IdMedico = 0;
            FechaSolicitud = "";
            FechaCita = "";
            HoraCita = "";
            Consultorio = "";
            Estado = "Programada";
            MotivoConsulta = "";
            Prioridad = "";
        }
    }
}

namespace ClinicaApp.DTO
{
    public class MedicoDTO
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CedulaProfesional { get; set; }
        public string Especialidad { get; set; }
        public string EspecialidadInstitucion { get; set; }
        public string DomicilioParticular { get; set; }
        public string TelefonoMedico { get; set; }
        public string FirmaDigital { get; set; }
        public string HorarioAtencion { get; set; }
        public bool EstatusActivo { get; set; }

        public MedicoDTO()
        {
            IdMedico = 0;
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            CedulaProfesional = "";
            Especialidad = "";
            EspecialidadInstitucion = "";
            DomicilioParticular = "";
            TelefonoMedico = "";
            FirmaDigital = "";
            HorarioAtencion = "";
            EstatusActivo = true;
        }
    }
}

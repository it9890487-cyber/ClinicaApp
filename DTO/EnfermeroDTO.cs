namespace ClinicaApp.DTO
{
    public class EnfermeroDTO
    {
        public int IdEnfermero { get; set; }
        public int IdTrabajador { get; set; }
        public string CedulaEnfermeria { get; set; }
        public string AreaEspecializacion { get; set; }
        public string NivelAcademico { get; set; }
        public string TurnoAsignado { get; set; }
        public string EstatusLaboral { get; set; }

        public EnfermeroDTO()
        {
            IdEnfermero = 0;
            IdTrabajador = 0;
            CedulaEnfermeria = "";
            AreaEspecializacion = "";
            NivelAcademico = "";
            TurnoAsignado = "";
            EstatusLaboral = "";
        }
    }
}

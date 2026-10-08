namespace ClinicaApp.DTO
{
    public class RecetaDTO
    {
        public int IdReceta { get; set; }
        public string FolioReceta { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public string FechaEmision { get; set; }
        public string DiagnosticoPrincipal { get; set; }
        public string IndicacionesGenerales { get; set; }

        public RecetaDTO()
        {
            IdReceta = 0;
            FolioReceta = "";
            IdMedico = 0;
            IdPaciente = 0;
            FechaEmision = "";
            DiagnosticoPrincipal = "";
            IndicacionesGenerales = "";
        }
    }
}

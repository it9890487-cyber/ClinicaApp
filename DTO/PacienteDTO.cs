namespace ClinicaApp.DTO
{
    public class PacienteDTO
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string HistoriaClinicaResumen { get; set; }
        public string Alergias { get; set; }

        public PacienteDTO()
        {
            IdPaciente = 0;
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Curp = "";
            FechaNacimiento = "";
            Sexo = "";
            Telefono = "";
            Domicilio = "";
            NumeroSeguroSocial = "";
            HistoriaClinicaResumen = "";
            Alergias = "";
        }
    }
}

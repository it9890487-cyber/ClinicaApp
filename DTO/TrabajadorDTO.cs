namespace ClinicaApp.DTO
{
    public class TrabajadorDTO
    {
        public int IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Oficina { get; set; }
        public string Departamento { get; set; }
        public string TipoContrato { get; set; }
        public string Turno { get; set; }

        public TrabajadorDTO()
        {
            IdTrabajador = 0;
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Oficina = "";
            Departamento = "";
            TipoContrato = "";
            Turno = "";
        }
    }
}

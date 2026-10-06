namespace ClinicaApp
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public string Presentacion { get; set; }

        public Medicamento()
        {
            IdMedicamento = 0;
            Nombre = "";
            Dosis = "";
            Frecuencia = "";
            Presentacion = "";
        }
    }
}

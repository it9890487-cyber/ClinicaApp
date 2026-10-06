namespace ClinicaApp.Models;

public class Paciente
{
    public string Nombre { get; set; } = string.Empty;
    public string ApellidoPaterno { get; set; } = string.Empty;
    public string ApellidoMaterno { get; set; } = string.Empty;
    public string Curp { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; } = DateTime.Today;
    public string Sexo { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Domicilio { get; set; } = string.Empty;
    public string NumeroSeguroSocial { get; set; } = string.Empty;
    public string HistoriaClinicaResumen { get; set; } = string.Empty;
    public string Alergias { get; set; } = string.Empty;

    public ExpedienteClinico Expediente { get; set; } = new();
    public List<Cita> HistorialCitas { get; private set; } = new();

    public int Edad
    {
        get
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;
            return edad;
        }
    }

    public void ActualizarDatos(
        string nombre,
        string apellidoPaterno,
        string apellidoMaterno,
        string curp,
        DateTime fechaNacimiento,
        string sexo,
        string telefono,
        string domicilio,
        string numeroSeguroSocial,
        string historiaClinicaResumen,
        string alergias)
    {
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        Curp = curp;
        FechaNacimiento = fechaNacimiento;
        Sexo = sexo;
        Telefono = telefono;
        Domicilio = domicilio;
        NumeroSeguroSocial = numeroSeguroSocial;
        HistoriaClinicaResumen = historiaClinicaResumen;
        Alergias = alergias;
    }

    public ExpedienteClinico ConsultarExpediente()
    {
        return Expediente;
    }

    public void AgendarCita(Cita cita)
    {
        HistorialCitas.Add(cita);
    }

    public List<Cita> VerHistorialCitas()
    {
        return HistorialCitas;
    }

    public void SolicitarMedicamento(string medicamento)
    {
        Console.WriteLine($"Paciente {Nombre} solicitó medicamento: {medicamento}");
    }
}

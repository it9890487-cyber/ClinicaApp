namespace ClinicaApp.Models;

public class Cita
{
    public string IdCita { get; set; } = Guid.NewGuid().ToString();
    public DateTime FechaSolicitud { get; set; } = DateTime.Now;
    public DateTime FechaCita { get; set; } = DateTime.Today;
    public TimeSpan HoraCita { get; set; } = new(9, 0, 0);
    public Medico? Medico { get; set; }
    public Paciente? Paciente { get; set; }
    public string Consultorio { get; set; } = string.Empty;
    public EstadoCita Estado { get; set; } = EstadoCita.Programada;
    public string MotivoConsulta { get; set; } = string.Empty;
    public string Prioridad { get; set; } = string.Empty;

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
        if (Paciente is null || Medico is null)
            return;

        Console.WriteLine($"Recordatorio: Cita para {Paciente.Nombre} con Dr. {Medico.Nombre} el {FechaCita:dd/MM/yyyy} a las {HoraCita}");
    }
}

using ClinicaApp.Models;

namespace ClinicaApp.Services;

public class ClinicaService
{
    private readonly List<Paciente> _pacientes = new();
    private readonly List<Cita> _citas = new();
    private readonly List<RecetaMedica> _recetas = new();

    public List<Paciente> Pacientes => _pacientes;
    public List<Cita> Citas => _citas;
    public List<RecetaMedica> Recetas => _recetas;

    public void AgregarPaciente(Paciente paciente)
    {
        _pacientes.Add(paciente);
    }

    public void AgregarCita(Cita cita)
    {
        _citas.Add(cita);
    }

    public void AgregarReceta(RecetaMedica receta)
    {
        _recetas.Add(receta);
    }

    public Paciente? BuscarPaciente(string nombre)
    {
        return _pacientes.FirstOrDefault(p => p.Nombre.StartsWith(nombre, StringComparison.OrdinalIgnoreCase));
    }
}

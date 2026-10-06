namespace ClinicaApp.Models;

public class ExpedienteClinico
{
    public string IdExpediente { get; set; } = Guid.NewGuid().ToString();
    public Paciente? Paciente { get; set; }
    public DateTime FechaApertura { get; set; } = DateTime.Now;
    public string UnidadAdscrita { get; set; } = string.Empty;
    public Medico? MedicoResponsable { get; set; }
    public List<Consultoria> ListaConsultas { get; set; } = new();
    public List<RecetaMedica> ListaRecetas { get; set; } = new();
    public string AntecedentesHeredofamiliares { get; set; } = string.Empty;
    public string AntecedentesPersonalesPatologicos { get; set; } = string.Empty;
    public string AntecedentesNoPatologicos { get; set; } = string.Empty;

    public static ExpedienteClinico CrearExpediente(Paciente paciente)
    {
        return new ExpedienteClinico
        {
            Paciente = paciente,
            FechaApertura = DateTime.Now
        };
    }

    public void AgregarConsulta(Consultoria consulta)
    {
        ListaConsultas.Add(consulta);
    }

    public void AgregarReceta(RecetaMedica receta)
    {
        ListaRecetas.Add(receta);
    }

    public string ConsultarResumen()
    {
        return $"Expediente: {IdExpediente} - Paciente: {Paciente?.Nombre}";
    }

    public void ActualizarAntecedentes(string tipo, string info)
    {
        if (tipo == "heredofamiliares")
            AntecedentesHeredofamiliares = info;
        else if (tipo == "patologicos")
            AntecedentesPersonalesPatologicos = info;
        else if (tipo == "nopatologicos")
            AntecedentesNoPatologicos = info;
    }

    public string GenerarConstancia()
    {
        return $"Constancia médica del expediente {IdExpediente}";
    }

    public void CerrarExpediente()
    {
        Console.WriteLine($"Expediente {IdExpediente} cerrado.");
    }
}

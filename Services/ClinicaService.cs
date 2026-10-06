using System.Collections.Generic;

namespace ClinicaApp
{
    public class ClinicaService
    {
        private List<Paciente> pacientes;
        private List<Cita> citas;
        private List<RecetaMedica> recetas;
        private List<Medico> medicos;
        private List<Enfermero> enfermeros;

        public ClinicaService()
        {
            pacientes = new List<Paciente>();
            citas = new List<Cita>();
            recetas = new List<RecetaMedica>();
            medicos = new List<Medico>();
            enfermeros = new List<Enfermero>();
        }

        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }

        public List<Cita> ObtenerCitas()
        {
            return citas;
        }

        public List<RecetaMedica> ObtenerRecetas()
        {
            return recetas;
        }

        public List<Medico> ObtenerMedicos()
        {
            return medicos;
        }

        public List<Enfermero> ObtenerEnfermeros()
        {
            return enfermeros;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void AgregarCita(Cita cita)
        {
            citas.Add(cita);
        }

        public void AgregarReceta(RecetaMedica receta)
        {
            recetas.Add(receta);
        }

        public void AgregarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        public void AgregarEnfermero(Enfermero enfermero)
        {
            enfermeros.Add(enfermero);
        }

        public Paciente BuscarPaciente(string nombre)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Nombre == nombre)
                {
                    return pacientes[i];
                }
            }
            return null;
        }
    }
}

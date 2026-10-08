using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class PacienteDAO
    {
        private List<PacienteDTO> pacientes;

        public PacienteDAO()
        {
            pacientes = new List<PacienteDTO>();
        }

        public void Insertar(PacienteDTO paciente)
        {
            paciente.IdPaciente = pacientes.Count + 1;
            pacientes.Add(paciente);
        }

        public PacienteDTO Obtener(int id)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].IdPaciente == id)
                {
                    return pacientes[i];
                }
            }
            return null;
        }

        public List<PacienteDTO> ObtenerTodos()
        {
            return pacientes;
        }

        public void Actualizar(PacienteDTO paciente)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].IdPaciente == paciente.IdPaciente)
                {
                    pacientes[i] = paciente;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].IdPaciente == id)
                {
                    pacientes.RemoveAt(i);
                    break;
                }
            }
        }

        public PacienteDTO BuscarPorNombre(string nombre)
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

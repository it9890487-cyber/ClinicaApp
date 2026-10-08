using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class MedicoDAO
    {
        private List<MedicoDTO> medicos;

        public MedicoDAO()
        {
            medicos = new List<MedicoDTO>();
        }

        public void Insertar(MedicoDTO medico)
        {
            medico.IdMedico = medicos.Count + 1;
            medicos.Add(medico);
        }

        public MedicoDTO Obtener(int id)
        {
            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].IdMedico == id)
                {
                    return medicos[i];
                }
            }
            return null;
        }

        public List<MedicoDTO> ObtenerTodos()
        {
            return medicos;
        }

        public void Actualizar(MedicoDTO medico)
        {
            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].IdMedico == medico.IdMedico)
                {
                    medicos[i] = medico;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].IdMedico == id)
                {
                    medicos.RemoveAt(i);
                    break;
                }
            }
        }

        public List<MedicoDTO> ObtenerPorEspecialidad(string especialidad)
        {
            List<MedicoDTO> resultado = new List<MedicoDTO>();
            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].Especialidad == especialidad)
                {
                    resultado.Add(medicos[i]);
                }
            }
            return resultado;
        }
    }
}

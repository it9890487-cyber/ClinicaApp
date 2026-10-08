using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class CitaDAO
    {
        private List<CitaDTO> citas;

        public CitaDAO()
        {
            citas = new List<CitaDTO>();
        }

        public void Insertar(CitaDTO cita)
        {
            cita.IdCita = citas.Count + 1;
            citas.Add(cita);
        }

        public CitaDTO Obtener(int id)
        {
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].IdCita == id)
                {
                    return citas[i];
                }
            }
            return null;
        }

        public List<CitaDTO> ObtenerTodas()
        {
            return citas;
        }

        public void Actualizar(CitaDTO cita)
        {
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].IdCita == cita.IdCita)
                {
                    citas[i] = cita;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].IdCita == id)
                {
                    citas.RemoveAt(i);
                    break;
                }
            }
        }

        public List<CitaDTO> ObtenerPorPaciente(int idPaciente)
        {
            List<CitaDTO> resultado = new List<CitaDTO>();
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].IdPaciente == idPaciente)
                {
                    resultado.Add(citas[i]);
                }
            }
            return resultado;
        }

        public List<CitaDTO> ObtenerPorMedico(int idMedico)
        {
            List<CitaDTO> resultado = new List<CitaDTO>();
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].IdMedico == idMedico)
                {
                    resultado.Add(citas[i]);
                }
            }
            return resultado;
        }
    }
}

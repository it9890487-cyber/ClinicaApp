using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class RecetaDAO
    {
        private List<RecetaDTO> recetas;

        public RecetaDAO()
        {
            recetas = new List<RecetaDTO>();
        }

        public void Insertar(RecetaDTO receta)
        {
            receta.IdReceta = recetas.Count + 1;
            recetas.Add(receta);
        }

        public RecetaDTO Obtener(int id)
        {
            for (int i = 0; i < recetas.Count; i++)
            {
                if (recetas[i].IdReceta == id)
                {
                    return recetas[i];
                }
            }
            return null;
        }

        public List<RecetaDTO> ObtenerTodas()
        {
            return recetas;
        }

        public void Actualizar(RecetaDTO receta)
        {
            for (int i = 0; i < recetas.Count; i++)
            {
                if (recetas[i].IdReceta == receta.IdReceta)
                {
                    recetas[i] = receta;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < recetas.Count; i++)
            {
                if (recetas[i].IdReceta == id)
                {
                    recetas.RemoveAt(i);
                    break;
                }
            }
        }

        public List<RecetaDTO> ObtenerPorPaciente(int idPaciente)
        {
            List<RecetaDTO> resultado = new List<RecetaDTO>();
            for (int i = 0; i < recetas.Count; i++)
            {
                if (recetas[i].IdPaciente == idPaciente)
                {
                    resultado.Add(recetas[i]);
                }
            }
            return resultado;
        }

        public List<RecetaDTO> ObtenerPorMedico(int idMedico)
        {
            List<RecetaDTO> resultado = new List<RecetaDTO>();
            for (int i = 0; i < recetas.Count; i++)
            {
                if (recetas[i].IdMedico == idMedico)
                {
                    resultado.Add(recetas[i]);
                }
            }
            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class TrabajadorDAO
    {
        private List<TrabajadorDTO> trabajadores;

        public TrabajadorDAO()
        {
            trabajadores = new List<TrabajadorDTO>();
        }

        public void Insertar(TrabajadorDTO trabajador)
        {
            trabajador.IdTrabajador = trabajadores.Count + 1;
            trabajadores.Add(trabajador);
        }

        public TrabajadorDTO Obtener(int id)
        {
            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].IdTrabajador == id)
                {
                    return trabajadores[i];
                }
            }
            return null;
        }

        public List<TrabajadorDTO> ObtenerTodos()
        {
            return trabajadores;
        }

        public void Actualizar(TrabajadorDTO trabajador)
        {
            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].IdTrabajador == trabajador.IdTrabajador)
                {
                    trabajadores[i] = trabajador;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].IdTrabajador == id)
                {
                    trabajadores.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

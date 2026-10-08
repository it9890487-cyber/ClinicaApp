using System;
using System.Collections.Generic;
using ClinicaApp.DTO;

namespace ClinicaApp.DAO
{
    public class EnfermeroDAO
    {
        private List<EnfermeroDTO> enfermeros;

        public EnfermeroDAO()
        {
            enfermeros = new List<EnfermeroDTO>();
        }

        public void Insertar(EnfermeroDTO enfermero)
        {
            enfermero.IdEnfermero = enfermeros.Count + 1;
            enfermeros.Add(enfermero);
        }

        public EnfermeroDTO Obtener(int id)
        {
            for (int i = 0; i < enfermeros.Count; i++)
            {
                if (enfermeros[i].IdEnfermero == id)
                {
                    return enfermeros[i];
                }
            }
            return null;
        }

        public List<EnfermeroDTO> ObtenerTodos()
        {
            return enfermeros;
        }

        public void Actualizar(EnfermeroDTO enfermero)
        {
            for (int i = 0; i < enfermeros.Count; i++)
            {
                if (enfermeros[i].IdEnfermero == enfermero.IdEnfermero)
                {
                    enfermeros[i] = enfermero;
                    break;
                }
            }
        }

        public void Eliminar(int id)
        {
            for (int i = 0; i < enfermeros.Count; i++)
            {
                if (enfermeros[i].IdEnfermero == id)
                {
                    enfermeros.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

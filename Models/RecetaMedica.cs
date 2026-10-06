using System;
using System.Collections.Generic;

namespace ClinicaApp
{
    public class RecetaMedica
    {
        public string FolioReceta { get; set; }
        public DateTime FechaEmision { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string DiagnosticoPrincipal { get; set; }
        public string IndicacionesGenerales { get; set; }
        public List<Medicamento> Medicamentos { get; set; }

        public RecetaMedica()
        {
            FolioReceta = "REC001";
            FechaEmision = DateTime.Now;
            Medico = null;
            Paciente = null;
            DiagnosticoPrincipal = "";
            IndicacionesGenerales = "";
            Medicamentos = new List<Medicamento>();
        }

        public RecetaMedica GenerarReceta(int idMedico, int idPaciente)
        {
            return this;
        }

        public void AgregarMedicamento(Medicamento medicamento)
        {
            Medicamentos.Add(medicamento);
        }

        public void EliminarMedicamento(int idMedicamento)
        {
            for (int i = 0; i < Medicamentos.Count; i++)
            {
                if (Medicamentos[i].IdMedicamento == idMedicamento)
                {
                    Medicamentos.RemoveAt(i);
                    break;
                }
            }
        }

        public void ImprimirReceta()
        {
            Console.WriteLine("Imprimiendo receta " + FolioReceta);
        }

        public bool ValidarFirmaDigital()
        {
            return Medico != null && Medico.FirmaDigital != "";
        }
    }
}

using System;
using System.Collections.Generic;

namespace ClinicaApp
{
    public class ExpedienteClinico
    {
        public string IdExpediente { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime FechaApertura { get; set; }
        public string UnidadAdscrita { get; set; }
        public Medico MedicoResponsable { get; set; }
        public List<Consultoria> ListaConsultas { get; set; }
        public List<RecetaMedica> ListaRecetas { get; set; }
        public string AntecedentesHeredofamiliares { get; set; }
        public string AntecedentesPersonalesPatologicos { get; set; }
        public string AntecedentesNoPatologicos { get; set; }

        public ExpedienteClinico()
        {
            IdExpediente = "EXP001";
            Paciente = null;
            FechaApertura = DateTime.Now;
            UnidadAdscrita = "";
            MedicoResponsable = null;
            ListaConsultas = new List<Consultoria>();
            ListaRecetas = new List<RecetaMedica>();
            AntecedentesHeredofamiliares = "";
            AntecedentesPersonalesPatologicos = "";
            AntecedentesNoPatologicos = "";
        }

        public static ExpedienteClinico CrearExpediente(Paciente paciente)
        {
            ExpedienteClinico expediente = new ExpedienteClinico();
            expediente.Paciente = paciente;
            expediente.FechaApertura = DateTime.Now;
            return expediente;
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
            return "Expediente: " + IdExpediente + " - Paciente: " + Paciente.Nombre;
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
            return "Constancia medica del expediente " + IdExpediente;
        }

        public void CerrarExpediente()
        {
            Console.WriteLine("Expediente " + IdExpediente + " cerrado.");
        }
    }
}

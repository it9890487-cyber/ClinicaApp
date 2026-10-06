using System;
using System.Collections.Generic;

namespace ClinicaApp
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string HistoriaClinicaResumen { get; set; }
        public string Alergias { get; set; }

        public ExpedienteClinico Expediente { get; set; }
        public List<Cita> HistorialCitas { get; set; }

        public Paciente()
        {
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Curp = "";
            FechaNacimiento = DateTime.Now;
            Sexo = "";
            Telefono = "";
            Domicilio = "";
            NumeroSeguroSocial = "";
            HistoriaClinicaResumen = "";
            Alergias = "";
            Expediente = new ExpedienteClinico();
            HistorialCitas = new List<Cita>();
        }

        public int CalcularEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (FechaNacimiento > DateTime.Now.AddYears(-edad))
                edad--;
            return edad;
        }

        public void ActualizarDatos(string nombre, string apellidoPaterno, string apellidoMaterno,
            string curp, DateTime fechaNacimiento, string sexo, string telefono,
            string domicilio, string numeroSeguroSocial, string historiaClinicaResumen, string alergias)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Curp = curp;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.Telefono = telefono;
            this.Domicilio = domicilio;
            this.NumeroSeguroSocial = numeroSeguroSocial;
            this.HistoriaClinicaResumen = historiaClinicaResumen;
            this.Alergias = alergias;
        }

        public ExpedienteClinico ConsultarExpediente()
        {
            return Expediente;
        }

        public void AgendarCita(Cita cita)
        {
            HistorialCitas.Add(cita);
        }

        public List<Cita> VerHistorialCitas()
        {
            return HistorialCitas;
        }

        public void SolicitarMedicamento(string medicamento)
        {
            Console.WriteLine("Paciente " + Nombre + " solicito medicamento: " + medicamento);
        }
    }
}

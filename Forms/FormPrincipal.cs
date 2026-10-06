using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ClinicaApp.Forms
{
    public partial class FormPrincipal : Form
    {
        private ClinicaService clinicaService;
        private ListBox lstPacientes;
        private ListBox lstCitas;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCurp;
        private TextBox txtTelefono;
        private Button btnAgregarPaciente;
        private Button btnCrearCita;
        private Label labelPacientes;
        private Label labelCitas;

        public FormPrincipal()
        {
            clinicaService = new ClinicaService();
            InicializarComponentes();
            CargarDatosDemo();
        }

        private void InicializarComponentes()
        {
            this.Text = "Clinica App";
            this.Size = new System.Drawing.Size(860, 560);
            this.StartPosition = FormStartPosition.CenterScreen;

            labelPacientes = new Label();
            labelPacientes.Text = "Pacientes:";
            labelPacientes.Location = new System.Drawing.Point(20, 100);
            labelPacientes.Width = 100;

            labelCitas = new Label();
            labelCitas.Text = "Citas:";
            labelCitas.Location = new System.Drawing.Point(410, 100);
            labelCitas.Width = 100;

            txtNombre = new TextBox();
            txtNombre.Location = new System.Drawing.Point(20, 30);
            txtNombre.Width = 140;
            txtNombre.Text = "Nombre";

            txtApellido = new TextBox();
            txtApellido.Location = new System.Drawing.Point(180, 30);
            txtApellido.Width = 140;
            txtApellido.Text = "Apellido";

            txtCurp = new TextBox();
            txtCurp.Location = new System.Drawing.Point(340, 30);
            txtCurp.Width = 150;
            txtCurp.Text = "CURP";

            txtTelefono = new TextBox();
            txtTelefono.Location = new System.Drawing.Point(510, 30);
            txtTelefono.Width = 140;
            txtTelefono.Text = "Telefono";

            btnAgregarPaciente = new Button();
            btnAgregarPaciente.Text = "Agregar paciente";
            btnAgregarPaciente.Location = new System.Drawing.Point(20, 70);
            btnAgregarPaciente.Width = 150;
            btnAgregarPaciente.Click += new EventHandler(BtnAgregarPaciente_Click);

            btnCrearCita = new Button();
            btnCrearCita.Text = "Crear cita";
            btnCrearCita.Location = new System.Drawing.Point(190, 70);
            btnCrearCita.Width = 140;
            btnCrearCita.Click += new EventHandler(BtnCrearCita_Click);

            lstPacientes = new ListBox();
            lstPacientes.Location = new System.Drawing.Point(20, 120);
            lstPacientes.Size = new System.Drawing.Size(360, 330);

            lstCitas = new ListBox();
            lstCitas.Location = new System.Drawing.Point(410, 120);
            lstCitas.Size = new System.Drawing.Size(360, 330);

            this.Controls.Add(txtNombre);
            this.Controls.Add(txtApellido);
            this.Controls.Add(txtCurp);
            this.Controls.Add(txtTelefono);
            this.Controls.Add(btnAgregarPaciente);
            this.Controls.Add(btnCrearCita);
            this.Controls.Add(labelPacientes);
            this.Controls.Add(labelCitas);
            this.Controls.Add(lstPacientes);
            this.Controls.Add(lstCitas);
        }

        private void CargarDatosDemo()
        {
            Paciente paciente1 = new Paciente();
            paciente1.Nombre = "Ana";
            paciente1.ApellidoPaterno = "Lopez";
            paciente1.ApellidoMaterno = "Ramirez";
            paciente1.Curp = "LORA850101HDF";
            paciente1.FechaNacimiento = new DateTime(1985, 1, 10);
            paciente1.Sexo = "Femenino";
            paciente1.Telefono = "5512345678";
            paciente1.Domicilio = "Calle 123";
            paciente1.NumeroSeguroSocial = "123456789";
            paciente1.HistoriaClinicaResumen = "Sin antecedentes relevantes";
            paciente1.Alergias = "Ninguna";

            Medico medico1 = new Medico();
            medico1.Nombre = "Carlos";
            medico1.ApellidoPaterno = "Garcia";
            medico1.ApellidoMaterno = "Santos";
            medico1.Especialidad = "Cardiologia";
            medico1.Oficina = "Consultorio 2";
            medico1.Departamento = "Cardiologia";
            medico1.TipoContrato = "Tiempo completo";
            medico1.FirmaDigital = "firma123";

            clinicaService.AgregarPaciente(paciente1);
            clinicaService.AgregarMedico(medico1);

            Cita cita = new Cita();
            cita.Paciente = paciente1;
            cita.Medico = medico1;
            cita.FechaCita = DateTime.Today.AddDays(2);
            cita.HoraCita = new TimeSpan(10, 30, 0);
            cita.Consultorio = "Consultorio 2";
            cita.MotivoConsulta = "Chequeo general";
            cita.Prioridad = "Alta";
            cita.Estado = EstadoCita.Programada;

            clinicaService.AgregarCita(cita);
            paciente1.AgendarCita(cita);

            RefrescarListas();
        }

        private void BtnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del paciente.");
                return;
            }

            Paciente paciente = new Paciente();
            paciente.Nombre = txtNombre.Text;
            paciente.ApellidoPaterno = txtApellido.Text;
            paciente.Curp = txtCurp.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.HistoriaClinicaResumen = "Creado desde la app";
            paciente.Alergias = "Ninguna";

            clinicaService.AgregarPaciente(paciente);
            RefrescarListas();

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
        }

        private void BtnCrearCita_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = clinicaService.ObtenerPacientes();
            if (pacientes.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un paciente.");
                return;
            }

            Paciente paciente = pacientes[0];
            Medico medico = new Medico();
            medico.Nombre = "Dr. Luis";
            medico.ApellidoPaterno = "Perez";
            medico.Especialidad = "Medicina General";
            medico.Oficina = "Consultorio 1";
            medico.Departamento = "Consulta externa";
            medico.FirmaDigital = "firma456";

            Cita cita = new Cita();
            cita.Paciente = paciente;
            cita.Medico = medico;
            cita.FechaCita = DateTime.Today.AddDays(3);
            cita.HoraCita = new TimeSpan(9, 0, 0);
            cita.Consultorio = "Consultorio 1";
            cita.MotivoConsulta = "Consulta de seguimiento";
            cita.Prioridad = "Media";
            cita.Estado = EstadoCita.Programada;

            clinicaService.AgregarCita(cita);
            paciente.AgendarCita(cita);
            RefrescarListas();
        }

        private void RefrescarListas()
        {
            lstPacientes.Items.Clear();
            List<Paciente> pacientes = clinicaService.ObtenerPacientes();
            for (int i = 0; i < pacientes.Count; i++)
            {
                lstPacientes.Items.Add(pacientes[i].Nombre + " " + pacientes[i].ApellidoPaterno + " - " + pacientes[i].Curp);
            }

            lstCitas.Items.Clear();
            List<Cita> citas = clinicaService.ObtenerCitas();
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].Paciente != null && citas[i].Medico != null)
                {
                    lstCitas.Items.Add(citas[i].FechaCita.ToString("dd/MM/yyyy") + " " + citas[i].HoraCita.ToString() + 
                        " - " + citas[i].Paciente.Nombre + " con " + citas[i].Medico.Nombre);
                }
            }
        }
    }
}

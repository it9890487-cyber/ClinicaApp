using System.Drawing;
using System.Windows.Forms;
using ClinicaApp.Models;
using ClinicaApp.Services;

namespace ClinicaApp.Forms;

public partial class FormPrincipal : Form
{
    private readonly ClinicaService _clinicaService = new();
    private readonly ListBox _lstPacientes = new();
    private readonly ListBox _lstCitas = new();
    private readonly TextBox _txtNombre = new();
    private readonly TextBox _txtApellido = new();
    private readonly TextBox _txtCurp = new();
    private readonly TextBox _txtTelefono = new();
    private readonly Button _btnAgregarPaciente = new();
    private readonly Button _btnCrearCita = new();
    private readonly Button _btnGenerarReceta = new();

    public FormPrincipal()
    {
        Text = "Clínica App";
        Size = new Size(860, 560);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(245, 247, 250);

        InitializeComponent();
        CargarDatosDemo();
    }

    private void InitializeComponent()
    {
        _txtNombre.Location = new Point(20, 30);
        _txtNombre.Width = 140;
        _txtNombre.PlaceholderText = "Nombre";

        _txtApellido.Location = new Point(180, 30);
        _txtApellido.Width = 140;
        _txtApellido.PlaceholderText = "Apellido";

        _txtCurp.Location = new Point(340, 30);
        _txtCurp.Width = 150;
        _txtCurp.PlaceholderText = "CURP";

        _txtTelefono.Location = new Point(510, 30);
        _txtTelefono.Width = 140;
        _txtTelefono.PlaceholderText = "Teléfono";

        _btnAgregarPaciente.Text = "Agregar paciente";
        _btnAgregarPaciente.Location = new Point(20, 70);
        _btnAgregarPaciente.Width = 150;
        _btnAgregarPaciente.Click += BtnAgregarPaciente_Click;

        _btnCrearCita.Text = "Crear cita";
        _btnCrearCita.Location = new Point(190, 70);
        _btnCrearCita.Width = 140;
        _btnCrearCita.Click += BtnCrearCita_Click;

        _btnGenerarReceta.Text = "Generar receta";
        _btnGenerarReceta.Location = new Point(350, 70);
        _btnGenerarReceta.Width = 150;
        _btnGenerarReceta.Click += BtnGenerarReceta_Click;

        _lstPacientes.Location = new Point(20, 120);
        _lstPacientes.Size = new Size(360, 330);

        _lstCitas.Location = new Point(410, 120);
        _lstCitas.Size = new Size(360, 330);

        Controls.Add(_txtNombre);
        Controls.Add(_txtApellido);
        Controls.Add(_txtCurp);
        Controls.Add(_txtTelefono);
        Controls.Add(_btnAgregarPaciente);
        Controls.Add(_btnCrearCita);
        Controls.Add(_btnGenerarReceta);
        Controls.Add(_lstPacientes);
        Controls.Add(_lstCitas);
    }

    private void CargarDatosDemo()
    {
        var paciente1 = new Paciente
        {
            Nombre = "Ana",
            ApellidoPaterno = "López",
            ApellidoMaterno = "Ramírez",
            Curp = "LORA850101HDF",
            FechaNacimiento = new DateTime(1985, 1, 10),
            Sexo = "Femenino",
            Telefono = "5512345678",
            Domicilio = "Calle 123",
            NumeroSeguroSocial = "123456789",
            HistoriaClinicaResumen = "Sin antecedentes relevantes",
            Alergias = "Ninguna",
            Expediente = new ExpedienteClinico
            {
                Paciente = new Paciente
                {
                    Nombre = "Ana",
                    ApellidoPaterno = "López"
                },
                UnidadAdscrita = "Hospital Central",
                AntecedentesHeredofamiliares = "Padre con hipertensión",
                AntecedentesPersonalesPatologicos = "Asma leve",
                AntecedentesNoPatologicos = "No fuma, no consume alcohol"
            }
        };

        var medico1 = new Medico
        {
            Nombre = "Carlos",
            ApellidoPaterno = "García",
            ApellidoMaterno = "Santos",
            Especialidad = "Cardiología",
            Oficina = "Consultorio 2",
            Departamento = "Cardiología",
            TipoContrato = "Tiempo completo",
            FirmaDigital = "firma123"
        };

        _clinicaService.AgregarPaciente(paciente1);

        var cita = new Cita
        {
            Paciente = paciente1,
            Medico = medico1,
            FechaCita = DateTime.Today.AddDays(2),
            HoraCita = new TimeSpan(10, 30, 0),
            Consultorio = "Consultorio 2",
            MotivoConsulta = "Chequeo general",
            Prioridad = "Alta",
            Estado = EstadoCita.Programada
        };

        _clinicaService.AgregarCita(cita);
        paciente1.AgendarCita(cita);

        RefrescarListas();
    }

    private void BtnAgregarPaciente_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtNombre.Text))
        {
            MessageBox.Show("Ingrese el nombre del paciente.");
            return;
        }

        var paciente = new Paciente
        {
            Nombre = _txtNombre.Text,
            ApellidoPaterno = _txtApellido.Text,
            Curp = _txtCurp.Text,
            Telefono = _txtTelefono.Text,
            HistoriaClinicaResumen = "Creado desde la app",
            Alergias = "Ninguna",
            Expediente = new ExpedienteClinico
            {
                Paciente = new Paciente { Nombre = _txtNombre.Text },
                UnidadAdscrita = "Hospital Central"
            }
        };

        _clinicaService.AgregarPaciente(paciente);
        RefrescarListas();

        _txtNombre.Clear();
        _txtApellido.Clear();
        _txtCurp.Clear();
        _txtTelefono.Clear();
    }

    private void BtnCrearCita_Click(object sender, EventArgs e)
    {
        if (_clinicaService.Pacientes.Count == 0)
        {
            MessageBox.Show("Debe agregar al menos un paciente.");
            return;
        }

        var paciente = _clinicaService.Pacientes[0];
        var medico = new Medico
        {
            Nombre = "Dr. Luis",
            ApellidoPaterno = "Pérez",
            Especialidad = "Medicina General",
            Oficina = "Consultorio 1",
            Departamento = "Consulta externa",
            FirmaDigital = "firma456"
        };

        var cita = new Cita
        {
            Paciente = paciente,
            Medico = medico,
            FechaCita = DateTime.Today.AddDays(3),
            HoraCita = new TimeSpan(9, 0, 0),
            Consultorio = "Consultorio 1",
            MotivoConsulta = "Consulta de seguimiento",
            Prioridad = "Media",
            Estado = EstadoCita.Programada
        };

        _clinicaService.AgregarCita(cita);
        paciente.AgendarCita(cita);
        RefrescarListas();
    }

    private void BtnGenerarReceta_Click(object sender, EventArgs e)
    {
        if (_clinicaService.Pacientes.Count == 0)
        {
            MessageBox.Show("Debe haber un paciente para generar la receta.");
            return;
        }

        var paciente = _clinicaService.Pacientes[0];
        var medico = new Medico
        {
            Nombre = "Carlos",
            ApellidoPaterno = "García",
            Especialidad = "Cardiología",
            FirmaDigital = "firma123"
        };

        var receta = medico.GenerarReceta(paciente, "Paracetamol");
        _clinicaService.AgregarReceta(receta);

        MessageBox.Show($"Receta creada: {receta.FolioReceta}");
    }

    private void RefrescarListas()
    {
        _lstPacientes.Items.Clear();
        foreach (var paciente in _clinicaService.Pacientes)
        {
            _lstPacientes.Items.Add($"{paciente.Nombre} {paciente.ApellidoPaterno} - {paciente.Curp}");
        }

        _lstCitas.Items.Clear();
        foreach (var cita in _clinicaService.Citas)
        {
            if (cita.Paciente is not null && cita.Medico is not null)
            {
                _lstCitas.Items.Add($"{cita.FechaCita:dd/MM/yyyy} {cita.HoraCita} - {cita.Paciente.Nombre} con {cita.Medico.Nombre}");
            }
        }
    }
}

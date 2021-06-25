using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_POO.ProjectPOOContext;
using Project_POO.Services;
using Project_POO.Tools;
using Project_POO.View;

namespace Project_POO
{
    public partial class FrmLogin : Form
    {
        private EmployeeServices employeeServices;
        private CenterServices centerServices;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            employeeServices = new EmployeeServices();
            centerServices = new CenterServices();
        }
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_Email.Text = "";
            txt_Pass.Text = "";
            cmb_Center.SelectedItem = null;
        }

        private void btn_Create_Appointment_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            // Encrypt
            // string pass = Encrypt.SHA256(txt_Pass.Text);
            string pass = txt_Pass.Text;
            Employee employeeToLogin = employeeServices.GetEmployeeInLogin(email, pass);

            // Show
            if (employeeToLogin != null)
            {
                int type = employeeToLogin.IdTypeEmployee;
                var centerToLogin = centerServices.GetByType(type);
                cmb_Center.DataSource = centerToLogin;
                cmb_Center.DisplayMember = "CenterAddress";
                cmb_Center.ValueMember = "Id";
                // Seccess
                MessageBox.Show("Bienvenido ", "Inicio de Sesión exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Oculta esta ventana y abre el formulario principal tras el logueo exitoso
                FrmAppointmentTracking window = new FrmAppointmentTracking();
                this.Hide();
                window.ShowDialog();
                // Reseteamos inputs
                txt_Email.Text = "";
                txt_Pass.Text = "";
                this.Show();
            }
            else
            {
                // fail
                MessageBox.Show("Usuario o contraseña son incorrectos, vuelve a introducir los datos de entrada",
                    "Inicio de Sesión falló", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

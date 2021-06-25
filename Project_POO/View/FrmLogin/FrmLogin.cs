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

        // This function resets the entire form
        private void resetForm()
        {
            txt_Email.Text = "";
            txt_Pass.Text = "";
            cmb_Center.SelectedItem = null;
            cmb_Center.Visible = false;

            // Enabling the first inputs 
            txt_Email.Enabled = true;
            txt_Pass.Enabled = true;
        }
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            resetForm();
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
 
                if (cmb_Center.SelectedItem != null)
                {// Seccess
                    MessageBox.Show("Bienvenido ", "Inicio de Sesión exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Next Form
                    FrmAppointmentTracking window = new FrmAppointmentTracking();
                    this.Hide();
                    window.ShowDialog();
                    // Reset form
                    resetForm();
                    this.Show();
                }
                // User found, now will select the center where he is logging in
                else
                { 
                    MessageBox.Show("Usuario encontrado, selecciona el centro en que estas iniciando sesión",
                        "Elige un centro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // cmb_Center now is available
                    int type = employeeToLogin.IdTypeEmployee;
                    var centerToLogin = centerServices.GetByType(type);
                    cmb_Center.Visible = true;
                    cmb_Center.DataSource = centerToLogin;
                    cmb_Center.DisplayMember = "CenterAddress";
                    cmb_Center.ValueMember = "Id";

                    // Disabled previous inputs 
                    txt_Email.Enabled = false;
                    txt_Pass.Enabled = false;
                }
            }
            else
            {
                // fail
                MessageBox.Show("Correo o contraseña son incorrectos, vuelve a introducir los datos de entrada",
                    "Inicio de Sesión falló", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetForm();
            }
        }

    }
}

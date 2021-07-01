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
using Project_POO.ViewModel;

namespace Project_POO
{
    public partial class FrmLogin : Form
    {
        private EmployeeServices employeeServices;
        private CenterServices centerServices;
        private EmployeexcenterServices employexCenterServices;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            employeeServices = new EmployeeServices();
            centerServices = new CenterServices();
            employexCenterServices = new EmployeexcenterServices();
        }

        // This function resets the entire form
        private void resetForm()
        {
            txt_Email.Text = "";
            txt_Pass.Text = "";
            cmb_Center.SelectedItem = null;
            cmb_Center.Visible = false;
            lbl_Center.Visible = false;

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
            // Encripting pass
            string pass = Encrypt.SHA256(txt_Pass.Text);
            //string pass 

            try
            {
                Employee employeeToLogin = employeeServices.GetEmployeeInLogin(email, pass);

                // Show
                if (employeeToLogin != null)
                {
                    // Verify if administrator 
                    if (employeeToLogin.IdTypeEmployee.Equals(5))
                    {
                        // Success
                        MessageBox.Show("Bienvenido Administrador", "Inicio de Sesión exitoso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Next Form
                        FrmMenuAdmin window = new FrmMenuAdmin(employeeToLogin.Id);
                        this.Hide();
                        window.ShowDialog();
                        // Reset form
                        resetForm();
                        this.Show();
                    }

                    if (cmb_Center.SelectedItem != null)
                    {
                        // Success
                        MessageBox.Show("Bienvenido ", "Inicio de Sesión exitoso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Selection
                        var selection = (Center)cmb_Center.SelectedItem;

                        // Security
                        SaveSecurityRegister(employeeToLogin.Id, selection.Id);

                        // Next Form
                        FrmAppointmentTracking window = new FrmAppointmentTracking(employeeToLogin.Id, selection.Id);
                        this.Hide();
                        window.ShowDialog();
                        // Reset form
                        resetForm();
                        this.Show();
                    }
                    // User found, now will select the center where he is logging in
                    else if (cmb_Center.SelectedItem is null && employeeToLogin.IdTypeEmployee != 5)
                    { 
                        MessageBox.Show("Usuario encontrado, selecciona el centro en que estas iniciando sesión",
                            "Elige un centro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // cmb_Center now is available
                        int type = employeeToLogin.IdTypeEmployee;

                        List<Center> centerToLogin;

                        if (employeeToLogin.IdTypeEmployee == 1 || employeeToLogin.IdTypeEmployee == 2)
                        {
                            centerToLogin = centerServices.GetByType(1);
                        }
                        else
                        {
                            centerToLogin = centerServices.GetByType(2);
                        }

                        lbl_Center.Visible = true;
                        cmb_Center.Visible = true;
                        cmb_Center.DataSource = centerToLogin;
                        cmb_Center.DisplayMember = "CenterAddress";
                        cmb_Center.ValueMember = "Id";

                        // Disabled previous inputs 
                        txt_Email.Enabled = false;
                        txt_Pass.Enabled = false;
                    }
                    else
                    {
                        // Log out
                        MessageBox.Show("Sesion cerrada exitosamente",
                            "Adios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }
                }
                else
                {
                    // Fail
                    MessageBox.Show("Correo o contraseña son incorrectos, vuelve a introducir los datos de entrada",
                        "Inicio de Sesión falló", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetForm();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Verifique que haya instalado la base de datos `GestorVaccination` en SQL EXPRESS. "+exception.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSecurityRegister(int employeeId, int centerId)
        {
            var register = new Employeexcenter(employeeId, centerId);
            employexCenterServices.Create(register);
        }

    }
}

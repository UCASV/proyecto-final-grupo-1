using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Project_POO.ProjectPOOContext;
using Project_POO.Services;
using Project_POO.Tools;

namespace Project_POO
{
    public partial class FrmRegist : Form
    {
        private EmployeeServices employeenew;

        private Employee employeeObj;

        public FrmRegist(Employee employee)
        {
            InitializeComponent();
            employeeObj = employee;
        }

        // Events
        private void FrmRegist_Load(object sender, EventArgs e)
        {
            employeenew = new EmployeeServices();
            LoadTypeEmployee();
            enable_btn_Create();

            // Set user info
            lbl_AdminName.Text = employeeObj.EName;
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_Address.Text = "";
            txt_Conf_Pass.Text = "";
            txt_Email.Text = "";
            txt_Pass.Text = "";
            txt_Name.Text = "";
            cmb_Type.SelectedItem = null;
        }

        private void LoadTypeEmployee()
        {
            var db = new GestorVaccinationContext();
            // Get The list of types
            List<TypeEmployee> type = db.TypeEmployees.ToList();
            // Give the source to the comboBox
            cmb_Type.DataSource = type;
            cmb_Type.ValueMember = "Id";
            cmb_Type.DisplayMember = "TeName";
        }

        // Change state to enable
        private void enable_btn_Create()
        {
            if (txt_Address.Text != "" &&
                txt_Conf_Pass.Text != "" &&
                txt_Email.Text != "" &&
                txt_Pass.Text != "" &&
                txt_Name.Text != "" &&
                cmb_Type.SelectedItem != null
            )
            {
                btn_Create.Enabled = true;
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_Conf_Pass_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            // Validations
            if (txt_Pass.Text.Length < 5)
            {
                MessageBox.Show("La contraseña es muy corta, asegurate de que sean mas de 5 caracteres",
                    "Contraseña corta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // The confirmation of the pass has to be equal.
            if (txt_Pass.Text != txt_Conf_Pass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, asegurate de que sean iguales",
                    "Contraseñas no coinciden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_Name.Text.Length < 5)
            {
                MessageBox.Show("Nombre de usuario muy corto, asegurate de que sean mas de 5 caracteres",
                    "Nombre de usuario corto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate Email (It has to contain an @)
            bool ContainArroba = txt_Email.Text.Contains('@');
            if (ContainArroba == false)
            {
                MessageBox.Show(
                    "Email de usuario inválido, asegurate de que contenga el caracter arroba '@' para correos",
                    "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Encripting pass
            string encryptPass = Encrypt.SHA256(txt_Pass.Text);

            // Casting cmb_Type.SelectedValue to get the ID
            var tmpType = (int) cmb_Type.SelectedValue;
            int TypeEmployee = (tmpType);

            try
            {
                // Creating new employee
                Employee employee1 = new Employee(txt_Name.Text, txt_Email.Text, encryptPass, txt_Address.Text, TypeEmployee);
                employeenew.Create(employee1);

                // Success message
                MessageBox.Show("Empleado registrado exitosamente", "Acción exitosa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

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

namespace Project_POO.View.Admin.FrmCreateCenter
{
    public partial class FrmCreateCenter : Form
    {
        private Employee employeeObj;
        private EmployeeServices _employeeS;
        private CenterServices _centerS;
        private TypeCenter TypeCenterE;
        public FrmCreateCenter(Employee employee)
        {
            InitializeComponent();
            employeeObj = employee;
        }
        private void FrmCreateCenter_Load(object sender, EventArgs e)
        {
            // Init services 
            _centerS = new CenterServices();
            _employeeS = new EmployeeServices();
            TypeCenterE = new TypeCenter();

            LoadTypeCenter();

            // For do not show initial info
            enable_btn_Create();
            cmb_EmployeeInChargeCenter.Enabled = false;
            cmb_EmployeeInChargeCenter.SelectedItem = null;
            cmb_TypeCenter.SelectedItem = null;

            // Set user info
            lbl_AdminName.Text = employeeObj.EName;
        }

        private void cmb_TypeCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_EmployeeInChargeCenter.Enabled = true;
            LoadEmployees();

            enable_btn_Create();
        }

        private void CreateCenter()
        {
            // Casting cmb_TypeCenter.SelectedValue to get the ID
            var tmpType = (int)cmb_TypeCenter.SelectedValue;
            int TypeCenter = (tmpType);

            var tmpEICharge = (int)cmb_EmployeeInChargeCenter.SelectedValue;
            int ID_EmpInCharge = (tmpEICharge);

            try
            {
                // Create center
                var tmpCenter = new Center(txt_AddressCenter.Text, txt_TelCenter.Text, txt_EmailCenter.Text,
                    TypeCenter, ID_EmpInCharge);

                if (_centerS.ValidateCenter(tmpCenter))
                {
                    _centerS.Create(tmpCenter);

                    MessageBox.Show("Centro añadido exitosamente", "Acción exitosa", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    MessageBox.Show("Error al añadir el centro", "Hubo un error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // To load
        private void LoadTypeCenter()
        {
            var db = new GestorVaccinationContext();
            // Get The list of types
            List<TypeCenter> type = db.TypeCenters.ToList();

            // Give the source to the comboBox
            cmb_TypeCenter.DataSource = type;
            cmb_TypeCenter.ValueMember = "Id";
            cmb_TypeCenter.DisplayMember = "TcName";
        }

        private void LoadEmployees()
        {
            // Get type center
            var selection = (TypeCenter)cmb_TypeCenter.SelectedItem;

            if (selection is not null)
            {
                // Get the admin specifically for this type of center that just are "gestores" and not "admin"
                List<Employee> employeesToBeAdminCenter;

                if (selection.Id.Equals(1))
                    employeesToBeAdminCenter = _employeeS.GetEmployeeInCreateCenter(2);
                else
                    employeesToBeAdminCenter = _employeeS.GetEmployeeInCreateCenter(4);

                cmb_EmployeeInChargeCenter.DataSource = employeesToBeAdminCenter;
                cmb_EmployeeInChargeCenter.ValueMember = "Id";
                cmb_EmployeeInChargeCenter.DisplayMember = "EName";
            }
        }

        // Event click to create a new center
        private void btn_RegistCenter_Click(object sender, EventArgs e)
        {
            CreateCenter();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_AddressCenter.Clear();
            txt_EmailCenter.Clear();
            txt_TelCenter.Clear();
            cmb_EmployeeInChargeCenter.SelectedItem = null;
            cmb_TypeCenter.SelectedItem = null;
        }

        // Enable to btn Create
        private void enable_btn_Create()
        {
            if (txt_AddressCenter.Text != "" &&
                txt_EmailCenter.Text != "" &&
                txt_TelCenter.Text != "" &&
                cmb_EmployeeInChargeCenter.Text != null &&
                cmb_TypeCenter.Text != null
            )
                btn_RegistCenter.Enabled = true;
        }

        private void txt_AddressCenter_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_TelCenter_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void txt_EmailCenter_TextChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }

        private void cmb_EmployeeInChargeCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            enable_btn_Create();
        }
    }
}

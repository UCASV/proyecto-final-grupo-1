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
using Project_POO.ViewModel;

namespace Project_POO.View.Admin.FrmSecurity
{
    public partial class FrmSecurity : Form
    {
        private Employee employeeObj;
        private EmployeexcenterServices emmployexCenterServices;

        public FrmSecurity(Employee employee)
        {
            InitializeComponent();
            employeeObj = employee;

            emmployexCenterServices = new EmployeexcenterServices();
        }

        private void FrmSecurity_Load(object sender, EventArgs e)
        {
            // Set user info
            lbl_AdminName.Text = employeeObj.EName;

            LoadSecurityRegister();
        }

        private void LoadSecurityRegister()
        {
            var register = emmployexCenterServices.GetAll();

            // Mapping effects
            List<EmployeexcenterVm> mapedRegister = new List<EmployeexcenterVm>();
            register.ForEach(x => mapedRegister.Add(ProjectMapper.MapEmployeexcenterToVm(x)));

            dgv_Security.DataSource = null;
            dgv_Security.DataSource = mapedRegister;
        }
    }
}

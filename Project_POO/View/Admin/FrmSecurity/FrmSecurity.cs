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

namespace Project_POO.View.Admin.FrmSecurity
{
    public partial class FrmSecurity : Form
    {
        private Employee employeeObj;
        public FrmSecurity(Employee employee)
        {
            InitializeComponent();
            employeeObj = employee;
        }

        private void FrmSecurity_Load(object sender, EventArgs e)
        {
            // Set user info
            lbl_AdminName.Text = employeeObj.EName;
        }
    }
}

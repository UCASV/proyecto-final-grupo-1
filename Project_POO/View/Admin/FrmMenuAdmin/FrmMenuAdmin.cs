﻿using System;
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
using Project_POO.View;

namespace Project_POO.ViewModel
{
    public partial class FrmMenuAdmin : Form
    {
        private int tmpId = 0;
        private Employee employeeObj;
        private EmployeeServices _employeeS;
  
        public FrmMenuAdmin(int employeeId)
        {
            InitializeComponent();
            tmpId = employeeId;
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            _employeeS = new EmployeeServices();

            // Get user data
            employeeObj = _employeeS.GetEmployee(tmpId);
            // Set user info
            lbl_AdminName.Text = employeeObj.EName;
        }

        private void btn_RegistEmployee_Click(object sender, EventArgs e)
        {
            // Admin new window
            FrmRegist window = new FrmRegist();
            this.Hide();
            window.ShowDialog();
            this.Show();

        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            // Admin new window
            FrmStatistics window = new FrmStatistics(employeeObj);
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
    }
}

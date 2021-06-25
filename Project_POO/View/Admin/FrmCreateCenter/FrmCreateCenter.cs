using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_POO.View.Admin.FrmCreateCenter
{
    public partial class FrmCreateCenter : Form
    {
        public FrmCreateCenter()
        {
            InitializeComponent();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_AddressCenter.Text = "";
            txt_EmailCenter.Text = "";
            txt_TelCenter.Text = "";
            cmb_EmployeeInChargeCenter.SelectedItem = null;
            cmb_TypeCenter.SelectedItem = null;
        }
    }
}

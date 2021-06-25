using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_POO
{
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
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
    }
}

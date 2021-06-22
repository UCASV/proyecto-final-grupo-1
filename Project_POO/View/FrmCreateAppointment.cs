using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyect_POO
{
    public partial class FrmCreateAppointment : Form
    {
        public FrmCreateAppointment()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            dtp_BirthDate.MaxDate = DateTime.Now;
        }

    }
}

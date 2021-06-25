using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_POO.View;

namespace Project_POO.ViewModel
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
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
            FrmStatistics window = new FrmStatistics();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
    }
}

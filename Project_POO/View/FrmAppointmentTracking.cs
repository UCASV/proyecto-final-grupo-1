using Project_POO.Services;
using Project_POO.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_POO.View
{
    public partial class FrmAppointmentTracking : Form
    {
        public FrmAppointmentTracking()
        {
            InitializeComponent();
        }

        private void FrmAppointmentTracking_Load(object sender, EventArgs e)
        {
            GetAppointments();
        }

        private void GetAppointments()
        {
            var appointmentS = new AppointmentServices();
            var appointments = appointmentS.GetAll();

            List<AppointmentVm> mapedAppointments = new List<AppointmentVm>();

            // Mapping appointments
            appointments.ForEach(x => mapedAppointments.Add(ProjectMapper.MapAppointmentToVm(x)));

            dgv_Appointments.DataSource = null;
            dgv_Appointments.DataSource = mapedAppointments;
        }

        private void dgv_Appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select appointment
            int tmpId = (int)dgv_Appointments.SelectedRows[0].Cells["Id"].Value;

            var appointmentS = new AppointmentServices();
            var tmpUser = appointmentS.GetAppointment(tmpId);

            // Set info
            lbl_Citizen_Name.Text = tmpUser.IdCitizenNavigation.CName;
            lbl_CitizenDUI.Text = tmpUser.IdCitizenNavigation.Dui;

            // Change tab
            tbc_AT.SelectedIndex = 1;
        }

        private void tbc_AT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlp_AT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

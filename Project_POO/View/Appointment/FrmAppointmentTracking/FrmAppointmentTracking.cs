using Project_POO.ProjectPOOContext;
using Project_POO.Services;
using Project_POO.ViewModel;
using Proyect_POO;
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
        private int tmpAppointmentId;
        private Appointment tmpAppointmentObj;

        private AppointmentServices _appointmentS;
        private CitizenServices _citizenS;
        private SecondaryEffectServices _secondaryEffectS;

        public FrmAppointmentTracking()
        {
            InitializeComponent();
        }

        private void FrmAppointmentTracking_Load(object sender, EventArgs e)
        {
            tmpAppointmentId = 0;

            _appointmentS = new AppointmentServices();
            _citizenS = new CitizenServices();
            _secondaryEffectS = new SecondaryEffectServices();

            // Tab control style
            tbc_AT.Appearance = TabAppearance.FlatButtons;
            tbc_AT.ItemSize = new Size(0, 1);
            tbc_AT.SizeMode = TabSizeMode.Fixed;
            tbc_AT.TabStop = false;

            GetAppointments();
        }

        private void GetAppointments()
        {
            var appointments = _appointmentS.GetAll();

            // Mapping appointments
            List<AppointmentVm> mapedAppointments = new List<AppointmentVm>();
            appointments.ForEach(x => mapedAppointments.Add(ProjectMapper.MapAppointmentToVm(x)));

            dgv_Appointments.DataSource = null;
            dgv_Appointments.DataSource = mapedAppointments;
        }

        private void dgv_Appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var varUserType = 2;

            // Select appointment
            int tmpId = (int)dgv_Appointments.SelectedRows[0].Cells["Id"].Value;
            tmpAppointmentId = tmpId;

            if (varUserType == 2)
                SetInfoForVaccinationCenter();
            else
                SetInfoForCabinCenter();
        }


        private void SetInfoForVaccinationCenter()
        {
            // Get one appointment info
            var tmpAppointment = _appointmentS.GetAppointment(tmpAppointmentId);
            var tmpDiseases = _citizenS.GetDiseasesByUser(tmpAppointment.IdCitizenNavigation.Dui);
            var tmpEffects = _appointmentS.GetAppointmentEffects(tmpAppointment.Id);

            // Store current appointment
            tmpAppointmentObj = tmpAppointment;

            // Mapping diseases
            List<CitizenxchronicDiseaseVm> mapedDiseases = new List<CitizenxchronicDiseaseVm>();
            tmpDiseases.ForEach(x => mapedDiseases.Add(ProjectMapper.MapCitizenxchronicDiseaseToVm(x)));

            // Mapping effects
            List<AppointmentxsecondaryEffectVm> mapedEffects = new List<AppointmentxsecondaryEffectVm>();
            tmpEffects.ForEach(x => mapedEffects.Add(ProjectMapper.MapAppointmentxsecondaryEffectToVm(x)));

            // Set info
            lbl_Citizen_Name.Text = tmpAppointment.IdCitizenNavigation.CName;
            lbl_CitizenDUI.Text = tmpAppointment.IdCitizenNavigation.Dui;
            lbl_CitizenAge.Text = $"{tmpAppointment.IdCitizenNavigation.Age} años";
            lbl_CitizenEmail.Text = tmpAppointment.IdCitizenNavigation.Email;
            lbl_CitizenTel.Text = tmpAppointment.IdCitizenNavigation.Tel;
            lbl_CitizenAddress.Text = tmpAppointment.IdCitizenNavigation.CAddress;

            if (tmpAppointment.IdCitizenNavigation.IdInstitution is not null)
                lbl_CitizenInstitution.Text = tmpAppointment.IdCitizenNavigation.IdInstitutionNavigation.IName;
            else
                lbl_CitizenInstitution.Text = "No especificado";

            dgv_CD.DataSource = null;
            dgv_CD.DataSource = mapedDiseases;

            lbl_status.Text = (tmpAppointment.AStatus is false) ? "Pendiente" : "Finalizada";
            lbl_Name_Employee.Text = tmpAppointment.IdEmployeeNavigation.EName;
            lbl_Cabin_N.Text = tmpAppointment.IdCabinNavigation.CenterAddress;
            lbl_Hour.Text = tmpAppointment.ADatetime.ToString();

            dgv_SE.DataSource = null;
            dgv_SE.DataSource = mapedEffects;

            // Load secondary effects
            LoadSecondaryEffects();

            // Enable or disable selection boxes and add secondary effects -> must be completed...
            if (tmpAppointmentObj.AStatus is true)
            {
                cbx_Arrived.Enabled = false;
                // cbx_Arrived.Checked = true;

                cbx_Vaccinated.Visible = true;
                cbx_Vaccinated.Enabled = false;
                // cbx_Vaccinated.Checked = true;
            }
            else if (tmpAppointmentObj.StartTime is not null)
            {
                cbx_Arrived.Enabled = false;
                // cbx_Arrived.Checked = true;

                cbx_Vaccinated.Visible = true;
                cbx_Vaccinated.Enabled = true;
            }
            else
            {
                cbx_Arrived.Enabled = true;
                cbx_Vaccinated.Visible = false;
            }

            // Change tab
            tbc_AT.SelectedIndex = 1;
        }

        private void SetInfoForCabinCenter()
        {
            // Get one appointment info
            var tmpAppointment = _appointmentS.GetAppointment(tmpAppointmentId);
            var tmpDiseases = _citizenS.GetDiseasesByUser(tmpAppointment.IdCitizenNavigation.Dui);

            // Store current appointment
            tmpAppointmentObj = tmpAppointment;

            // Mapping diseases
            List<CitizenxchronicDiseaseVm> mapedDiseases = new List<CitizenxchronicDiseaseVm>();
            tmpDiseases.ForEach(x => mapedDiseases.Add(ProjectMapper.MapCitizenxchronicDiseaseToVm(x)));

            // Set info
            lbl_CName.Text = tmpAppointment.IdCitizenNavigation.CName;
            lbl_CDUI.Text = tmpAppointment.IdCitizenNavigation.Dui;
            lbl_CAge.Text = $"{tmpAppointment.IdCitizenNavigation.Age} años";
            lbl_CEmail.Text = tmpAppointment.IdCitizenNavigation.Email;
            lbl_CTel.Text = tmpAppointment.IdCitizenNavigation.Tel;
            lbl_CAddress.Text = tmpAppointment.IdCitizenNavigation.CAddress;

            if (tmpAppointment.IdCitizenNavigation.IdInstitution is not null)
                lbl_CInstitution.Text = tmpAppointment.IdCitizenNavigation.IdInstitutionNavigation.IName;
            else
                lbl_CInstitution.Text = "No especificado";

            dgv_.DataSource = null;
            dgv_.DataSource = mapedDiseases;

            lbl_Employee_Name_Print.Text = tmpAppointment.IdEmployeeNavigation.EName;
            lbl_Cabin_Print.Text = tmpAppointment.IdCabinNavigation.CenterAddress;
            lbl_Time_Appointment_Print.Text = tmpAppointment.ADatetime.ToString();
            lbl_CenterAsigned.Text = tmpAppointment.IdVaccinationCenterNavigation.CenterAddress;

            // Change tab
            tbc_AT.SelectedIndex = 2;
        }

        private void cbx_Arrived_CheckedChanged(object sender, EventArgs e)
        {
            // Citizen arrival
            cbx_Arrived.Enabled = false;
            cbx_Vaccinated.Visible = true;

            // Get current time
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Update start time 
            tmpAppointmentObj.StartTime = currentTime;
            _appointmentS.Update(tmpAppointmentObj);

            MessageBox.Show("Hora de llegada actualizada");
        }

        private void cbx_Vaccinated_CheckedChanged(object sender, EventArgs e)
        {
            // Citizen vaccinated
            cbx_Vaccinated.Enabled = false;

            // Get current time
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Update final time 
            tmpAppointmentObj.FinalTime = currentTime;
            tmpAppointmentObj.AStatus = true;
            _appointmentS.Update(tmpAppointmentObj);

            // Create second appointment is pending...

            MessageBox.Show("Hora de vacunacion actualizada");
        }

        private void btn_Create_Appointment_Click(object sender, EventArgs e)
        {
            // Add secondary effect
            if ((int)nud_DurationSE.Value > 0)
            {
                int tmpEffectSelection = (int)cmb_NameSE.SelectedValue;

                var newAppointmentEffect = new AppointmentxsecondaryEffect(tmpAppointmentObj.Id, 
                    tmpEffectSelection, (int)nud_DurationSE.Value);

                _appointmentS.SaveSecondaryEffects(newAppointmentEffect);

                MessageBox.Show("Efecto secundario agregado con exito");
            }
            else
                MessageBox.Show("Duracion de efecto secundario no valida");
        }

        private void LoadSecondaryEffects()
        {
            var secondaryEffects = _secondaryEffectS.GetAll();

            cmb_NameSE.DataSource = null;
            cmb_NameSE.DataSource = secondaryEffects;
            cmb_NameSE.DisplayMember = "SeName";
            cmb_NameSE.ValueMember = "Id";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmCreateAppointment window = new FrmCreateAppointment();
            this.Hide();
            window.ShowDialog();
            // Reload updates
            GetAppointments();
            this.Show();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String text = String.Format("Comrpobante de cita \n" +
                "Nombre: {0}\nFecha y hora: {1}\nCentro de vacunacion: {2}",
                lbl_CName.Text, lbl_Time_Appointment_Print.Text, lbl_CenterAsigned.Text);

            e.Graphics.DrawImage(Properties.Resources.vaccine, new PointF(100, 100));
            e.Graphics.DrawString(text, new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 350));
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            // Change tab
            tbc_AT.SelectedIndex = 0;
            GetAppointments();
        }

        private void btn_back_1_Click(object sender, EventArgs e)
        {
            // Change tab
            tbc_AT.SelectedIndex = 0;
            GetAppointments();
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

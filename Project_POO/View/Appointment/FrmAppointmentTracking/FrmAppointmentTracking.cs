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
        private int tmpEmployeeId = 0;
        private int tmpCenterId = 0;

        private Employee LocalEmployee;
        private Center LocalCenter;

        private int tmpAppointmentId;
        private Appointment tmpAppointmentObj;

        private EmployeeServices _employeeS;
        private CenterServices _centerS;
        private AppointmentServices _appointmentS;
        private CitizenServices _citizenS;
        private SecondaryEffectServices _secondaryEffectS;

        public FrmAppointmentTracking(int eemployeId, int centerId)
        {
            InitializeComponent();
            tmpEmployeeId = eemployeId;
            tmpCenterId = centerId;
        }

        private void FrmAppointmentTracking_Load(object sender, EventArgs e)
        {
            _employeeS = new EmployeeServices();
            _centerS = new CenterServices();
            _appointmentS = new AppointmentServices();
            _citizenS = new CitizenServices();
            _secondaryEffectS = new SecondaryEffectServices();

            LocalEmployee = _employeeS.GetEmployee(tmpEmployeeId);
            LocalCenter = _centerS.GetCenter(tmpCenterId);

            // Footer
            lbl_EmployeeName.Text = LocalEmployee.EName;
            // lbl_TypeEmployee.Text = LocalEmployee.IdTypeEmployeeNavigation.TeName; // falta un include...
            lbl_VaccinationEmployeeName.Text = LocalEmployee.EName;
            lbl_CabinEmployee_Name.Text = LocalEmployee.EName;

            // Tab control style
            tbc_AT.Appearance = TabAppearance.FlatButtons;
            tbc_AT.ItemSize = new Size(0, 1);
            tbc_AT.SizeMode = TabSizeMode.Fixed;
            tbc_AT.TabStop = false;

            // Search default value
            cmb_Method_Search.SelectedIndex = 0;

            GetAppointments();
        }

        private void GetAppointments()
        {
            List<Appointment> appointments;

            // Get Data based on center
            if (LocalCenter.IdCenterType.Equals(2))
                appointments = _appointmentS.GetAllByCenter(LocalCenter.Id);
            else
                appointments = _appointmentS.GetAll();

            // Mapping appointments
            List<AppointmentVm> mapedAppointments = new List<AppointmentVm>();
            appointments.ForEach(x => mapedAppointments.Add(ProjectMapper.MapAppointmentToVm(x)));

            dgv_Appointments.DataSource = null;
            dgv_Appointments.DataSource = mapedAppointments;
        }

        private void dgv_Appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select appointment
            int tmpId = (int)dgv_Appointments.SelectedRows[0].Cells["Id"].Value;
            tmpAppointmentId = tmpId;

            // Clean check box
            cbx_Arrived.Checked = false;
            cbx_Vaccinated.Checked = false;

            if (LocalEmployee.IdTypeEmployee == 3 || LocalEmployee.IdTypeEmployee == 4)
                SetInfoForVaccinationCenter();
            else
                SetInfoForCabinCenter();
        }

        private void SetInfoForVaccinationCenter()
        {
            // Get one appointment info
            var tmpAppointment = _appointmentS.GetAppointment(tmpAppointmentId);
     
            // Store current appointment
            tmpAppointmentObj = tmpAppointment;

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

            // Load citizen diseases
            LoadCitizenDiseases();

            lbl_status.Text = (tmpAppointment.AStatus is false) ? "Pendiente" : "Finalizada";
            lbl_Cabin_N.Text = tmpAppointment.IdCabinNavigation.CenterAddress;
            lbl_Center_N.Text = tmpAppointment.IdVaccinationCenterNavigation.CenterAddress;
            lbl_Hour.Text = tmpAppointment.ADatetime.ToString();

            // Load secondary effects
            LoadSecondaryEffects();
            // Appointment secondary effects
            LoadCxASecondaryEffects();

            // Enable or disable selection boxes and add secondary effects
            if (tmpAppointmentObj.AStatus.Equals(false))
            {
                if (tmpAppointmentObj.StartTime is not null)
                {
                    cbx_Arrived.Enabled = false;

                    cbx_Vaccinated.Visible = true;
                    cbx_Vaccinated.Enabled = true;

                    btn_Report.Enabled = false;
                }
                else
                {
                    cbx_Arrived.Enabled = true;
                    cbx_Vaccinated.Visible = false;

                    btn_Report.Enabled = false;
                }
            }
            else 
            {
                cbx_Arrived.Enabled = false;

                cbx_Vaccinated.Visible = true;
                cbx_Vaccinated.Enabled = false;

                btn_Report.Enabled = true;
            }

            // Change tab
            tbc_AT.SelectedIndex = 1;
        }

        private void SetInfoForCabinCenter()
        {
            // Get one appointment info
            var tmpAppointment = _appointmentS.GetAppointment(tmpAppointmentId);

            // Store current appointment
            tmpAppointmentObj = tmpAppointment;

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

            // Load citizen diseases
            LoadCitizenDiseases();

            lbl_Employee_Name_Print.Text = tmpAppointment.IdEmployeeNavigation.EName;
            lbl_Cabin_Print.Text = tmpAppointment.IdCabinNavigation.CenterAddress;
            lbl_Time_Appointment_Print.Text = tmpAppointment.ADatetime.ToString();
            lbl_CenterAsigned.Text = tmpAppointment.IdVaccinationCenterNavigation.CenterAddress;

            // Change tab
            tbc_AT.SelectedIndex = 2;
        }

        private void LoadCxASecondaryEffects()
        {
            // Appointment secondary effects
            var tmpEffects = _appointmentS.GetAppointmentEffects(tmpAppointmentObj.Id);

            // Mapping effects
            List<AppointmentxsecondaryEffectVm> mapedEffects = new List<AppointmentxsecondaryEffectVm>();
            tmpEffects.ForEach(x => mapedEffects.Add(ProjectMapper.MapAppointmentxsecondaryEffectToVm(x)));

            dgv_SE.DataSource = null;
            dgv_SE.DataSource = mapedEffects;
        }

        private void LoadCitizenDiseases()
        {
            // Citizen diseases
            var tmpDiseases = _citizenS.GetDiseasesByUser(tmpAppointmentObj.IdCitizenNavigation.Dui);

            // Mapping diseases
            List<CitizenxchronicDiseaseVm> mapedDiseases = new List<CitizenxchronicDiseaseVm>();
            tmpDiseases.ForEach(x => mapedDiseases.Add(ProjectMapper.MapCitizenxchronicDiseaseToVm(x)));

            dgv_CD.DataSource = null;
            dgv_CD.DataSource = mapedDiseases;

            dgv_.DataSource = null;
            dgv_.DataSource = mapedDiseases;
        }

        private void cbx_Arrived_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Arrived.Checked is true)
            {
                // Citizen arrival
                cbx_Arrived.Enabled = false;
                cbx_Vaccinated.Visible = true;

                // Get current time
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                // Update start time 
                tmpAppointmentObj.StartTime = currentTime;
                _appointmentS.Update(tmpAppointmentObj);

                // Update appointment info
                if (LocalEmployee.IdTypeEmployee == 3 || LocalEmployee.IdTypeEmployee == 4)
                    SetInfoForVaccinationCenter();
                else
                    SetInfoForCabinCenter();

                MessageBox.Show("Hora de llegada actualizada", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbx_Vaccinated_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Vaccinated.Checked is true)
            {
                // Citizen vaccinated
                cbx_Vaccinated.Enabled = false;

                // Get current time
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                // Update final time 
                tmpAppointmentObj.FinalTime = currentTime;
                tmpAppointmentObj.AStatus = true;
                _appointmentS.Update(tmpAppointmentObj);

                // Update appointment info
                if (LocalEmployee.IdTypeEmployee == 3 || LocalEmployee.IdTypeEmployee == 4)
                    SetInfoForVaccinationCenter();
                else
                    SetInfoForCabinCenter();

                // Create second appointment
                if (tmpAppointmentObj.IdTypeAppointment.Equals(1))
                    CreateSecondAppointment();

                MessageBox.Show("Hora de vacunacion actualizada", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateSecondAppointment()
        {
            // Get DateTime 
            var appointmentDate = GetAppointmentDate();

            try
            {
                var tmpAppointment = new Appointment(tmpAppointmentObj.IdCitizen, LocalEmployee.Id, LocalCenter.Id,
                    tmpAppointmentObj.IdVaccinationCenter, appointmentDate, 2);
                _appointmentS.Create(tmpAppointment);

                MessageBox.Show("Cita agregada con exito", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private DateTime GetAppointmentDate()
        {
            var pending = true;

            DateTime today = DateTime.Now;
            today = _appointmentS.ChangeTime(today, 7);
            DateTime appointmentDate = today.AddDays(42);

            do
            {
                // If selected date alredy has an appointment it changes to the next one
                if (_appointmentS.CountAppointmentsByDate(appointmentDate) >= 1)
                {
                    appointmentDate = appointmentDate.AddDays(1);
                }
                else
                    pending = false;
            }
            while (pending);

            return appointmentDate;
        }

        private void btn_Create_Appointment_Click(object sender, EventArgs e)
        {
            var tmpEffects = _appointmentS.GetAppointmentEffects(tmpAppointmentObj.Id);

            // Add secondary effect
            int tmpEffectSelection = (int)cmb_NameSE.SelectedValue;

            // Validate if secondary effect already exist in this appointment
            if (ValidateSecondaryEffectAdd(tmpEffects, tmpEffectSelection)) 
            {
                // Validate secondary effect duration
                if ((int)nud_DurationSE.Value > 0)
                {
                    var newAppointmentEffect = new AppointmentxsecondaryEffect(tmpAppointmentObj.Id,
                        tmpEffectSelection, (int)nud_DurationSE.Value);

                    _appointmentS.SaveSecondaryEffects(newAppointmentEffect);

                    // Refresh appointment secondary effects
                    LoadCxASecondaryEffects();

                    MessageBox.Show("Efecto secundario agregado con exito", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Duracion de efecto secundario no valida", "Error en la duración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Efecto secundario previamente registrado", "Efecto repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidateSecondaryEffectAdd(List<AppointmentxsecondaryEffect> tmpEffects, int currentEffect)
        {
            foreach (var x in tmpEffects)
            {
                if (x.IdSecondaryEffect.Equals(currentEffect))
                    return false;
            }

            return true;
        }

        private void LoadSecondaryEffects()
        {
            // All secondary effects
            var secondaryEffects = _secondaryEffectS.GetAll();

            cmb_NameSE.DataSource = null;
            cmb_NameSE.DataSource = secondaryEffects;
            cmb_NameSE.DisplayMember = "SeName";
            cmb_NameSE.ValueMember = "Id";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FrmCreateAppointment window = new FrmCreateAppointment(LocalEmployee, LocalCenter);
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
            String text = String.Format("Comrpobante de cita - Vacuna COVID\n" +
                "Nombre: {0}\nDUI: {1}\nFecha y hora: {2}\nCentro de vacunacion: {3}",
                lbl_CName.Text, lbl_CDUI.Text, lbl_Time_Appointment_Print.Text, lbl_CenterAsigned.Text);

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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<Appointment> searchAppointments;

            // Search
            if ((string)cmb_Method_Search.SelectedItem == "DUI")
                searchAppointments = _appointmentS.GetSearch(true, txt_Search.Text);
            else
                searchAppointments = _appointmentS.GetSearch(false, txt_Search.Text);

            // Mapping appointments
            List<AppointmentVm> mapedAppointments = new List<AppointmentVm>();
            searchAppointments.ForEach(x => mapedAppointments.Add(ProjectMapper.MapAppointmentToVm(x)));

            dgv_Appointments.DataSource = null;
            dgv_Appointments.DataSource = mapedAppointments;
        }
    }
}

using Project_POO.ProjectPOOContext;
using Project_POO.Services;
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
        private Employee LocalEmployee;
        private Center LocalCenter;
        private int VaccinationCenter;

        private InstitutionServices _institutionS;
        private CenterServices _centerS;
        private AppointmentServices _appointmentS;
        private CitizenServices _citzenS;
        private ChronicDiseaseServices _chronicDiseaseServices;

        public FrmCreateAppointment(Employee eemploye, Center center)
        {
            InitializeComponent();
            LocalEmployee = eemploye;
            LocalCenter = center;
        }

        private void Create_Load(object sender, EventArgs e)
        {
            // Set vaccination center
            VaccinationCenter = 1;

            // Init services 
            _institutionS = new InstitutionServices();
            _centerS = new CenterServices();
            _appointmentS = new AppointmentServices();
            _citzenS = new CitizenServices();
            _chronicDiseaseServices = new ChronicDiseaseServices();

            // Set max birth day
            dtp_BirthDate.MaxDate = DateTime.Now;

            LoadDiseases();
            LoadDocumentsInfo();
        }

        private void CreateUserAppointment()
        {
            // Start process to add an appointment

            // Create a new user ang get its DUI
            var tmpDUI = CreateUser();

            if (tmpDUI != "exists")
            {
                if (tmpDUI != "error")
                {
                    if (tmpDUI != "not-elegible")
                    {
                        // Get DateTime -> temp function
                        var appointmentDate = GetAppointmentDate();

                        try
                        {
                            // Select next vaccination center
                            DefineVaccinationCenter();

                            var tmpAppointment = new Appointment(tmpDUI, LocalEmployee.Id, LocalCenter.Id,
                                VaccinationCenter, appointmentDate, 1);
                            _appointmentS.Create(tmpAppointment);

                            // Success message
                            MessageBox.Show("Cita agregada con exito", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                    }
                    else
                        MessageBox.Show("Usuario no elegible para la vacunación", "Información incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Verifique que la información tenga el formato estipulado", "Información incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("El usuario con este DUI ya tiene una cita", "Información incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private DateTime GetAppointmentDate()
        {
            var pending = true;

            DateTime today = DateTime.Now;
            today = _appointmentS.ChangeTime(today, 7);
            DateTime appointmentDate = today.AddDays(1);

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

        private void DefineVaccinationCenter()
        {
            // Define next vaccination center based on last insert
            var appointmentsList = _appointmentS.GetAll();
            var availableCenter = _centerS.GetByType(2);

            if (appointmentsList.Count % 2 == 0)
                VaccinationCenter = availableCenter[0].Id;
            else
                VaccinationCenter = availableCenter[1].Id;
        }

        private string CreateUser()
        {
            // Verify if user exists
            if (_citzenS.VerifyICitizenExists(txt_DUI.Text))
                return "exists";

            // Get citizen institution
            var tmpInstitution = (int)cmb_TypeDoc.SelectedValue;
            int? citizenInstitution = (tmpInstitution.Equals(13)) ? null : tmpInstitution;

            // Get reference dates
            var citizenBirthDate = dtp_BirthDate.Value;
            var today = DateTime.Now;

            // Get citizen age in years
            var yearsOld = today - citizenBirthDate;
            byte years = (byte)(yearsOld.TotalDays / 365.25);

            // Create citizen
            var tmpCitizen = new Citizen(txt_DUI.Text, txt_Name.Text, txt_Address.Text,
                txt_Tel.Text, txt_Email.Text, years, citizenInstitution);


            List<CitizenxchronicDisease> tmpCxD = new List<CitizenxchronicDisease>();
            var selectedDiseases = clb_CD.CheckedItems;

            foreach (var item in selectedDiseases)
            {
                var tmpItem = (ChronicDisease)item;
                tmpCxD.Add(new CitizenxchronicDisease(tmpCitizen.Dui, tmpItem.Id));
            }

            if (_citzenS.ValidateCitizen(tmpCitizen))
            {
                if (_citzenS.ValidateElegibleCitizen(tmpCitizen, tmpCxD))
                {
                    _citzenS.Create(tmpCitizen);
                    _citzenS.SaveCitizenDiseases(tmpCxD);
                    return tmpCitizen.Dui;
                }
                else
                    return "not-elegible";
            }
            else
                return "error";
        }

        private void LoadDocumentsInfo()
        {
            // Get institutions
            var institutions = _institutionS.GetAll();

            // Set default option
            var defOption = new Institution(13, "No especificado");
            institutions.Insert(0, defOption);

            cmb_TypeDoc.DataSource = institutions;
            cmb_TypeDoc.ValueMember = "Id";
            cmb_TypeDoc.DisplayMember = "IName";
        }

        private void LoadDiseases()
        {
            // Get diseases
            var diseases = _chronicDiseaseServices.GetAll();

            clb_CD.DataSource = null;
            clb_CD.DataSource = diseases;
            clb_CD.DisplayMember = "ChName";
            clb_CD.ValueMember = "Id";
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            // Pending -> Clean form 
            txt_Name.Clear();
            txt_Address.Clear();
            txt_DUI.Clear();
            txt_Tel.Clear();
        }

        private void btn_Create_Appointment_Click(object sender, EventArgs e)
        {
            CreateUserAppointment();
        }
    }
}

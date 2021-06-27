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

        // private EmployeeServices _employeeS;
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
            // _employeeS = new EmployeeServices();
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

            if (tmpDUI != "error")
            {
                // Get DateTime -> temp function
                var appointmentDate = GetAppointmentDate();

                try
                {
                    var tmpAppointment = new Appointment(tmpDUI, LocalEmployee.Id, LocalCenter.Id,
                        VaccinationCenter, appointmentDate, 1);
                    _appointmentS.Create(tmpAppointment);

                    DefineNextVaccinationCenter();

                    MessageBox.Show("Cita agregada con exito");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
            else
                MessageBox.Show("Error creating user");
        }

        private DateTime GetAppointmentDate()
        {
            var pending = true;

            DateTime today = DateTime.Now;
            today = ChangeTime(today, 7);
            DateTime appointmentDate = today.AddDays(1);

            do
            {
                // If selected date alredy has an appointment it changes to the next one
                if (_appointmentS.CountAppointmentsByDate(appointmentDate) > 1)
                {
                    appointmentDate = appointmentDate.AddDays(1);
                }
                else
                    pending = false;
            }
            while (pending);

            return appointmentDate;
        }

        private void DefineNextVaccinationCenter()
        {
            // Define next vaccination center based on last insert
            var appointmentsList = _appointmentS.GetAll();

            if (appointmentsList.Count != 0)
            {
                var lastItem = appointmentsList[appointmentsList.Count - 1];
                if (lastItem.IdVaccinationCenter < appointmentsList.Count)
                    VaccinationCenter++;
                else
                    VaccinationCenter = 1;
            }
            else
                VaccinationCenter = 1;
        }

        private string CreateUser()
        {
            // Pending -> input data validation for format...
            // Get citizen institution
            var tmpInstitution = (int)txt_TypeDoc.SelectedValue;
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

            // Create diseases list based on selections
            // var chronicDiseaseS = new ChronicDiseaseServices();
            // var diseases = chronicDiseaseS.GetAll();

            List<CitizenxchronicDisease> tmpCxD = new List<CitizenxchronicDisease>();
            var selectedDiseases = clb_CD.CheckedItems;

            foreach (var item in selectedDiseases)
            {
                var tmpItem = (ChronicDisease)item;
                // MessageBox.Show($"I: {tmpItem.Id} Item: {tmpItem.ChName}");
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
                    return "error";
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

            txt_TypeDoc.DataSource = institutions;
            txt_TypeDoc.ValueMember = "Id";
            txt_TypeDoc.DisplayMember = "IName";
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

        public DateTime ChangeTime(DateTime dateTime, int hours, int minutes = 0, int seconds = 0, int milliseconds = 0)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            // Pending -> Clean form 
        }

        private void btn_Create_Appointment_Click(object sender, EventArgs e)
        {
            CreateUserAppointment();
        }
    }
}

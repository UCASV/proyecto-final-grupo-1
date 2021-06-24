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

        public FrmCreateAppointment()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            // Set vaccination center
            VaccinationCenter = 1;

            // set employee info
            var employeeS = new EmployeeServices();
            LocalEmployee = employeeS.GetEmployee(1);

            // set center info
            var centerS = new CenterServices();
            LocalCenter = centerS.GetCenter(1);

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
                var appointmentS = new AppointmentServices();

                // Get DateTime -> temp function
                var appointmentDate = GetAppointmentDate();

                try
                {
                    var tmpAppointment = new Appointment(tmpDUI, LocalEmployee.Id, LocalCenter.Id,
                        VaccinationCenter, appointmentDate, 1);
                    appointmentS.Create(tmpAppointment);

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
            var appointmentS = new AppointmentServices();
            var pending = true;

            DateTime today = DateTime.Now;
            today = ChangeTime(today, 7);
            DateTime appointmentDate = today.AddDays(1);

            do
            {
                // If selected date alredy has an appointment it changes to the next one
                if (appointmentS.CountAppointmentsByDate(appointmentDate) > 1)
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
            var centerS = new CenterServices();

            // Define next vaccination center
            var vaccinationCenters = centerS.GetByType(2);
            VaccinationCenter++;
            if (VaccinationCenter > vaccinationCenters.Count)
                VaccinationCenter = 1;
        }

        private string CreateUser()
        {
            var citzensS = new CitizenServices();

            // Pending -> input data validation for format
            // var tmpInstitution = (txt_TypeDoc.SelectedValue != "") ? txt_TypeDoc.SelectedValue : null;
            var tmpCitizen = new Citizen(txt_DUI.Text, txt_Name.Text, txt_Address.Text,
                txt_Tel.Text, txt_Email.Text, 18, 1);

            // Create diseases list based on selections
            var chronicDiseaseS = new ChronicDiseaseServices();
            var diseases = chronicDiseaseS.GetAll();

            List<CitizenxchronicDisease> tmpCxD = new List<CitizenxchronicDisease>();
            var selectedDiseases = clb_CD.CheckedItems;

            foreach (var item in selectedDiseases)
            {
                var tmpItem = (ChronicDisease)item;
                // MessageBox.Show($"I: {tmpItem.Id} Item: {tmpItem.ChName}");
                tmpCxD.Add(new CitizenxchronicDisease(tmpCitizen.Dui, tmpItem.Id));
            }

            if (citzensS.ValidateCitizen(tmpCitizen))
            {
                if (citzensS.ValidateElegibleCitizen(tmpCitizen, tmpCxD))
                {
                    citzensS.Create(tmpCitizen);
                    citzensS.SaveCitizenDiseases(tmpCxD);
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
            var institutionS = new InstitutionServices();
            var institutions = institutionS.GetAll();

            txt_TypeDoc.DataSource = institutions;
            txt_TypeDoc.ValueMember = "Id";
            txt_TypeDoc.DisplayMember = "IName";
        }

        private void LoadDiseases()
        {
            var chronicDiseaseS = new ChronicDiseaseServices();
            var diseases = chronicDiseaseS.GetAll();

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
            // CreateUserAppointment();
            CreateUserAppointment();
        }
    }
}

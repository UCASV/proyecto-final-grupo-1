using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_POO.ProjectPOOContext;
using Project_POO.Services;
using Project_POO.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Project_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // get DateTime
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(7);
            // Console.WriteLine("days from today: {0:dddd}", answer);

            /*
            using (var db = new GestorVaccinationContext())
            {
                var diseases = db.ChronicDiseases.ToList();

                diseases.ForEach(x => Console.WriteLine(x.ChName));
            }
            */

            // var tmpDUI = AddCitizen();
            // Console.WriteLine(tmpDUI);
            // AddAppointment();
            // AddAxE();

            // getCitizen();
            getAppointments();
        }

        public void AddAppointment()
        {
            // Start process to add an appointment

            // Calls to add user first
            // var tmpDUI = AddCitizen();
            var tmpDUI = "12345678-9";
            var AppointmentsS = new AppointmentServices();

            // Get DateTime
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(7);

            try
            {
                var TmpAppointment = new Appointment(tmpDUI, 8, 1, 1, answer, 2);
                AppointmentsS.Create(TmpAppointment);

                Console.WriteLine("Cita agregada con exito");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public string AddCitizen()
        {
            try
            {
                // var usersdb = db.Citizens.ToList();
                var tmpDUI = "12345678-6";
                // create citizen
                var tmpCitizen = new Citizen(tmpDUI, "Usuario de prueba 4", "Su casita linda y bella", "2234-4532",
                    "userPrueba4@gmail.com", 65, 1);

                // create diseases list
                List<CitizenxchronicDisease> tmpCxD = new List<CitizenxchronicDisease>();
                var tmpCxC1 = new CitizenxchronicDisease(tmpCitizen.Dui, 3);
                var tmpCxC2 = new CitizenxchronicDisease(tmpCitizen.Dui, 6);
                tmpCxD.Add(tmpCxC1);
                tmpCxD.Add(tmpCxC2);

                var citzensS = new CitizenServices();
                // var tmpCitizen = citzensS.GetCitizen(tmpDUI);

                if (citzensS.ValidateCitizen(tmpCitizen))
                {
                    if (citzensS.ValidateElegibleCitizen(tmpCitizen, tmpCxD))
                    {
                        citzensS.Create(tmpCitizen);
                        citzensS.SaveCitizenDiseases(tmpCxD);
                        Console.WriteLine("User successfully created");
                        return tmpDUI;
                    }
                    else
                    {
                        // Not elegible user
                        Console.WriteLine("Not valid information");
                        return "error";
                    }
                }
                else
                {
                    // Not valid information
                    Console.WriteLine("Not valid information");
                    return "error";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void getCitizen()
        {
            var tmpDUI = "12345678-6";

            try
            {
                var citzensS = new CitizenServices();
                var tmpCitizen = citzensS.GetCitizen(tmpDUI);

                Console.WriteLine($"Citizen name: {tmpCitizen.CName}");

                foreach (var disease in tmpCitizen.CitizenxchronicDiseases)
                {
                    Console.WriteLine($"Disease id: {disease.IdChronicDisease}");
                    Console.WriteLine($"Disease name: {disease.IdChronicDiseaseNavigation.ChName}"); // Must use ...Navigation to acces other table prop
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void getAppointments()
        {
            try
            {
                var AppointmentsS = new AppointmentServices();
                var appointments = AppointmentsS.GetAll();

                var MapedAppointments = new List<AppointmentVm>();

                // Mapping example
                appointments.ForEach(x => MapedAppointments.Add(ProjectMapper.MapAppointmentToVm(x)));

                Dgv1.DataSource = MapedAppointments;

                foreach (var item in MapedAppointments)
                {
                    Console.WriteLine($"Cita {item.Id}, estado: {item.Status}, tipo {item.TypeAppointment}, centro: {item.VaccinationCenter}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void AddAxE()
        {
            try
            {
                var AppointmentsS = new AppointmentServices();

                var TmpAxE = new AppointmentxsecondaryEffect(2, 1, 20);
                AppointmentsS.SaveSecondaryEffects(TmpAxE);

                Console.WriteLine("Secondary effect successfully added");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}

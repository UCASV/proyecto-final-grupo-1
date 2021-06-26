using LiveCharts;
using LiveCharts.Wpf;
using Project_POO.ProjectPOOContext;
using Project_POO.Services;
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
    public partial class FrmStatistics : Form
    {
        private Employee employeeObj;

        private AppointmentServices _appointmentS;
        private SecondaryEffectServices _secondaryEffectS;

        public FrmStatistics(Employee employee)
        {
            InitializeComponent();
            employeeObj = employee;
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            _appointmentS = new AppointmentServices();
            _secondaryEffectS = new SecondaryEffectServices();

            // Set user info
            lbl_AdminName.Text = employeeObj.EName;

            GetTotals();
            GenerateEfficiencyChart();
            ConstructEfectsChart();
        }

        private void GenerateEfficiencyChart()
        {
            var completedAppointments = _appointmentS.GetCompleted();

            int[] duration = { 0, 0, 0, 0 };
            ChartValues<int> chartVal = new ChartValues<int>();

            completedAppointments.ForEach(x =>
            {
                // Auxiliar timespans
                TimeSpan start = DateTime.Now.TimeOfDay;
                TimeSpan final = DateTime.Now.TimeOfDay;

                // calculate duration
                if (x.StartTime.HasValue)
                {
                    start = x.StartTime.Value;
                }
                if (x.FinalTime.HasValue)
                {
                    final = x.FinalTime.Value;
                }

                TimeSpan tmpDuration = final.Subtract(start);

                int minutes = (int)tmpDuration.TotalMinutes;
                if (minutes < 15)
                    duration[0] = duration[0] + 1;
                else if (minutes >= 15 && minutes < 30)
                    duration[1] = duration[1] + 1;
                else if (minutes >= 30 && minutes < 60)
                    duration[2] = duration[2] + 1;
                else
                    duration[3] = duration[3] + 1;
            });

            chartVal.AddRange(duration);

            cartesianChart_Efficency.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Eficiencia",
                    Name = "Eficiencia",
                    Values = chartVal
                }
            };

            cartesianChart_Efficency.AxisX.Add(new Axis
            {
                Title = "Minutos",
                Labels = new[] { "15-", "15-30", "30-60", "60+" },
                Separator = new Separator { Step = 1 }
            });

            cartesianChart_Efficency.AxisY.Add(new Axis
            {
                Title = "Cantidad",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void ConstructEfectsChart()
        {
            var secondaryEfList = _secondaryEffectS.GetAll();

            List<string> effects = new List<string>();
            List<int> appearence = new List<int>();
            ChartValues<int> chartVal = new ChartValues<int>();

            secondaryEfList.ForEach(x =>
            {
                effects.Add(x.SeName);
                appearence.Add(_secondaryEffectS.CountSecondaryEffectAppearence(x));
            });

            chartVal.AddRange(appearence);

            // Init chart

            cartesianChart_Effects.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Recurrencia",
                    Name = "Recurrencia",
                    Values = chartVal
                }
            };

            cartesianChart_Effects.AxisX.Add(new Axis
            {
                Title = "Efectos secundarios",
                Labels = effects.ToArray(),
                Separator = new Separator { Step = 5 }
            });

            cartesianChart_Effects.AxisY.Add(new Axis
            {
                Title = "Cantidad",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void GetTotals()
        {
            int total1 = _appointmentS.TotalVaccinatedUsers(1);
            int total2 = _appointmentS.TotalVaccinatedUsers(2);
            int total3 = total1 + total2;

            lbl_NumVaccinated1.Text = $"{total1}";
            lbl_NumVaccinated2.Text = $"{total2}";
            lbl_NumVaccinatedTotal.Text = $"{total3}";
        }

        private void lbl_Title_Vaccinated1_Click(object sender, EventArgs e)
        {

        }

        private void tlp_Stats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

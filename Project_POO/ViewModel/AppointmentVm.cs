using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.ViewModel
{
    public class AppointmentVm
    {
        public int Id { get; set; }
        public DateTime ADatetime { get; set; }
        public string Status { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? FinalTime { get; set; }
        public string TypeAppointment { get; set; }
        public string CitizenName { get; set; }
        // public string EmployeeName { get; set; }
        // public string Cabin { get; set; }
        public string VaccinationCenter { get; set; }
    }
}

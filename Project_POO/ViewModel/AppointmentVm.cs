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
        public string Nombre_ciudadano { get; set; }
        public string Tipo_cita { get; set; }
        public string Centro_vacunacion { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string? Hora_asistencia { get; set; }
        public string? Hora_vacunacion { get; set; }
        public string Estado { get; set; }
       
        // public string EmployeeName { get; set; }
        // public string Cabin { get; set; }
    }
}

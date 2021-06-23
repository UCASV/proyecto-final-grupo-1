using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class TypeAppointment
    {
        public TypeAppointment()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string TaName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Center
    {
        public int Id { get; set; }
        public string CenterAddress { get; set; }
        public string Tel { get; set; }
        public string CenterEmail { get; set; }
        public int IdCenterType { get; set; }
        public int IdEmployeeInCharge { get; set; }

        public virtual TypeCenter IdCenterTypeNavigation { get; set; }
        public virtual Employee IdEmployeeInChargeNavigation { get; set; }
        public virtual ICollection<Appointment> AppointmentIdCabinNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentIdVaccinationCenterNavigations { get; set; }
        public virtual ICollection<Employeexcenter> Employeexcenters { get; set; }

        public Center()
        {
            AppointmentIdCabinNavigations = new HashSet<Appointment>();
            AppointmentIdVaccinationCenterNavigations = new HashSet<Appointment>();
            Employeexcenters = new HashSet<Employeexcenter>();
        }
    }
}

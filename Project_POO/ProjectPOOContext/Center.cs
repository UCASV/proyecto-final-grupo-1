using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Center
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

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

        public Center(string CenterAddress, string Tel, string CenterEmail, int IdCenterType, int IdEmployeeInCharge)
        {
            this.CenterAddress = CenterAddress;
            this.Tel = Tel;
            this.CenterEmail = CenterEmail;
            this.IdCenterType = IdCenterType;
            this.IdEmployeeInCharge = IdEmployeeInCharge;
        }
    }
}

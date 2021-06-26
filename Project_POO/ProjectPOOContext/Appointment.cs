using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime ADatetime { get; set; }
        public bool AStatus { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? FinalTime { get; set; }
        public int IdTypeAppointment { get; set; }
        public string IdCitizen { get; set; }
        public int IdEmployee { get; set; }
        public int IdCabin { get; set; }
        public int IdVaccinationCenter { get; set; }

        public virtual Center IdCabinNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual TypeAppointment IdTypeAppointmentNavigation { get; set; }
        public virtual Center IdVaccinationCenterNavigation { get; set; }
        public virtual ICollection<AppointmentxsecondaryEffect> AppointmentxsecondaryEffects { get; set; }

        public Appointment()
        {
            AppointmentxsecondaryEffects = new HashSet<AppointmentxsecondaryEffect>();
        }

        public Appointment(string idCitizen, int idEmployee, int idCabin, int idVaccinationCenter,
            DateTime datetime, int idTypeAppointment) : base()
        {
            IdCitizen = idCitizen;
            IdEmployee = idEmployee;
            IdCabin = idCabin;
            IdVaccinationCenter = idVaccinationCenter;
            ADatetime = datetime;
            IdTypeAppointment = idTypeAppointment;
        }
    }
}

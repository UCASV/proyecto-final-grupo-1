using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class AppointmentxsecondaryEffect
    {
        public int IdAppointment { get; set; }
        public int IdSecondaryEffect { get; set; }
        public int Duration { get; set; }

        public virtual Appointment IdAppointmentNavigation { get; set; }
        public virtual SecondaryEffect IdSecondaryEffectNavigation { get; set; }

        public AppointmentxsecondaryEffect(int idAppointment, int idSecondaryEffect, int duration)
        {
            IdAppointment = idAppointment;
            IdSecondaryEffect = idSecondaryEffect;
            Duration = duration;
        }
    }
}

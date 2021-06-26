using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class SecondaryEffect
    {
        public SecondaryEffect()
        {
            AppointmentxsecondaryEffects = new HashSet<AppointmentxsecondaryEffect>();
        }

        public int Id { get; set; }
        public string SeName { get; set; }

        public virtual ICollection<AppointmentxsecondaryEffect> AppointmentxsecondaryEffects { get; set; }
    }
}

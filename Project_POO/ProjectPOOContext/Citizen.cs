using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Citizen
    {
        public string Dui { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }
        public int? IdInstitution { get; set; }

        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CitizenxchronicDisease> CitizenxchronicDiseases { get; set; }

        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            CitizenxchronicDiseases = new HashSet<CitizenxchronicDisease>();
        }

        public Citizen(string dui, string name, string address, string tel, string email, byte age, int? idInstitucion) : base()
        {
            Dui = dui;
            CName = name;
            CAddress = address;
            Tel = tel;
            Email = email;
            Age = age;
            IdInstitution = idInstitucion;
        }
    }
}

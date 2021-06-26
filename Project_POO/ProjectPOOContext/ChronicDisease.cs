using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class ChronicDisease
    {
        public int Id { get; set; }
        public string ChName { get; set; }

        public virtual ICollection<CitizenxchronicDisease> CitizenxchronicDiseases { get; set; }

        public ChronicDisease()
        {
            CitizenxchronicDiseases = new HashSet<CitizenxchronicDisease>();
        }

        public ChronicDisease(int id, string name) : base()
        {
            Id = id;
            ChName = name;
        }
    }
}

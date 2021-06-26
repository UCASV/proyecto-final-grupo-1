using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class CitizenxchronicDisease
    {
        public string IdCitizen { get; set; }
        public int IdChronicDisease { get; set; }

        public virtual ChronicDisease IdChronicDiseaseNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }

        public CitizenxchronicDisease(string idCitizen, int idChronicDisease)
        {
            IdCitizen = idCitizen;
            IdChronicDisease = idChronicDisease;
        }
    }
}

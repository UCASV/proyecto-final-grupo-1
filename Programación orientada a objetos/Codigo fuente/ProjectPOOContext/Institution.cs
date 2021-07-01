using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Institution
    {
        public int Id { get; set; }
        public string IName { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }

        public Institution()
        {
            Citizens = new HashSet<Citizen>();
        }

        public Institution(int id, string name) : base()
        {
            Id = id;
            IName = name;
        }
    }
}

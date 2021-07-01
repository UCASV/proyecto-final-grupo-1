using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class TypeCenter
    {
        public TypeCenter()
        {
            Centers = new HashSet<Center>();
        }

        public int Id { get; set; }
        public string TcName { get; set; }

        public virtual ICollection<Center> Centers { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Employeexcenter
    {
        public Employeexcenter(int idEmployee, int idCenter)
        {
            IdEmployee = idEmployee;
            IdCenter = idCenter;
            EXcDatetime = DateTime.Now;
        }

        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdCenter { get; set; }
        public DateTime EXcDatetime { get; set; }

        public virtual Center IdCenterNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}

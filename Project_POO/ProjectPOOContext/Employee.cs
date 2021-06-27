using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.ProjectPOOContext
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string EAddress { get; set; }
        public int IdTypeEmployee { get; set; }

        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<Employeexcenter> Employeexcenters { get; set; }

        public Employee()
        {
            Appointments = new HashSet<Appointment>();
            Centers = new HashSet<Center>();
            Employeexcenters = new HashSet<Employeexcenter>();
        }

        public Employee(string EName, string Email, string Pass, string EAddress, int IdTypeEmployee)
        {
            this.EName = EName;
            this.Email = Email;
            this.Pass = Pass;
            this.EAddress = EAddress;
            this.IdTypeEmployee = IdTypeEmployee;
        }
    }
}

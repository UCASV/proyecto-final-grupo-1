using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class EmployeeServices : IRepository<Employee>
    {
        private GestorVaccinationContext _context;

        public EmployeeServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Employee item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Employee item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        // Extra

        public Employee GetEmployee(int id)
        {
            return _context.Employees
                .Where(x => x.Id.Equals(id))
                .SingleOrDefault();
        }
    }
}

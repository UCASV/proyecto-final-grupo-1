using Microsoft.EntityFrameworkCore;
using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class EmployeexcenterServices : IRepository<Employeexcenter>
    {
        private GestorVaccinationContext _context;

        public EmployeexcenterServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Employeexcenter item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<Employeexcenter> GetAll()
        {
            return _context.Employeexcenters
                .Include(x => x.IdEmployeeNavigation)
                .Include(x => x.IdCenterNavigation)
                .ToList();
        }

        public void Update(Employeexcenter item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Employeexcenter item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }
    }
}

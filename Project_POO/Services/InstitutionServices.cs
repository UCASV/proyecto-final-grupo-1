using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class InstitutionServices : IRepository<Institution>
    {
        private GestorVaccinationContext _context;

        public InstitutionServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Institution item)
        {
           
        }

        public List<Institution> GetAll()
        {
            return _context.Institutions.ToList();
        }

        public void Update(Institution item)
        {
           
        }
        public void Delete(Institution item)
        {
            
        }
    }
}

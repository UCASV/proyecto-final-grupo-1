using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class ChronicDiseaseServices : IRepository<ChronicDisease>
    {
        private GestorVaccinationContext _context;

        public ChronicDiseaseServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(ChronicDisease item)
        {
            throw new NotImplementedException();
        }

        public List<ChronicDisease> GetAll()
        {
            return _context.ChronicDiseases.ToList();
        }

        public void Update(ChronicDisease item)
        {
            throw new NotImplementedException();
        }

        public void Delete(ChronicDisease item)
        {
            throw new NotImplementedException();
        }
    }
}

using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class CenterServices : IRepository<Center>
    {
        private GestorVaccinationContext _context;

        public CenterServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Center item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<Center> GetAll()
        {
            return _context.Centers.ToList();
        }

        public void Update(Center item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Center item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        // Extra

        public List<Center> GetByType(int type)
        {
            return _context.Centers
                .Where(x => x.IdCenterType.Equals(type))
                .ToList();
        }

        public Center GetCenter(int centerId)
        {
            return _context.Centers
                .Where(x => x.Id.Equals(centerId))
                .SingleOrDefault();
        }
    }
}

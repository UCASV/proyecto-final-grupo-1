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
    class SecondaryEffectServices : IRepository<SecondaryEffect>
    {
        private GestorVaccinationContext _context;

        public SecondaryEffectServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(SecondaryEffect item)
        {
            throw new NotImplementedException();
        }

        public List<SecondaryEffect> GetAll()
        {
            return _context.SecondaryEffects.ToList();
        }

        public void Update(SecondaryEffect item)
        {
            throw new NotImplementedException();
        }

        public void Delete(SecondaryEffect item)
        {
            throw new NotImplementedException();
        }

        // Extra functions for stadistics module

        public int CountSecondaryEffectAppearence(SecondaryEffect secondaryEffect)
        {
            return _context.AppointmentxsecondaryEffects
                .Include(x => x.IdSecondaryEffectNavigation)
                .Where(x => x.IdSecondaryEffectNavigation.Id.Equals(secondaryEffect.Id))
                .Count();
        }
    }
}

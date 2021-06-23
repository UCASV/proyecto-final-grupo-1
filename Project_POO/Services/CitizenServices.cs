using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Services
{
    class CitizenServices : IRepository<Citizen>
    {
        private GestorVaccinationContext _context;

        public CitizenServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Citizen item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<Citizen> GetAll()
        {
            return _context.Citizens.ToList();
        }

        public void Update(Citizen item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Citizen item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        // Extra services

        public Citizen GetCitizen(string tmpDUI)
        {
            var tmpCitizen = _context.Citizens
                .Include(x => x.CitizenxchronicDiseases)
                .ThenInclude(d => d.IdChronicDiseaseNavigation) // Must use ...Navigation to acces other table prop
                .Where(x => x.Dui.Equals(tmpDUI))
                .SingleOrDefault();

            return tmpCitizen;
        }

        public bool ValidateCitizen(Citizen item)
        {
            // Must complete validating function
            if (item.CName.Length > 5 && item.Age >= 0)
                return true;
            else
                return false;
        }

        public bool ValidateElegibleCitizen(Citizen item, List<CitizenxchronicDisease> TmpCxD)
        {
            // Must complete validating function
            if (item.Age >= 60 || item.IdInstitution is not null)
                return true;
            else
                return false;
        }

        public void SaveCitizenDiseases(List<CitizenxchronicDisease> tmpCxD)
        {
            // Save diseases
            if (tmpCxD.Count > 0)
            {
                _context.CitizenxchronicDiseases.AddRange(tmpCxD);
                _context.SaveChanges();
            }
        }
    }
}

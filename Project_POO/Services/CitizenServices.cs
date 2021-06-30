using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Project_POO.Tools;

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

        public bool VerifyICitizenExists(string tmpDui)
        {
            var citizen = _context.Citizens
                .Where(x => x.Dui.Equals(tmpDui))
                .Count();

            if (citizen == 0)
                return false;
            else
                return true;
        }

        public Citizen GetCitizen(string tmpDUI)
        {
            var tmpCitizen = _context.Citizens
                .Include(x => x.CitizenxchronicDiseases)
                .ThenInclude(d => d.IdChronicDiseaseNavigation) 
                .Where(x => x.Dui.Equals(tmpDUI))
                .SingleOrDefault();

            return tmpCitizen;
        }

        public List<CitizenxchronicDisease> GetDiseasesByUser(string citizenDui)
        {
            return _context.CitizenxchronicDiseases
                .Include(x => x.IdCitizenNavigation)
                .Include(x => x.IdChronicDiseaseNavigation)
                .Where(x => x.IdCitizen.Equals(citizenDui))
                .ToList();
        }

        public Response ValidateCitizen(Citizen item)
        {
            var telExp = "^[2-9]{1}[0-9]{3}-[0-9]{4}$";
            var emailExp = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var duiExp = "^[0-9]{8}-[0-9]{1}$";

            // Validating data function
            if (item.Dui.Length == 10 && item.CName.Length > 5 && item.Age > 0 
                && item.CAddress.Length > 5 && item.Email.Length > 5 && item.Tel.Length == 9)
            {
                if (Regex.IsMatch(item.Tel, telExp))
                {
                    if (Regex.IsMatch(item.Email, emailExp))
                    {
                        if (Regex.IsMatch(item.Dui, duiExp))
                            return new Response("Informacion valida", true);
                        else
                            return new Response("Formato de DUI no valido", false);
                    }
                    else
                        return new Response("Formato de correo electrónico no valido", false);
                }
                else
                    return new Response("Formato de teléfono no valido", false);
            }
            else
                return new Response("Longuitud de caracteres en un campo de texto (minimo 6 para los campos abiertos) o edad no valida", false);
        }

        public bool ValidateElegibleCitizen(Citizen item, List<CitizenxchronicDisease> TmpCxD)
        {
            // Validating if elegible
            if (item.Age >= 18)
            {
                if (item.Age >= 60 || item.IdInstitution is not null || TmpCxD.Count > 0)
                    return true;
                else
                    return false;
            }
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

        public bool VerifyEmail(string email)
        {
            var count = _context.Citizens
                .Where(x => x.Email.Equals(email))
                .Count();

            if (count == 0)
                return false;
            else
                return true;
        }
    }
}

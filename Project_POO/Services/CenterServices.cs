using Project_POO.ProjectPOOContext;
using Project_POO.Repository;
using Project_POO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public Response ValidateCenter(Center item)
        {
            var telExp = "^[2-9]{1}[0-9]{3}-[0-9]{4}$";
            var emailExp = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            // Validating data function
            if (item.CenterAddress.Length > 5 && item.Tel.Length == 9 && item.CenterEmail.Length > 5 )
            {
                if (Regex.IsMatch(item.Tel, telExp))
                {
                    if (Regex.IsMatch(item.CenterEmail, emailExp))
                        return new Response("Información correcta", true);
                    else
                        return new Response("Formato de correo electrónico no valido", false);
                }
                else
                    return new Response("Formato de teléfono no valido", false);
            }
            else
                return new Response("Verifica que los campos tengan la cantidad necesaria de caracteres (minimo 5 para los campos abiertos)", false);
        }
    }
}

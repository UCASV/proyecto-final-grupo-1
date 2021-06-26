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
    class AppointmentServices : IRepository<Appointment>
    {
        private GestorVaccinationContext _context;

        public AppointmentServices()
        {
            _context = new GestorVaccinationContext();
        }

        public void Create(Appointment item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
        public List<Appointment> GetAll()
        {
            return _context.Appointments
                .Include(x => x.IdCitizenNavigation)
                .Include(x => x.IdTypeAppointmentNavigation)
                .Include(x => x.IdVaccinationCenterNavigation)
                .ToList();
        }

        public void Update(Appointment item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }

        public void Delete(Appointment item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        // Extra services

        public Appointment GetAppointment(int id)
        {
            return _context.Appointments
                .Include(x => x.IdCitizenNavigation)
                    .ThenInclude(x => x.IdInstitutionNavigation)
                .Include(x => x.IdEmployeeNavigation)
                .Include(x => x.IdCabinNavigation)
                .Include(x => x.IdTypeAppointmentNavigation)
                .Include(x => x.IdVaccinationCenterNavigation)
                .Where(x => x.Id.Equals(id))
                .SingleOrDefault();
        }
        public List<AppointmentxsecondaryEffect> GetAppointmentEffects(int id)
        {
            return _context.AppointmentxsecondaryEffects
                .Include(x => x.IdSecondaryEffectNavigation)
                .Where(x => x.IdAppointment.Equals(id))
                .ToList();
        }

        public int CountAppointmentsByDate(DateTime datetime)
        {
            return _context.Appointments
                .Where(x => x.ADatetime.Equals(datetime))
                .Count();
        }

        public void SaveSecondaryEffects(AppointmentxsecondaryEffect tmpAxE)
        {
            _context.AppointmentxsecondaryEffects.Add(tmpAxE);
            _context.SaveChanges();
        }

        // Extra functions for stadistics module

        public int TotalVaccinatedUsers(int type = 1)
        {
            return _context.Appointments
                .Where(x => x.IdTypeAppointment.Equals(type) && x.AStatus.Equals(true))
                .Count();
        }

        public List<Appointment> GetCompleted()
        {
            return _context.Appointments
                .Include(x => x.IdCitizenNavigation)
                .Include(x => x.IdTypeAppointmentNavigation)
                .Include(x => x.IdVaccinationCenterNavigation)
                .Where(x => x.AStatus.Equals(true))
                .ToList();
        }
    }
}

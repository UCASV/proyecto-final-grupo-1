using Project_POO.ProjectPOOContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.ViewModel
{
    public static class ProjectMapper
    {
        public static AppointmentVm MapAppointmentToVm(Appointment a)
        {
            return new AppointmentVm
            {
                Id = a.Id,
                ADatetime = a.ADatetime,
                Status = (a.AStatus is false) ? "Pendiente" : "Finalizada",
                StartTime = a.StartTime,
                FinalTime = a.FinalTime,
                TypeAppointment = a.IdTypeAppointmentNavigation.TaName,
                CitizenName = a.IdCitizenNavigation.CName,
                VaccinationCenter = a.IdVaccinationCenterNavigation.CenterAddress
            };
        }

        public static CitizenVm MapCitizenToVm(Citizen c)
        {
            return new CitizenVm
            {
                Dui = c.Dui,
                CName = c.CName,
                CAddress = c.CAddress,
                Tel = c.Tel,
                Email = c.Email,
                Age = c.Age,
                Institution = (c.IdInstitutionNavigation is null) ? "No disponible" : c.IdInstitutionNavigation.IName
            };
        }

        public static CitizenxchronicDiseaseVm MapCitizenxchronicDiseaseToVm(CitizenxchronicDisease c)
        {
            return new CitizenxchronicDiseaseVm
            {
                ChronicDiseaseName = c.IdChronicDiseaseNavigation.ChName
            };
        }

        public static AppointmentxsecondaryEffectVm MapAppointmentxsecondaryEffectToVm(AppointmentxsecondaryEffect a)
        {
            return new AppointmentxsecondaryEffectVm
            {
                SecondaryEffect = a.IdSecondaryEffectNavigation.SeName,
                Duration = a.Duration
            };
        }
    }
}

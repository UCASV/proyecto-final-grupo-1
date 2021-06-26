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
                Nombre_ciudadano = a.IdCitizenNavigation.CName,
                Tipo_cita = a.IdTypeAppointmentNavigation.TaName,
                Centro_vacunacion = a.IdVaccinationCenterNavigation.CenterAddress,
                Fecha_Hora = a.ADatetime,
                Hora_asistencia = String.Format("{0:hh\\:mm\\:ss}", a.StartTime),
                Hora_vacunacion = String.Format("{0:hh\\:mm\\:ss}", a.FinalTime),
                Estado = (a.AStatus is false) ? "Pendiente" : "Finalizada"
            };
        }

        public static CitizenVm MapCitizenToVm(Citizen c)
        {
            return new CitizenVm
            {
                DUI = c.Dui,
                Nombre = c.CName,
                Edad = c.Age,
                Direccion = c.CAddress,
                Telelefono = c.Tel,
                Correo = c.Email,
                Institucion = (c.IdInstitutionNavigation is null) ? "No disponible" : c.IdInstitutionNavigation.IName
            };
        }

        public static CitizenxchronicDiseaseVm MapCitizenxchronicDiseaseToVm(CitizenxchronicDisease c)
        {
            return new CitizenxchronicDiseaseVm
            {
                Enfermedad_cronica = c.IdChronicDiseaseNavigation.ChName
            };
        }

        public static AppointmentxsecondaryEffectVm MapAppointmentxsecondaryEffectToVm(AppointmentxsecondaryEffect a)
        {
            return new AppointmentxsecondaryEffectVm
            {
                Efecto_secundario = a.IdSecondaryEffectNavigation.SeName,
                Duracion = a.Duration
            };
        }
    }
}

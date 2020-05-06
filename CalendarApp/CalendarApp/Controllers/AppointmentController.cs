using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Controllers
{
    public static class AppointmentController
    {
        public static (bool, string) CreateAppointment(Appointment appointment)
        {
            bool couldTheAppointmentBeCreated = Constants.TheAppointmentCouldBeCreated;
            bool hasTitle = !String.IsNullOrWhiteSpace(appointment.Title);
            bool hasDescription = !String.IsNullOrWhiteSpace(appointment.Description);
            bool endDateIsLaterThanStartDate = appointment.StartDate < appointment.EndDate;
            string feedbackText = "Successfully created appointment";
            if (!hasTitle || !hasDescription || !endDateIsLaterThanStartDate)
            {
                feedbackText = "Error" + Environment.NewLine;
                couldTheAppointmentBeCreated = !Constants.TheAppointmentCouldBeCreated;
                if (!hasTitle)
                {
                    feedbackText += "The appointment must have a title" + Environment.NewLine;

                }
                if (!hasDescription)
                {
                    feedbackText += "The appointment must have a description" + Environment.NewLine;

                }
                if (!endDateIsLaterThanStartDate)
                {
                    feedbackText += "The end date must be later than the start date";
                }
            }
            else
            {
                try
                {
                    DatabaseHelper.SaveAppointment(appointment);
                }
                catch
                {
                    couldTheAppointmentBeCreated = !Constants.TheAppointmentCouldBeCreated;
                    feedbackText = "Error, the appointment could not be created";
                }
            }
            return (couldTheAppointmentBeCreated, feedbackText);
        }

        public static List<Appointment> GetAppointmentsInMonth(DateTime date)
        {
            return DatabaseHelper.GetAppointmentsInMonth(date);
        }

        public static bool IsAppointmentInThisTimePeriod(Appointment appointment, DateTime timePeriod, string selectedCalendarView)
        {
            bool IsAppointmentInThisTimePeriod;
            if (selectedCalendarView == Constants.MonthOption)
            {
                IsAppointmentInThisTimePeriod = appointment.StartDate.Date <= timePeriod && timePeriod <= appointment.EndDate.Date;
            }
            else
            {
                DateTime previousHour = appointment.StartDate.AddHours(Constants.PreviousTimeInterval);
                IsAppointmentInThisTimePeriod = previousHour < timePeriod && timePeriod < appointment.EndDate;
            }
            return IsAppointmentInThisTimePeriod;
        }


        public static List<Appointment> GetAppointmentsInThisTimePeriod(List<Appointment> appointments, DateTime timePeriod, string selectedCalendarView)
        {
            IEnumerable<Appointment> appointmentsObtained = from appointment in appointments
                                                where IsAppointmentInThisTimePeriod(appointment, timePeriod, selectedCalendarView)
                                                     orderby appointment.StartDate
                                                     select appointment;
            List<Appointment> appointmentsInTimePeriod = new List<Appointment>(appointmentsObtained);
            return appointmentsInTimePeriod;
        }
    }
}

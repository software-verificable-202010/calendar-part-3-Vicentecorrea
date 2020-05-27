using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace CalendarApp.Controllers
{
    public class AppointmentController
    {
        private static List<Appointment> appointments;

        /// <summary>Public property for accessing the appointments.</summary>
        public static List<Appointment> Appointments
        {
            get
            {
                return appointments;
            }
            set
            {
                appointments = value;
            }
        }
        
        public static void SaveAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
            SerializeAppointments();
        }

        private static void SerializeAppointments()
        {
            Stream stream = File.Open(Constants.PathToAppointmentsSerializationFile, FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, Appointments);
            stream.Close();
        }

        public static void LoadAppointments()
        {
            Stream stream = File.Open(Constants.PathToAppointmentsSerializationFile, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Appointments = (List<Appointment>)binaryFormatter.Deserialize(stream);
            stream.Close();
        }

        public static List<Appointment> GetAppointmentsInMonth(DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, Constants.DefaultFirstDay);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(Constants.NextTimeInterval);
            IEnumerable<Appointment> appointments = from appointment in Appointments
                                                    where appointment.EndDate >= firstDayOfMonth && appointment.StartDate < firstDayOfNextMonth
                                                    select appointment;
            List<Appointment> appointmentsInMonth = new List<Appointment>(appointments);
            return appointmentsInMonth;
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

        //public static List<Appointment> GetAppointmentsInThisDay(Date)
    }
}

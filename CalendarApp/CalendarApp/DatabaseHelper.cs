using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CalendarApp.Models;
using System.Data.SqlClient;

namespace CalendarApp
{
    public static class DatabaseHelper
    {
        public static string GetConnectionValue(string databaseName)
        {
            return  ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
        }

        public static void SaveAppointment(Appointment appointment)
        {
            SqlConnection connection = new SqlConnection(GetConnectionValue(Constants.DatabaseName));
            connection.Open();
            string query = "insert into Appointment (Title, Description, StartDate, EndDate) values (@Title, @Description, @StartDate, @EndDate)";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Title", appointment.Title);
            sqlCommand.Parameters.AddWithValue("@Description", appointment.Description);
            sqlCommand.Parameters.AddWithValue("@StartDate", appointment.StartDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", appointment.EndDate);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Appointment> GetAppointmentsInMonth(DateTime date)
        {
            SqlConnection connection = new SqlConnection(GetConnectionValue(Constants.DatabaseName));
            connection.Open();
            string query = "select * from appointment where EndDate >= @FirstDayOfMonth and StartDate < @FirstDayOfNextMonth";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, Constants.DefaultFirstDay);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(Constants.NextTimeInterval);
            sqlCommand.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth);
            sqlCommand.Parameters.AddWithValue("@FirstDayOfNextMonth", firstDayOfNextMonth);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Appointment> appointmentsInMonth = new List<Appointment>();
            while (sqlDataReader.Read())
            {
                string title = sqlDataReader.GetValue(1).ToString();
                string description = sqlDataReader.GetValue(2).ToString();
                DateTime startDate = (DateTime)sqlDataReader.GetValue(3);
                DateTime endDate = (DateTime)sqlDataReader.GetValue(4);
                Appointment appointment = new Appointment(title, description, startDate, endDate);
                //appointmentInMonth.Id = (int)sqlDataReader.GetValue(0);
                appointmentsInMonth.Add(appointment);
            }
            connection.Close();
            return appointmentsInMonth;
        }
    }
}

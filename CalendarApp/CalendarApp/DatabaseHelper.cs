using System;
using System.Collections.Generic;
using System.Configuration;
using CalendarApp.Models;
using System.Data.SqlClient;

namespace CalendarApp
{
    public static class DatabaseHelper
    {
        public static string GetConnectionValue(string databaseName)
        {
            return ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
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
            int sqlDataReaderValue = Constants.DefaultInitialIndex;
            while (sqlDataReader.Read())
            {
                sqlDataReaderValue++;
                string title = sqlDataReader.GetValue(sqlDataReaderValue).ToString();
                sqlDataReaderValue++;
                string description = sqlDataReader.GetValue(sqlDataReaderValue).ToString();
                sqlDataReaderValue++;
                DateTime startDate = (DateTime)sqlDataReader.GetValue(sqlDataReaderValue);
                sqlDataReaderValue++;
                DateTime endDate = (DateTime)sqlDataReader.GetValue(sqlDataReaderValue);
                Appointment appointment = new Appointment(title, description, startDate, endDate);
                appointmentsInMonth.Add(appointment);
                sqlDataReaderValue = Constants.DefaultInitialIndex;
            }
            connection.Close();
            return appointmentsInMonth;
        }
    }
}

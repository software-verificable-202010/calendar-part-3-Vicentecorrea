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

        public static void SaveEvent(Event newEvent)
        {
            SqlConnection connection = new SqlConnection(GetConnectionValue(Constants.DatabaseName));
            connection.Open();
            string query = "insert into Event (Title, Description, StartDate, EndDate) values (@Title, @Description, @StartDate, @EndDate)";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Title", newEvent.Title);
            sqlCommand.Parameters.AddWithValue("@Description", newEvent.Description);
            sqlCommand.Parameters.AddWithValue("@StartDate", newEvent.StartDate);
            sqlCommand.Parameters.AddWithValue("@EndDate", newEvent.EndDate);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static List<Event> GetEventsInMonth(DateTime date)
        {
            SqlConnection connection = new SqlConnection(GetConnectionValue(Constants.DatabaseName));
            connection.Open();
            string query = "select * from Event where EndDate >= @FirstDayOfMonth and StartDate < @FirstDayOfNextMonth";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, Constants.DefaultFirstDay);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(Constants.NextTimeInterval);
            sqlCommand.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth);
            sqlCommand.Parameters.AddWithValue("@FirstDayOfNextMonth", firstDayOfNextMonth);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Event> eventsInMonth = new List<Event>();
            while (sqlDataReader.Read())
            {
                string title = sqlDataReader.GetValue(1).ToString();
                string description = sqlDataReader.GetValue(2).ToString();
                DateTime startDate = (DateTime)sqlDataReader.GetValue(3);
                DateTime endDate = (DateTime)sqlDataReader.GetValue(4);
                Event eventInMonth = new Event(title, description, startDate, endDate);
                //eventInMonth.Id = (int)sqlDataReader.GetValue(0);
                eventsInMonth.Add(eventInMonth);
            }
            connection.Close();
            return eventsInMonth;
        }
    }
}

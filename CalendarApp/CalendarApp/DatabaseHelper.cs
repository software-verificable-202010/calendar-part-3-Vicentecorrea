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
    }
}

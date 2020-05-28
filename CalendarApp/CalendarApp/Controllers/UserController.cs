using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Controllers
{
    class UserController
    {
        private static List<User> users = new List<User>();
        private static string loggedUsername;

        /// <summary>Public property for accessing the users.</summary>
        public static List<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
            }
        }

        /// <summary>Public property for accessing the logged in user.</summary>
        public static string LoggedUsername
        {
            get
            {
                return loggedUsername;
            }
            set
            {
                loggedUsername = value;
            }
        }

        public static void SaveUser(User user)
        {
            Users.Add(user);
            SerializeUsers();
        }

        private static void SerializeUsers()
        {
            Stream stream = File.Open(Constants.PathToUsersSerializationFile, FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, Users);
            stream.Close();
        }

        public static void LoadUsers()
        {
            Stream stream = File.Open(Constants.PathToUsersSerializationFile, FileMode.OpenOrCreate);
            if (stream.Length > Constants.ZeroItemsInList)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Users = (List<User>)binaryFormatter.Deserialize(stream);
            }
            stream.Close();
        }
    }
}

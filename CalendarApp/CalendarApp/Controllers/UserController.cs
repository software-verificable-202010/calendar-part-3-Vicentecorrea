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
    public class UserController
    {
        #region Fields
        static private List<User> users = new List<User>();
        static private string loggedUserName;
        #endregion

        #region Properties
        /// <summary>Public property for accessing the users.</summary>
        static public List<User> Users
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
        static public string LoggedUserName
        {
            get
            {
                return loggedUserName;
            }
            set
            {
                loggedUserName = value;
            }
        }
        #endregion

        #region Methods
        public static void SaveUser(User user)
        {
            Users.Add(user);
            SerializeUsers();
        }

        private static void SerializeUsers()
        {
            Stream stream = null;
            try
            {
                stream = File.Open(Constants.PathToUsersSerializationFile, FileMode.OpenOrCreate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, Users);
            }
            finally
            {
                stream.Close();
            }
        }

        public static void LoadUsers()
        {
            Stream stream = null;
            try
            {
                stream = File.Open(Constants.PathToUsersSerializationFile, FileMode.OpenOrCreate);
                if (stream.Length > Constants.ZeroItemsInList)
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    Users = (List<User>)binaryFormatter.Deserialize(stream);
                }
            }
            finally
            {
                stream.Close();
            }
        }
        #endregion
    }
}

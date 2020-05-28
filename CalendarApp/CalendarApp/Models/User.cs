using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Models
{
    [Serializable]
    public class User
    {
        private string username;

        public User(string username)
        {
            this.username = username;
        }

        /// <summary>Public property for accessing the username field.</summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
    }
}

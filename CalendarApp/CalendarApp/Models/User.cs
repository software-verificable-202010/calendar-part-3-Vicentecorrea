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
        #region Fields
        private string username;
        #endregion

        #region Properties
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
        #endregion

        #region Methods
        public User(string username)
        {
            this.username = username;
        }
        #endregion
    }
}

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
        private string userName;
        #endregion

        #region Properties
        /// <summary>Public property for accessing the userName field.</summary>
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        #endregion

        #region Methods
        public User(string userName)
        {
            this.userName = userName;
        }
        #endregion
    }
}

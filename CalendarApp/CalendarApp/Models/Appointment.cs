using System;
using System.Collections.Generic;

namespace CalendarApp.Models
{
    [Serializable]
    public class Appointment
    {
        #region Fields
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private string ownerUserName;
        private List<string> guestUserNames;
        #endregion

        #region Properties
        /// <summary>Public property for accessing the title field.</summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>Public property for accessing the description field.</summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        /// <summary>Public property for accessing the startDate field.</summary>
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        /// <summary>Public property for accessing the endDate field.</summary>
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        /// <summary>Public property for accessing the owner field.</summary>
        public string OwnerUserName
        {
            get
            {
                return ownerUserName;
            }
            set
            {
                ownerUserName = value;
            }
        }
        /// <summary>Public property for accessing the guests field.</summary>
        public List<string> GuestUserNames
        {
            get
            {
                return guestUserNames;
            }
            set
            {
                guestUserNames = value;
            }
        }
        #endregion

        #region Methods
        public Appointment(string title, string description, DateTime startDate, DateTime endDate, string ownerUserName, List<string> guestUserNames)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            OwnerUserName = ownerUserName;
            if (guestUserNames == null)
            {
                throw new ArgumentNullException("guestUserNames");
            }
            GuestUserNames = guestUserNames;
        }
        #endregion
    }
}

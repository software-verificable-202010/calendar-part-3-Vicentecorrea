using System;
using System.Collections.Generic;

namespace CalendarApp.Models
{
    [Serializable]
    public class Appointment
    {
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private string ownerUsername;
        private List<string> guestUsernames;

        public Appointment(string title, string description, DateTime startDate, DateTime endDate, string ownerUsername, List<string> guestUsernames = null)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            OwnerUsername = ownerUsername;
            if (guestUsernames == null)
            {
                GuestUsernames = new List<string>();
            }
            else
            {
                GuestUsernames = guestUsernames;
            }
        }

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
        public string OwnerUsername
        {
            get
            {
                return ownerUsername;
            }
            set
            {
                ownerUsername = value;
            }
        }
        /// <summary>Public property for accessing the guests field.</summary>
        public List<string> GuestUsernames
        {
            get
            {
                return guestUsernames;
            }
            set
            {
                guestUsernames = value;
            }
        }
    }
}

using System;

namespace CalendarApp.Models
{
    public class Appointment
    {
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        public Appointment(string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
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
    }
}

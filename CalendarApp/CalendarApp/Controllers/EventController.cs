using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Controllers
{
    public static class EventController
    {
        public static (bool, string) CreateEvent(Event newEvent)
        {
            bool couldTheEventBeCreated = Constants.TheEventCouldBeCreated;
            string feedbackText = "Successfully created event";
            if (newEvent.StartDate >= newEvent.EndDate)
            {
                couldTheEventBeCreated = !Constants.TheEventCouldBeCreated;
                feedbackText = "Error, the end date must be later than the start date";
            }
            else
            {
                try
                {
                    DatabaseHelper.SaveEvent(newEvent);
                }
                catch
                {
                    couldTheEventBeCreated = !Constants.TheEventCouldBeCreated;
                    feedbackText = "Error, the event could not be created";
                }
            }
            return (couldTheEventBeCreated, feedbackText);
        }

        public static List<Event> GetEventsInMonth(DateTime date)
        {
            return DatabaseHelper.GetEventsInMonth(date);
        }

        public static bool IsEventInThisTimePeriod(Event eventInDoubt, DateTime timePeriod, string selectedCalendarView)
        {
            bool IsEventInThisTimePeriod;
            if (selectedCalendarView == Constants.MonthOption)
            {
                IsEventInThisTimePeriod = eventInDoubt.StartDate.Date <= timePeriod && timePeriod <= eventInDoubt.EndDate.Date;
            }
            else
            {
                IsEventInThisTimePeriod = eventInDoubt.StartDate <= timePeriod && timePeriod <= eventInDoubt.EndDate;
            }
            return IsEventInThisTimePeriod;
        }


        public static List<Event> GetEventsInThisTimePeriod(List<Event> events, DateTime timePeriod, string selectedCalendarView)
        {
            IEnumerable<Event> eventsObtained = from eventInDoubt in events
                                                where EventController.IsEventInThisTimePeriod(eventInDoubt, timePeriod, selectedCalendarView) == true
                                                     orderby eventInDoubt.StartDate
                                                     select eventInDoubt;
            List<Event> eventsInTimePeriod = new List<Event>(eventsObtained);
            return eventsInTimePeriod;
        }
    }
}

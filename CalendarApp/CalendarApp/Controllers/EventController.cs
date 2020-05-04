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
        public static void CreateEvent(Event newEvent)
        {
            DatabaseHelper.SaveEvent(newEvent);
        }

        public static List<Event> GetEventsInMonth(DateTime date)
        {
            return DatabaseHelper.GetEventsInMonth(date);
        }

        public static bool IsEventOnThisDay(Event @event, DateTime day)
        {
            bool startsOnThisDay = @event.StartDate.Date == day;
            bool happensOnThisDay = @event.StartDate.Date < day && day < @event.EndDate.Date;
            bool endsOnThisDay = @event.EndDate.Date == day;
            return startsOnThisDay || happensOnThisDay || endsOnThisDay;
        }
    }
}

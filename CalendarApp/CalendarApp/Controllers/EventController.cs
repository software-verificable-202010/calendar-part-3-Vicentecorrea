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
    }
}

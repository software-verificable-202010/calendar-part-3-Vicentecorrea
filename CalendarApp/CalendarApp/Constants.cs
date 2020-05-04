using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    public static class Constants
    {
        public const int DaysInWeek = 7;
        public const int DefaultFirstDay = 1;
        public const int GapBetweenIndexAndNumber = 1;
        public const int GapBetweenHoursColumnAndMondayColumn = 1;
        public const int DefaultInitialIndex = 0;
        public const string Empty = "";
        public const string Space = " ";
        public const int NextTimeInterval = 1;
        public const int PreviousTimeInterval = -1;
        public const string MonthAndYearFormat = "MMMM   yyyy";
        public const string MonthFormat = "MMMM";
        public const string EnglishLanguageCode = "en-EN";
        public const string DatabaseName = "CalendarDatabase";
        public const int HourSubtractionFactor = -1;
        public const string MonthOptionFromCalendarDisplayMenu = "Month";
        public const string WeekOptionFromCalendarDisplayMenu = "Week";
        public const int HoursInDay = 24;
        public const string ZerosOfHour = ":00";
        public const bool IsGoingToToday = true;
        public const bool IsNotGoingToToday = false;
        //public const string HoursColumnHeader = "Hours";
        public const string HyphenWithSpaces = " - ";
        public const string FiveSpaces = "     ";
        public const string TenSpaces = "          ";
        public const string Event = "event";
        public const string Plurality = "s";
        public const int OneElement = 1;
        public const int ZeroElements = 0;
    }
}

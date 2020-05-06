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
        public const int HeaderRowIndex = -1;
        public const int HourSubtractionFactor = -1;
        public const string MonthOption = "Month";
        public const string WeekOption = "Week";
        public const int HoursInDay = 24;
        public const string ZerosOfHour = ":00  ";
        public const bool IsGoingToToday = true;
        public const bool IsNotGoingToToday = false;
        //public const string HoursColumnHeader = "Hours";
        public const string HyphenWithSpaces = " - ";
        public const int CellHeightInMonthView = 50;
        public const bool TheAppointmentCouldBeCreated = true;
        public const int OneItemInList = 1;
        public const int ZeroItemsInList = 0;
        public const string FormatDateInAppointmentInformation = "dddd, dd MMMM yyyy, HH:mm";
        public const string DayAndMonthFormat = "d MMMM";
    }
}

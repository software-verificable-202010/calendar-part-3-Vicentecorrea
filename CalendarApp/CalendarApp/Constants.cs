namespace CalendarApp
{
    public static class Constants
    {
        #region Constants
        public const int DaysInWeek = 7;
        public const int DefaultFirstDay = 1;
        public const int GapBetweenIndexAndNumber = 1;
        public const int GapBetweenHoursColumnAndMondayColumn = 1;
        public const int DefaultInitialIndex = 0;
        public const int NextTimeInterval = 1;
        public const int PreviousTimeInterval = -1;
        public const int HeaderRowIndex = -1;
        public const int HourSubtractionFactor = -1;
        public const int HoursInDay = 24;
        public const int CellHeightInMonthView = 60;
        public const int CellHeightInWeekView = 30;
        public const int OneItemInList = 1;
        public const int ZeroItemsInList = 0;
        public const string Empty = "";
        public const string MonthAndYearFormat = "MMMM   yyyy";
        public const string MonthFormat = "MMMM";
        public const string EnglishLanguageCode = "en-GB";
        public const string MonthOption = "Month";
        public const string WeekOption = "Week";
        public const string FormatDateInAppointmentInformation = "dddd, dd MMMM yyyy, HH:mm";
        public const string DayAndMonthFormat = "d MMMM";
        public const string HourAndMinuteFormat = "HH:mm";
        public const string PathToAppointmentsSerializationFile = "..\\..\\appointments.bin";
        public const string PathToUsersSerializationFile = "..\\..\\users.bin";
        public const bool EnabledVisualStyles = true;
        #endregion
    }
}

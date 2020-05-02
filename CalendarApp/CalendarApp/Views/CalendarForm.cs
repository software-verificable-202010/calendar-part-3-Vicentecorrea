using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using CalendarApp.Models;
using CalendarApp.Views;

namespace CalendarApp
{
    public partial class CalendarForm : Form
    {
        DateTime selectedDate;
        int daysInSelectedMonth;
        int daysBetweenMondayAndFirstDayOfSelectedMonth;
        int weeksInSelectedMonth;
        int iteratorDay;
        public CalendarForm()
        {
            InitializeComponent();
            selectedDate = DateTime.Today;
            ShowCalendar();
        }

        private void ShowCalendar()
        {
            calendarGridView.Rows.Clear();
            UpdateBasicCalendarInformation();
            MakeCalendarTable();
            if (selectedDate == DateTime.Today)
            {
                PaintToday();
            }
        }

        private void UpdateBasicCalendarInformation()
        {
            monthLabel.Text = selectedDate.ToString(Constants.MonthAndYearFormat, new CultureInfo(Constants.EnglishLanguageCode));
            daysInSelectedMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
            daysBetweenMondayAndFirstDayOfSelectedMonth = GetDaysBetweenMondayAndFirstDayOfSelectedMonth();
            weeksInSelectedMonth = (int)Math.Ceiling((daysInSelectedMonth + daysBetweenMondayAndFirstDayOfSelectedMonth) / (float)Constants.DaysInWeek);
            iteratorDay = Constants.DefaultFirstDay;
        }

        private void MakeCalendarTable()
        {
            for (int week = Constants.DefaultInitialIndex; week < weeksInSelectedMonth; week++)
            {
                calendarGridView.Rows.Add(GetWeekRow(week.Equals(Constants.DefaultInitialIndex)));
            }
        }
        private string[] GetWeekRow(bool isFirstWeek)
        {
            List<string> weekRow = new List<string>();
            for (int weekDay = Constants.DefaultInitialIndex; weekDay < Constants.DaysInWeek; weekDay++)
            {
                if ((weekDay < daysBetweenMondayAndFirstDayOfSelectedMonth && isFirstWeek) || (iteratorDay > daysInSelectedMonth))
                {
                    weekRow.Add(Constants.Empty);
                }
                else
                {
                    weekRow.Add(iteratorDay.ToString());
                    iteratorDay++;
                }
            }
            return weekRow.ToArray();
        }

        private void PaintToday()
        {
            for (int row = Constants.DefaultInitialIndex; row < calendarGridView.RowCount; row++)
            {
                for (int column = Constants.DefaultInitialIndex; column < calendarGridView.ColumnCount; column++)
                {
                    if (calendarGridView.Rows[row].Cells[column].Value.ToString() == selectedDate.Day.ToString()){
                        calendarGridView.Rows[row].Cells[column].Style.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private int GetDaysBetweenMondayAndFirstDayOfSelectedMonth()
        {
            DateTime firstDateOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, Constants.DefaultFirstDay);
            return ((int)firstDateOfMonth.DayOfWeek) - Constants.GapBetweenIndexAndNumber;
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(Constants.NextTimeInterval);
            ShowCalendar();
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddMonths(Constants.PreviousTimeInterval);
            ShowCalendar();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            ShowCalendar();
        }

        private void GoToCreateEventFormButton_Click(object sender, EventArgs e)
        {
            CreateEventForm createEventForm = new CreateEventForm();
            createEventForm.Show();
        }
    }
}

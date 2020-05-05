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
using CalendarApp.Controllers;

namespace CalendarApp
{
    public partial class CalendarForm : Form
    {
        #region Fields
        DateTime selectedDate;
        int daysInSelectedMonth;
        int daysBetweenMondayAndFirstDayOfSelectedMonth;
        int weeksInSelectedMonth;
        int iteratorDay;
        private readonly DayOfWeek[] weekDays = {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday,
                                                 DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday};
        List<Event> eventsInMonth = new List<Event>();
        #endregion

        #region Methods
        public CalendarForm()
        {
            InitializeComponent();
            selectedDate = DateTime.Today;
            eventsInMonth = EventController.GetEventsInMonth(selectedDate);
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
            if (calendarGridView.Columns.Count > Constants.DaysInWeek)
            {
                calendarGridView.Columns.RemoveAt(Constants.DefaultInitialIndex);
            }
            for (int dayColumn = Constants.DefaultInitialIndex; dayColumn < calendarGridView.Columns.Count; dayColumn++)
            {
                calendarGridView.Columns[dayColumn].HeaderText = weekDays[dayColumn].ToString();
                calendarGridView.Columns[dayColumn].HeaderCell.Style.BackColor = Color.White;
            }
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
        private DataGridViewRow GetWeekRow(bool isFirstWeek)
        {
            DataGridViewRow row = new DataGridViewRow();
            for (int weekDay = Constants.DefaultInitialIndex; weekDay < Constants.DaysInWeek; weekDay++)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                if ((weekDay < daysBetweenMondayAndFirstDayOfSelectedMonth && isFirstWeek) || (iteratorDay > daysInSelectedMonth))
                {
                    cell.Value = Constants.Empty;
                }
                else
                {
                    DateTime day = new DateTime(selectedDate.Year, selectedDate.Month, iteratorDay);
                    List<Event> eventsInThisDay = EventController.GetEventsInThisTimePeriod(eventsInMonth, day, calendarDisplayMenuListBox.SelectedItem.ToString());
                    
                    string cellText = iteratorDay.ToString();
                    foreach (Event eventInThisDay in eventsInThisDay)
                    {
                        cellText += Environment.NewLine + eventInThisDay.StartDate.Hour.ToString() + Constants.ZerosOfHour + eventInThisDay.Title;
                    }
                    cell.Value = cellText;
                    cell.Tag = eventsInThisDay;
                    iteratorDay++;
                }
                row.Cells.Add(cell);
            }
            row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            row.Height = Constants.CellHeightInMonthView;
            return row;
        }

        private void PaintToday()
        {
            int cellCounter = Constants.DefaultInitialIndex;
            for (int row = Constants.DefaultInitialIndex; row < calendarGridView.RowCount; row++)
            {
                for (int column = Constants.DefaultInitialIndex; column < calendarGridView.ColumnCount; column++)
                {
                    cellCounter++;
                    if (cellCounter == selectedDate.Day + daysBetweenMondayAndFirstDayOfSelectedMonth){
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

        private void ShowSelectedDisplay()
        {
            if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.MonthOption)
            {
                ShowCalendar();
            }
            else if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.WeekOption)
            {
                ShowWeek();
            }
        }

        private void MoveToSelectedPeriod(int timeInterval)
        {
            if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.MonthOption)
            {
                selectedDate = selectedDate.AddMonths(timeInterval);
            }
            else if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.WeekOption)
            {
                selectedDate = selectedDate.AddDays(timeInterval * Constants.DaysInWeek);
            }
        }

        private void ShowWeek()
        {
            calendarGridView.Rows.Clear();
            AddHoursColumn();
            UpdateBasicWeekInformation();
            AddHourlyRows();
        }

        private void AddHoursColumn()
        {
            if (calendarGridView.Columns.Count == Constants.DaysInWeek)
            {
                DataGridViewTextBoxColumn columnOfHours = new DataGridViewTextBoxColumn();
                calendarGridView.Columns.Insert(Constants.DefaultInitialIndex, columnOfHours);
            }
        }

        private void UpdateBasicWeekInformation()
        {
            DateTime iteratorDayOfWeek = GetMondayOfWeek(selectedDate);
            DateTime firstDateOfWeek = iteratorDayOfWeek;
            for (int dayColumn = Constants.GapBetweenHoursColumnAndMondayColumn; dayColumn < calendarGridView.Columns.Count; dayColumn++)
            {
                calendarGridView.Columns[dayColumn].HeaderText = iteratorDayOfWeek.DayOfWeek.ToString() + Constants.Space + iteratorDayOfWeek.Day.ToString();
                if (iteratorDayOfWeek == DateTime.Today)
                {
                    calendarGridView.EnableHeadersVisualStyles = true;
                    calendarGridView.Columns[dayColumn].HeaderCell.Style.BackColor = Color.LightCoral;
                    calendarGridView.EnableHeadersVisualStyles = false;
                }
                else
                {
                    calendarGridView.Columns[dayColumn].HeaderCell.Style.BackColor = Color.White;
                }
                iteratorDayOfWeek = iteratorDayOfWeek.AddDays(Constants.NextTimeInterval);
            }
            DateTime lastDateOfWeek = iteratorDayOfWeek;
            UpdateMonthLabel(firstDateOfWeek, lastDateOfWeek);
        }

        private DateTime GetMondayOfWeek(DateTime date)
        {
            DateTime iteratorDayOfWeek = date;
            while (iteratorDayOfWeek.DayOfWeek != DayOfWeek.Monday)
            {
                iteratorDayOfWeek = iteratorDayOfWeek.AddDays(Constants.PreviousTimeInterval);
            }
            return iteratorDayOfWeek;
        }

        private void UpdateMonthLabel(DateTime firstDateOfWeek, DateTime lastDateOfWeek)
        {
            if (firstDateOfWeek.Month != lastDateOfWeek.Month && firstDateOfWeek.Year != lastDateOfWeek.Year)
            {
                monthLabel.Text = firstDateOfWeek.ToString(Constants.MonthAndYearFormat, new CultureInfo(Constants.EnglishLanguageCode)) + Constants.HyphenWithSpaces +
                    lastDateOfWeek.ToString(Constants.MonthAndYearFormat, new CultureInfo(Constants.EnglishLanguageCode));
            }
            else if (firstDateOfWeek.Month != lastDateOfWeek.Month && firstDateOfWeek.Year == lastDateOfWeek.Year)
            {
                monthLabel.Text = firstDateOfWeek.ToString(Constants.MonthFormat, new CultureInfo(Constants.EnglishLanguageCode)) + Constants.HyphenWithSpaces +
                    lastDateOfWeek.ToString(Constants.MonthAndYearFormat, new CultureInfo(Constants.EnglishLanguageCode));
            }
            else if (firstDateOfWeek.Month == lastDateOfWeek.Month)
            {
                monthLabel.Text = lastDateOfWeek.ToString(Constants.MonthAndYearFormat, new CultureInfo(Constants.EnglishLanguageCode));
            }
        }

        private void AddHourlyRows()
        {
            for (int hour = Constants.DefaultInitialIndex; hour < Constants.HoursInDay; hour++)
            {
                calendarGridView.Rows.Add(GetHourlyRow(hour));
            }
        }
        
        private DataGridViewRow GetHourlyRow(int hour)
        {
            DateTime iteratorDayInWeek = GetMondayOfWeek(selectedDate);
            iteratorDayInWeek = iteratorDayInWeek.AddHours(iteratorDayInWeek.Hour * Constants.PreviousTimeInterval);
            iteratorDayInWeek = iteratorDayInWeek.AddHours(hour);
            DataGridViewRow row = new DataGridViewRow();
            foreach (DataGridViewColumn column in calendarGridView.Columns)
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                if (column.Index == Constants.DefaultInitialIndex)
                {
                    cell.Value = hour.ToString() + Constants.ZerosOfHour;
                }
                else
                {
                    List<Event> eventsInThisDayAtThisHour = EventController.GetEventsInThisTimePeriod(eventsInMonth, iteratorDayInWeek, calendarDisplayMenuListBox.SelectedItem.ToString());
                    string cellText = Constants.Empty;
                    foreach (Event eventAtThisTime in eventsInThisDayAtThisHour)
                    {
                        cellText += eventAtThisTime.Title + Environment.NewLine;
                    }
                    if (eventsInThisDayAtThisHour.Count > Constants.ZeroItemsInList)
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    cell.Value = cellText;
                    cell.Tag = eventsInThisDayAtThisHour;
                    iteratorDayInWeek = iteratorDayInWeek.AddDays(Constants.NextTimeInterval);
                }
                row.Cells.Add(cell);
            }
            return row;
        }
        #endregion

        #region ButtonActions
        private void NextTimePeriodButton_Click(object sender, EventArgs e)
        {
            MoveToSelectedPeriod(Constants.NextTimeInterval);
            ShowSelectedDisplay();
        }

        private void PreviousTimePeriodButton_Click(object sender, EventArgs e)
        {
            MoveToSelectedPeriod(Constants.PreviousTimeInterval);
            ShowSelectedDisplay();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            ShowSelectedDisplay();
        }

        private void GoToCreateEventFormButton_Click(object sender, EventArgs e)
        {
            CreateEventForm createEventForm = new CreateEventForm();
            createEventForm.Show();
        }

        private void CalendarDisplayMenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedDisplay();
        }

        private void CalendarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Event> events = (List<Event>)calendarGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;
            if (events.Count > Constants.OneItemInList)
            {
                EventsInTimePeriodForm eventsInTimePeriodForm = new EventsInTimePeriodForm(events);
                eventsInTimePeriodForm.Show();
            }
            else
            {
                EventInformationForm eventInformationForm = new EventInformationForm(events[Constants.DefaultInitialIndex]);
                eventInformationForm.Show();
            }
            
        }
        #endregion
    }
}

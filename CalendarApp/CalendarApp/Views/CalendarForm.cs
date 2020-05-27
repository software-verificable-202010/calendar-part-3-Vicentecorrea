using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using CalendarApp.Models;
using CalendarApp.Views;
using CalendarApp.Controllers;

namespace CalendarApp
{
    public partial class CalendarForm : Form
    {
        #region Fields
        private DateTime selectedDate;
        private int daysInSelectedMonth;
        private int daysBetweenMondayAndFirstDayOfSelectedMonth;
        private int weeksInSelectedMonth;
        private int iteratorDayInMonth;
        private readonly DayOfWeek[] weekDays = {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday,
                                                 DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday};
        private List<Appointment> appointmentsInMonth = new List<Appointment>();
        private DateTime iteratorDateInWeek;
        #endregion

        #region General Methods
        public CalendarForm()
        {
            InitializeComponent();
            AppointmentController.LoadAppointments();
            selectedDate = DateTime.Today;
            calendarDisplayMenuListBox.SelectedItem = Constants.MonthOption;
            ShowMonth();
        }

        public void ShowSelectedDisplay()
        {
            if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.MonthOption)
            {
                ShowMonth();
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

        private bool WasHeaderOrColumnOfHoursClicked(int rowIndex, int columnIndex)
        {
            bool selectedViewIsWeekly = calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.WeekOption;
            return rowIndex == Constants.HeaderRowIndex || (columnIndex == Constants.DefaultInitialIndex && selectedViewIsWeekly);
        }
        #endregion

        #region Monthly View Methods
        private void ShowMonth()
        {
            calendarGridView.Rows.Clear();
            AppointmentController.GetAppointmentsInMonth(selectedDate);
            UpdateBasicMonthInformation();
            MakeMonthTable();
            if (selectedDate == DateTime.Today)
            {
                PaintToday();
            }
        }

        private void UpdateBasicMonthInformation()
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
            iteratorDayInMonth = Constants.DefaultFirstDay;
        }

        private void MakeMonthTable()
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
                row.Cells.Add(GetDayCellInMonthView(weekDay, isFirstWeek));
            }
            row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            row.Height = Constants.CellHeightInMonthView;
            return row;
        }

        private DataGridViewTextBoxCell GetDayCellInMonthView(int weekDay, bool isFirstWeek)
        {
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            if ((weekDay < daysBetweenMondayAndFirstDayOfSelectedMonth && isFirstWeek) || (iteratorDayInMonth > daysInSelectedMonth))
            {
                cell.Value = Constants.Empty;
            }
            else
            {
                cell = GetDayCellNonEmptyInMonthView();
            }
            return cell;
        }

        private DataGridViewTextBoxCell GetDayCellNonEmptyInMonthView()
        {
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            DateTime day = new DateTime(selectedDate.Year, selectedDate.Month, iteratorDayInMonth);
            List<Appointment> appointmentsInThisDay = AppointmentController.GetAppointmentsInThisTimePeriod(appointmentsInMonth, day, calendarDisplayMenuListBox.SelectedItem.ToString());
            string cellText = GetCellTextInMonthView(appointmentsInThisDay, day);
            cell.Value = cellText;
            cell.Tag = appointmentsInThisDay;
            iteratorDayInMonth++;
            return cell;
        }

        private void PaintToday()
        {
            int cellCounter = Constants.DefaultInitialIndex;
            for (int row = Constants.DefaultInitialIndex; row < calendarGridView.RowCount; row++)
            {
                for (int column = Constants.DefaultInitialIndex; column < calendarGridView.ColumnCount; column++)
                {
                    cellCounter++;
                    if (cellCounter == selectedDate.Day + daysBetweenMondayAndFirstDayOfSelectedMonth)
                    {
                        calendarGridView.Rows[row].Cells[column].Style.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private int GetDaysBetweenMondayAndFirstDayOfSelectedMonth()
        {
            DateTime firstDateOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, Constants.DefaultFirstDay);
            int firstDayOfMonth;
            if (firstDateOfMonth.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                firstDayOfMonth = Constants.DaysInWeek;
            }
            else
            {
                firstDayOfMonth = (int)firstDateOfMonth.DayOfWeek;
            }
            return firstDayOfMonth - Constants.GapBetweenIndexAndNumber;
        }

        private string GetCellTextInMonthView(List<Appointment> appointmentsInThisDay, DateTime day)
        {
            string cellText = iteratorDayInMonth.ToString();
            foreach (Appointment appointment in appointmentsInThisDay)
            {
                cellText += Environment.NewLine;
                if (appointment.StartDate.Date == day.Date)
                {
                    cellText += appointment.StartDate.ToString(Constants.HourAndMinuteFormat);
                }
                cellText += appointment.Title;
            }
            return cellText;
        }
        #endregion

        #region Weekly View Methods

        private void ShowWeek()
        {
            calendarGridView.Rows.Clear();
            appointmentsInMonth = AppointmentController.GetAppointmentsInMonth(selectedDate);
            AddHoursColumn();
            UpdateBasicWeekInformation();
            MakeWeekTable();
        }

        private void UpdateCalendarLabelInWeekView(DateTime firstDateOfWeek, DateTime lastDateOfWeek)
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

        private void AddHoursColumn()
        {
            if (calendarGridView.Columns.Count == Constants.DaysInWeek)
            {
                DataGridViewTextBoxColumn columnOfHours = new DataGridViewTextBoxColumn();
                columnOfHours.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                    calendarGridView.EnableHeadersVisualStyles = Constants.EnabledVisualStyles;
                    calendarGridView.Columns[dayColumn].HeaderCell.Style.BackColor = Color.LightCoral;
                    calendarGridView.EnableHeadersVisualStyles = !Constants.EnabledVisualStyles;
                }
                else
                {
                    calendarGridView.Columns[dayColumn].HeaderCell.Style.BackColor = Color.White;
                }
                iteratorDayOfWeek = iteratorDayOfWeek.AddDays(Constants.NextTimeInterval);
            }
            DateTime lastDateOfWeek = iteratorDayOfWeek;
            UpdateCalendarLabelInWeekView(firstDateOfWeek, lastDateOfWeek);
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

        private void MakeWeekTable()
        {
            for (int hour = Constants.DefaultInitialIndex; hour < Constants.HoursInDay; hour++)
            {
                calendarGridView.Rows.Add(GetHourlyRow(hour));
            }
        }
        
        private DataGridViewRow GetHourlyRow(int hour)
        {
            iteratorDateInWeek = GetMondayOfWeek(selectedDate);
            iteratorDateInWeek = iteratorDateInWeek.AddHours(iteratorDateInWeek.Hour * Constants.PreviousTimeInterval);
            iteratorDateInWeek = iteratorDateInWeek.AddHours(hour);
            DataGridViewRow row = new DataGridViewRow();
            foreach (DataGridViewColumn column in calendarGridView.Columns)
            {
                row.Cells.Add(GetHourCellInWeekView(hour, column));
            }
            row.Height = Constants.CellHeightInWeekView;
            return row;
        }

        private DataGridViewTextBoxCell GetHourCellInWeekView(int hour, DataGridViewColumn column)
        {
            DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
            if (column.Index == Constants.DefaultInitialIndex)
            {
                cell.Value = hour.ToString() + Constants.ZerosOfHour;
            }
            else
            {
                List<Appointment> appointmentsInThisDayAtThisHour = AppointmentController.GetAppointmentsInThisTimePeriod(appointmentsInMonth, iteratorDateInWeek, calendarDisplayMenuListBox.SelectedItem.ToString());
                string cellText = GetCellTextInWeekView(appointmentsInThisDayAtThisHour, hour);
                if (appointmentsInThisDayAtThisHour.Count > Constants.ZeroItemsInList)
                {
                    cell.Style.BackColor = Color.LightGreen;
                }
                cell.Value = cellText;
                cell.Tag = appointmentsInThisDayAtThisHour;
                iteratorDateInWeek = iteratorDateInWeek.AddDays(Constants.NextTimeInterval);
            }
            return cell;
        }

        private string GetCellTextInWeekView(List<Appointment> appointmentsInThisDayAtThisHour, int hour)
        {
            string cellText = Constants.Empty;
            foreach (Appointment appointment in appointmentsInThisDayAtThisHour)
            {
                if (appointment.StartDate.Hour == hour && appointment.StartDate.Day == iteratorDateInWeek.Day)
                {
                    cellText += appointment.StartDate.ToString(Constants.HourAndMinuteFormat);
                }
                cellText += appointment.Title + Environment.NewLine;
            }
            return cellText;
        }

        private DateTime GetClickedDateAndTime(DataGridViewCellEventArgs e)
        {
            DateTime clickedDateAndTime;
            if (calendarDisplayMenuListBox.SelectedItem.ToString() == Constants.MonthOption)
            {
                int day = e.RowIndex * Constants.DaysInWeek + e.ColumnIndex + Constants.GapBetweenIndexAndNumber - daysBetweenMondayAndFirstDayOfSelectedMonth;
                clickedDateAndTime = new DateTime(selectedDate.Year, selectedDate.Month, day);
            }
            else
            {
                clickedDateAndTime = GetMondayOfWeek(selectedDate);
                clickedDateAndTime = clickedDateAndTime.AddDays(e.ColumnIndex - Constants.GapBetweenHoursColumnAndMondayColumn);
                clickedDateAndTime = clickedDateAndTime.AddHours(e.RowIndex);
            }
            return clickedDateAndTime;
        }
        #endregion

        #region Button Actions
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

        private void GoToCreateAppointmentFormButton_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm createAppointmentForm = new CreateAppointmentForm(this);
            createAppointmentForm.Show();
        }

        private void CalendarDisplayMenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedDisplay();
        }

        private void CalendarGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!WasHeaderOrColumnOfHoursClicked(e.RowIndex, e.ColumnIndex))
            {
                List<Appointment> appointments = (List<Appointment>)calendarGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;
                if (appointments.Count > Constants.OneItemInList)
                {
                    DateTime clickedDateAndTime = GetClickedDateAndTime(e);
                    AppointmentsInDayForm appointmentsInDayForm = new AppointmentsInDayForm(appointments, clickedDateAndTime);
                    appointmentsInDayForm.Show();
                }
                else if (appointments.Count == Constants.OneItemInList)
                {
                    AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(appointments[Constants.DefaultInitialIndex]);
                    appointmentInformationForm.Show();
                }
            } 
        }
        #endregion
    }
}

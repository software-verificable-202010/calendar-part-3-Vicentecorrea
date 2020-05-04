using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarApp.Models;
using CalendarApp.Controllers;

namespace CalendarApp.Views
{
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            string eventName = eventNameTextBox.Text;
            string eventDescription = eventDescriptionRichTextBox.Text;
            DateTime eventStartDate = eventStartDateDateTimePicker.Value;
            DateTime eventEndDate = eventEndDateDateTimePicker.Value;
            int eventStartTime = (int)eventStartTimeNumericUpDown.Value;
            int eventEndTime = (int)eventEndTimeNumericUpDown.Value;
            DateTime definitiveEventStartDate = GetDateWithSelectedTime(eventStartDate, eventStartTime);
            DateTime definitiveEventEndDate = GetDateWithSelectedTime(eventEndDate, eventEndTime);
            Event newEvent = new Event(eventName, eventDescription, definitiveEventStartDate, definitiveEventEndDate);
            bool couldTheEventBeCreated;
            string feedbackText;
            (couldTheEventBeCreated, feedbackText) = EventController.CreateEvent(newEvent);
            if (couldTheEventBeCreated)
            {
                eventNameTextBox.Clear();
                eventDescriptionRichTextBox.Clear();
            }
            MessageBox.Show(feedbackText);
        }

        private DateTime GetDateWithSelectedTime(DateTime selectedDate, int selectedTime)
        {
            DateTime temporaryDate = selectedDate.AddHours(selectedDate.Hour * Constants.HourSubtractionFactor);
            temporaryDate = temporaryDate.AddMinutes(selectedDate.Minute * Constants.HourSubtractionFactor);
            temporaryDate = temporaryDate.AddSeconds(selectedDate.Second * Constants.HourSubtractionFactor);
            DateTime dateWithSelectedTime = temporaryDate.AddHours(selectedTime);
            return dateWithSelectedTime;
        }
    }
}

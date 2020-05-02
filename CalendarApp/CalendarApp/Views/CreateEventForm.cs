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
            try
            {
                EventController.CreateEvent(newEvent);
                MessageBox.Show("Successfully created event");
                eventNameTextBox.Clear();
                eventDescriptionRichTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("Error, the event could not be created");
            }
        }

        private DateTime GetDateWithSelectedTime(DateTime selectedDate, int selectedTime)
        {
            selectedDate = selectedDate.AddHours(selectedDate.Hour * Constants.HourSubtractionFactor);
            selectedDate = selectedDate.AddMinutes(selectedDate.Minute * Constants.HourSubtractionFactor);
            selectedDate = selectedDate.AddSeconds(selectedDate.Second * Constants.HourSubtractionFactor);
            DateTime dateWithSelectedTime = selectedDate.AddHours(selectedTime);
            return dateWithSelectedTime;
        }
    }
}

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
            Event newEvent = new Event(eventName, eventDescription, eventStartDate, eventEndDate);
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
    }
}

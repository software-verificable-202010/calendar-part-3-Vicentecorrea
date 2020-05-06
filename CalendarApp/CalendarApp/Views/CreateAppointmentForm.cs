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
    public partial class CreateAppointmentForm : Form
    {
        private CalendarForm calendar;
        public CreateAppointmentForm(CalendarForm calendarForm)
        {
            InitializeComponent();
            calendar = calendarForm;
        }

        private void CreateappointmentButton_Click(object sender, EventArgs e)
        {
            string appointmentName = appointmentNameTextBox.Text;
            string appointmentDescription = appointmentDescriptionRichTextBox.Text;
            DateTime appointmentStartDate = appointmentStartDateDateTimePicker.Value;
            DateTime appointmentEndDate = appointmentEndDateDateTimePicker.Value;
            Appointment newappointment = new Appointment(appointmentName, appointmentDescription, appointmentStartDate, appointmentEndDate);
            bool couldTheappointmentBeCreated;
            string feedbackText;
            (couldTheappointmentBeCreated, feedbackText) = AppointmentController.CreateAppointment(newappointment);
            if (couldTheappointmentBeCreated)
            {
                appointmentNameTextBox.Clear();
                appointmentDescriptionRichTextBox.Clear();
                calendar.ShowSelectedDisplay();
            }
            MessageBox.Show(feedbackText);
        }
    }
}

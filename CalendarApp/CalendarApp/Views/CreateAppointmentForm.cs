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
        CalendarForm calendar;
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
            int appointmentStartTime = (int)appointmentStartTimeNumericUpDown.Value;
            int appointmentEndTime = (int)appointmentEndTimeNumericUpDown.Value;
            DateTime definitiveappointmentStartDate = GetDateWithSelectedTime(appointmentStartDate, appointmentStartTime);
            DateTime definitiveappointmentEndDate = GetDateWithSelectedTime(appointmentEndDate, appointmentEndTime);
            Appointment newappointment = new Appointment(appointmentName, appointmentDescription, definitiveappointmentStartDate, definitiveappointmentEndDate);
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

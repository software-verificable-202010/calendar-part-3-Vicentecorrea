using System;
using System.Windows.Forms;
using CalendarApp.Models;
using CalendarApp.Controllers;

namespace CalendarApp.Views
{
    public partial class CreateAppointmentForm : Form
    {
        private readonly CalendarForm calendar;
        public CreateAppointmentForm(CalendarForm calendarForm)
        {
            InitializeComponent();
            calendar = calendarForm;
        }

        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            string appointmentTitle = appointmentNameTextBox.Text;
            string appointmentDescription = appointmentDescriptionRichTextBox.Text;
            DateTime appointmentStartDate = appointmentStartDateDateTimePicker.Value;
            DateTime appointmentEndDate = appointmentEndDateDateTimePicker.Value;
            bool appointmentHasTitle = !String.IsNullOrWhiteSpace(appointmentTitle);
            bool appointmentHasDescription = !String.IsNullOrWhiteSpace(appointmentDescription);
            bool appointmentEndDateIsLaterThanStartDate = appointmentStartDate < appointmentEndDate;
            bool couldTheAppointmentBeCreated = appointmentHasTitle && appointmentHasDescription && appointmentEndDateIsLaterThanStartDate;
            MessageBox.Show(GetFeedbackText(appointmentHasTitle, appointmentHasDescription, appointmentEndDateIsLaterThanStartDate));
            if (couldTheAppointmentBeCreated)
            {
                Appointment newAppointment = new Appointment(appointmentTitle, appointmentDescription, appointmentStartDate, appointmentEndDate);
                AppointmentController.SaveAppointment(newAppointment);
                appointmentNameTextBox.Clear();
                appointmentDescriptionRichTextBox.Clear();
                calendar.ShowSelectedDisplay();
            }
        }

        private string GetFeedbackText(bool appointmentHasTitle, bool appointmentHasDescription, bool appointmentEndDateIsLaterThanStartDate)
        {
            string feedbackText = "Successfully created appointment";
            if (!appointmentHasTitle || !appointmentHasDescription || !appointmentEndDateIsLaterThanStartDate)
            {
                feedbackText = "Error" + Environment.NewLine;
                if (!appointmentHasTitle)
                {
                    feedbackText += "The appointment must have a title" + Environment.NewLine;

                }
                if (!appointmentHasDescription)
                {
                    feedbackText += "The appointment must have a description" + Environment.NewLine;

                }
                if (!appointmentEndDateIsLaterThanStartDate)
                {
                    feedbackText += "The end date must be later than the start date";
                }
            }
            return feedbackText;
        }
    }   
}

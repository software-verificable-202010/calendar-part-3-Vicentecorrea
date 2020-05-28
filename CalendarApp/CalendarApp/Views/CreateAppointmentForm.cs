using System;
using System.Windows.Forms;
using CalendarApp.Models;
using CalendarApp.Controllers;
using System.Collections.Generic;
using System.ComponentModel;

namespace CalendarApp.Views
{
    public partial class CreateAppointmentForm : Form
    {
        private readonly CalendarForm calendar;
        private BindingList<string> allUsernames = new BindingList<string>();
        private BindingList<string> invitedUsernames = new BindingList<string>();
        public CreateAppointmentForm(CalendarForm calendarForm)
        {
            InitializeComponent();
            calendar = calendarForm;
            AddAllUsernamesToListBox();
            allUsernamesListBox.DataSource = allUsernames;
            invitedUsernamesListBox.DataSource = invitedUsernames;
        }

        private void AddAllUsernamesToListBox()
        {
            foreach (User user in UserController.Users)
            {
                if (user.Username != UserController.LoggedUsername)
                {
                    allUsernames.Add(user.Username);
                }
            }
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
                List<string> appointmentGuests = GetAppointmentGuests();
                Appointment newAppointment = new Appointment(appointmentTitle, appointmentDescription, appointmentStartDate, appointmentEndDate, UserController.LoggedUsername, appointmentGuests);
                AppointmentController.SaveAppointment(newAppointment);
                appointmentNameTextBox.Clear();
                appointmentDescriptionRichTextBox.Clear();
                calendar.ShowSelectedDisplay();
            }
        }

        private List<string> GetAppointmentGuests()
        {
            List<string> guestsUsernames = new List<string>();
            foreach(string invitedUsername in invitedUsernames)
            {
                guestsUsernames.Add(invitedUsername);
            }
            return guestsUsernames;
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

        private void AllUsernamesListBox_Click(object sender, EventArgs e)
        {
            string usernameToMove = allUsernamesListBox.SelectedItem.ToString();
            invitedUsernames.Add(usernameToMove);
            allUsernames.Remove(usernameToMove);
        }

        private void InvitedUsernamesListBox_Click(object sender, EventArgs e)
        {
            string usernameToMove = invitedUsernamesListBox.SelectedItem.ToString();
            allUsernames.Add(usernameToMove);
            invitedUsernames.Remove(usernameToMove);
        }
    }   
}

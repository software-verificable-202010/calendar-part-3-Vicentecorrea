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
        #region Fields
        private readonly CalendarForm calendar;
        private BindingList<string> allUsernames = new BindingList<string>();
        private BindingList<string> invitedUsernames = new BindingList<string>();
        #endregion

        #region Methods
        public CreateAppointmentForm(CalendarForm calendarForm)
        {
            InitializeComponent();
            calendar = calendarForm;
            AddUsernamesToAllUsernamesList();
            allUsernamesListBox.DataSource = allUsernames;
            invitedUsernamesListBox.DataSource = invitedUsernames;
        }

        private void AddUsernamesToAllUsernamesList()
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
            string appointmentTitle = appointmentTitleTextBox.Text;
            string appointmentDescription = appointmentDescriptionRichTextBox.Text;
            DateTime appointmentStartDate = appointmentStartDateDateTimePicker.Value;
            DateTime appointmentEndDate = appointmentEndDateDateTimePicker.Value;
            bool appointmentHasTitle = !String.IsNullOrWhiteSpace(appointmentTitle);
            bool appointmentHasDescription = !String.IsNullOrWhiteSpace(appointmentDescription);
            bool appointmentEndDateIsLaterThanStartDate = appointmentStartDate < appointmentEndDate;
            bool couldTheAppointmentBeCreated = appointmentHasTitle && appointmentHasDescription && appointmentEndDateIsLaterThanStartDate;
            if (couldTheAppointmentBeCreated)
            {
                MessageBox.Show("Successfully created appointment");
                List<string> appointmentGuests = GetAppointmentGuests();
                Appointment newAppointment = new Appointment(appointmentTitle, appointmentDescription, appointmentStartDate, appointmentEndDate, UserController.LoggedUsername, appointmentGuests);
                AppointmentController.SaveAppointment(newAppointment);
                calendar.ShowSelectedDisplay();
                this.Close();
            }
            else
            {
                string errorFeedbackText = AppointmentController.GetErrorFeedbackTextCreatingAppointment(appointmentHasTitle, appointmentHasDescription, appointmentEndDateIsLaterThanStartDate);
                MessageBox.Show(errorFeedbackText);
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

        private void AllUsernamesListBox_Click(object sender, EventArgs e)
        {
            if (allUsernames.Count > Constants.ZeroItemsInList)
            {
                string usernameToMove = allUsernamesListBox.SelectedItem.ToString();
                invitedUsernames.Add(usernameToMove);
                allUsernames.Remove(usernameToMove);
            }
        }

        private void InvitedUsernamesListBox_Click(object sender, EventArgs e)
        {
            if (invitedUsernames.Count > Constants.ZeroItemsInList)
            {
                string usernameToMove = invitedUsernamesListBox.SelectedItem.ToString();
                allUsernames.Add(usernameToMove);
                invitedUsernames.Remove(usernameToMove);
            }
        }
        #endregion
    }
}

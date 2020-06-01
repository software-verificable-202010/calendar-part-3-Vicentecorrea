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
            List<string> appointmentGuests = GetAppointmentGuests();
            Appointment newAppointment = new Appointment(appointmentTitleTextBox.Text, appointmentDescriptionRichTextBox.Text, 
                appointmentStartDateDateTimePicker.Value, appointmentEndDateDateTimePicker.Value, UserController.LoggedUsername, appointmentGuests);
            bool appointmentHasTitle = !String.IsNullOrWhiteSpace(newAppointment.Title);
            bool appointmentHasDescription = !String.IsNullOrWhiteSpace(newAppointment.Description);
            bool appointmentEndDateIsLaterThanStartDate = newAppointment.StartDate < newAppointment.EndDate;
            List<string> usernamesThatCannotBeInvitedToAppointment = AppointmentController.GetUsernamesThatCannotBeInvitedToAppointment(appointmentGuests, newAppointment);
            bool areAllTheGuestsCorrect = usernamesThatCannotBeInvitedToAppointment.Count.Equals(Constants.ZeroItemsInList);
            bool areTheAppointmentValuesCorrect = appointmentHasTitle && appointmentHasDescription && appointmentEndDateIsLaterThanStartDate;
            bool couldTheAppointmentBeCreated = areTheAppointmentValuesCorrect && areAllTheGuestsCorrect;
            if (couldTheAppointmentBeCreated)
            {
                MessageBox.Show("Successfully created appointment");
                AppointmentController.SaveAppointment(newAppointment);
                calendar.ShowSelectedDisplay();
                this.Close();
            }
            else
            {
                if (!areTheAppointmentValuesCorrect)
                {
                    string errorFeedbackText = AppointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongValues(appointmentHasTitle, appointmentHasDescription, appointmentEndDateIsLaterThanStartDate);
                    MessageBox.Show(errorFeedbackText, "Error");
                }
                if (!areAllTheGuestsCorrect)
                {
                    string errorFeedbackText = AppointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongGuests(usernamesThatCannotBeInvitedToAppointment);
                    MessageBox.Show(errorFeedbackText, "Error");
                }
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

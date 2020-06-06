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
        private readonly BindingList<string> allUserNames = new BindingList<string>();
        private readonly BindingList<string> invitedUserNames = new BindingList<string>();
        #endregion

        #region Methods
        public CreateAppointmentForm(CalendarForm calendarForm)
        {
            InitializeComponent();
            calendar = calendarForm;
            AddUserNamesToAllUserNamesList();
            allUserNamesListBox.DataSource = allUserNames;
            invitedUserNamesListBox.DataSource = invitedUserNames;
        }

        private void AddUserNamesToAllUserNamesList()
        {
            foreach (User user in UserController.Users)
            {
                if (user.UserName != UserController.LoggedUserName)
                {
                    allUserNames.Add(user.UserName);
                }
            }
        }

        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            List<string> appointmentGuests = GetAppointmentGuests();
            Appointment newAppointment = new Appointment(appointmentTitleTextBox.Text, appointmentDescriptionRichTextBox.Text, 
                appointmentStartDateDateTimePicker.Value, appointmentEndDateDateTimePicker.Value, UserController.LoggedUserName, appointmentGuests);
            bool appointmentHasTitle = !String.IsNullOrWhiteSpace(newAppointment.Title);
            bool appointmentHasDescription = !String.IsNullOrWhiteSpace(newAppointment.Description);
            bool appointmentEndDateIsLaterThanStartDate = newAppointment.StartDate < newAppointment.EndDate;
            List<string> userNamesThatCannotBeInvitedToAppointment = AppointmentController.GetUserNamesThatCannotBeInvitedToAppointment(appointmentGuests, newAppointment);
            bool areAllTheGuestsCorrect = userNamesThatCannotBeInvitedToAppointment.Count.Equals(Constants.ZeroItemsInList);
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
                    string errorFeedbackText = AppointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongGuests(userNamesThatCannotBeInvitedToAppointment);
                    MessageBox.Show(errorFeedbackText, "Error");
                }
            }
        }

        private List<string> GetAppointmentGuests()
        {
            List<string> guestsUserNames = new List<string>();
            foreach(string invitedUserName in invitedUserNames)
            {
                guestsUserNames.Add(invitedUserName);
            }
            return guestsUserNames;
        }

        private void AllUserNamesListBox_Click(object sender, EventArgs e)
        {
            if (allUserNames.Count > Constants.ZeroItemsInList)
            {
                string userNameToMove = allUserNamesListBox.SelectedItem.ToString();
                invitedUserNames.Add(userNameToMove);
                allUserNames.Remove(userNameToMove);
            }
        }

        private void InvitedUserNamesListBox_Click(object sender, EventArgs e)
        {
            if (invitedUserNames.Count > Constants.ZeroItemsInList)
            {
                string userNameToMove = invitedUserNamesListBox.SelectedItem.ToString();
                allUserNames.Add(userNameToMove);
                invitedUserNames.Remove(userNameToMove);
            }
        }
        #endregion
    }
}

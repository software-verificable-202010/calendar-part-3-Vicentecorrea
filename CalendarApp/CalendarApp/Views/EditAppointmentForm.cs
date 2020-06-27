using CalendarApp.Controllers;
using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.Views
{
    public partial class EditAppointmentForm : Form
    {
        #region Fields
        private readonly Appointment appointment;
        private readonly AppointmentInformationForm appointmentInformation;
        private readonly CalendarForm calendar;
        private readonly AppointmentsInDayForm appointmentsInDay;
        private readonly BindingList<string> notInvitedUserNames = new BindingList<string>();
        private readonly BindingList<string> invitedUserNames = new BindingList<string>();
        private readonly AppointmentController appointmentController;
        private readonly UserController userController = new UserController();
        #endregion

        #region Methods
        public EditAppointmentForm(Appointment appointment, AppointmentInformationForm appointmentInformationForm, CalendarForm calendarForm, 
            AppointmentsInDayForm appointmentsInDayForm, AppointmentController appointmentController, UserController userController)
        {
            InitializeComponent();
            this.appointment = appointment;
            appointmentInformation = appointmentInformationForm;
            calendar = calendarForm;
            appointmentsInDay = appointmentsInDayForm;
            AddUserNamesToLists();
            SetPreviousValues();
            notInvitedUserNamesListBox.DataSource = notInvitedUserNames;
            invitedUserNamesListBox.DataSource = invitedUserNames;
            this.appointmentController = appointmentController;
            this.userController = userController;
        }

        private void SetPreviousValues()
        {
            appointmentTitleTextBox.Text = appointment.Title;
            appointmentDescriptionRichTextBox.Text = appointment.Description;
            appointmentStartDateDateTimePicker.Value = appointment.StartDate;
            appointmentEndDateDateTimePicker.Value = appointment.EndDate;
        }

        private void AddUserNamesToLists()
        {
            foreach (User user in userController.Users)
            {
                if (user.UserName != UserController.LoggedUserName)
                {
                    if (appointment.GuestUserNames.Contains(user.UserName)){
                        invitedUserNames.Add(user.UserName);
                    }
                    else
                    {
                        notInvitedUserNames.Add(user.UserName);
                    }
                }
            }
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
        {
            List<string> appointmentGuests = GetAppointmentGuests();
            Appointment editedAppointment = new Appointment(appointmentTitleTextBox.Text, appointmentDescriptionRichTextBox.Text,
                appointmentStartDateDateTimePicker.Value, appointmentEndDateDateTimePicker.Value, UserController.LoggedUserName, appointmentGuests);
            bool appointmentHasTitle = !String.IsNullOrWhiteSpace(editedAppointment.Title);
            bool appointmentHasDescription = !String.IsNullOrWhiteSpace(editedAppointment.Description);
            bool appointmentEndDateIsLaterThanStartDate = editedAppointment.StartDate < editedAppointment.EndDate;
            List<string> userNamesThatCannotBeInvitedToAppointment = appointmentController.GetUserNamesThatCannotBeInvitedToAppointment(appointmentGuests, editedAppointment);
            bool areAllTheGuestsCorrect = userNamesThatCannotBeInvitedToAppointment.Count.Equals(Constants.ZeroItemsInList);
            bool areTheAppointmentValuesCorrect = appointmentHasTitle && appointmentHasDescription && appointmentEndDateIsLaterThanStartDate;
            bool couldTheAppointmentBeCreated = areTheAppointmentValuesCorrect && areAllTheGuestsCorrect;
            if (couldTheAppointmentBeCreated)
            {
                appointmentController.DeleteAppointment(appointment);
                appointmentController.SaveAppointment(editedAppointment);
                appointmentInformation.UpdateFields(editedAppointment);
                calendar.ShowSelectedDisplay();
                MessageBox.Show("Successfully edited appointment");
                if (appointmentsInDay != null)
                {
                    appointmentsInDay.Close();
                }
                this.Close();
            }
            else
            {
                if (!areTheAppointmentValuesCorrect)
                {
                    string errorFeedbackText = appointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongValues(appointmentHasTitle, 
                        appointmentHasDescription, appointmentEndDateIsLaterThanStartDate);
                    MessageBox.Show(errorFeedbackText, "Error");
                }
                if (!areAllTheGuestsCorrect)
                {
                    string errorFeedbackText = appointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongGuests(userNamesThatCannotBeInvitedToAppointment);
                    MessageBox.Show(errorFeedbackText, "Error");
                }
            }
        }

        private List<string> GetAppointmentGuests()
        {
            List<string> guestsUserNames = new List<string>();
            foreach (string invitedUserName in invitedUserNames)
            {
                guestsUserNames.Add(invitedUserName);
            }
            return guestsUserNames;
        }

        private void NotInvitedUserNamesListBox_Click(object sender, EventArgs e)
        {
            if (notInvitedUserNames.Count > Constants.ZeroItemsInList)
            {
                string userNameToMove = notInvitedUserNamesListBox.SelectedItem.ToString();
                invitedUserNames.Add(userNameToMove);
                notInvitedUserNames.Remove(userNameToMove);
            }
        }

        private void InvitedUserNamesListBox_Click(object sender, EventArgs e)
        {
            if (invitedUserNames.Count > Constants.ZeroItemsInList)
            {
                string userNameToMove = invitedUserNamesListBox.SelectedItem.ToString();
                notInvitedUserNames.Add(userNameToMove);
                invitedUserNames.Remove(userNameToMove);
            }
        }
        #endregion
    }
}

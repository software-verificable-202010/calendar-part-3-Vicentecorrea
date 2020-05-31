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
        private BindingList<string> notInvitedUsernames = new BindingList<string>();
        private BindingList<string> invitedUsernames = new BindingList<string>();
        #endregion

        #region Methods
        public EditAppointmentForm(Appointment appointment, AppointmentInformationForm appointmentInformationForm, CalendarForm calendarForm, AppointmentsInDayForm appointmentsInDayForm = null)
        {
            InitializeComponent();
            this.appointment = appointment;
            appointmentInformation = appointmentInformationForm;
            calendar = calendarForm;
            appointmentsInDay = appointmentsInDayForm;
            AddUsernamesToLists();
            SetPreviousValues();
            notInvitedUsernamesListBox.DataSource = notInvitedUsernames;
            invitedUsernamesListBox.DataSource = invitedUsernames;
        }

        private void SetPreviousValues()
        {
            appointmentTitleTextBox.Text = appointment.Title;
            appointmentDescriptionRichTextBox.Text = appointment.Description;
            appointmentStartDateDateTimePicker.Value = appointment.StartDate;
            appointmentEndDateDateTimePicker.Value = appointment.EndDate;
        }

        private void AddUsernamesToLists()
        {
            foreach (User user in UserController.Users)
            {
                if (user.Username != UserController.LoggedUsername)
                {
                    if (appointment.GuestUsernames.Contains(user.Username)){
                        invitedUsernames.Add(user.Username);
                    }
                    else
                    {
                        notInvitedUsernames.Add(user.Username);
                    }
                }
            }
        }

        private List<string> GetAppointmentGuests()
        {
            List<string> guestsUsernames = new List<string>();
            foreach (string invitedUsername in invitedUsernames)
            {
                guestsUsernames.Add(invitedUsername);
            }
            return guestsUsernames;
        }

        private void EditAppointmentButton_Click(object sender, EventArgs e)
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
                List<string> appointmentGuests = GetAppointmentGuests();
                Appointment newAppointment = new Appointment(appointmentTitle, appointmentDescription, appointmentStartDate, appointmentEndDate, UserController.LoggedUsername, appointmentGuests);
                AppointmentController.DeleteAppointment(appointment);
                AppointmentController.SaveAppointment(newAppointment);
                appointmentInformation.UpdateFields(newAppointment);
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
                string errorFeedbackText = AppointmentController.GetErrorFeedbackTextCreatingAppointment(appointmentHasTitle, appointmentHasDescription, appointmentEndDateIsLaterThanStartDate);
                MessageBox.Show(errorFeedbackText);
            }
        }

        private void NotInvitedUsernamesListBox_Click(object sender, EventArgs e)
        {
            if (notInvitedUsernames.Count > Constants.ZeroItemsInList)
            {
                string usernameToMove = notInvitedUsernamesListBox.SelectedItem.ToString();
                invitedUsernames.Add(usernameToMove);
                notInvitedUsernames.Remove(usernameToMove);
            }
        }

        private void InvitedUsernamesListBox_Click(object sender, EventArgs e)
        {
            if (invitedUsernames.Count > Constants.ZeroItemsInList)
            {
                string usernameToMove = invitedUsernamesListBox.SelectedItem.ToString();
                notInvitedUsernames.Add(usernameToMove);
                invitedUsernames.Remove(usernameToMove);
            }
        }
        #endregion
    }
}

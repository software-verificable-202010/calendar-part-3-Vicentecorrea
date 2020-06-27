using System;
using System.Globalization;
using System.Windows.Forms;
using CalendarApp.Controllers;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class AppointmentInformationForm : Form
    {
        #region Fields
        private readonly Appointment appointment;
        private readonly CalendarForm calendar;
        private readonly AppointmentController appointmentController;
        private readonly UserController userController;
        #endregion

        #region Methods
        public AppointmentInformationForm(Appointment appointment, CalendarForm calendarForm, AppointmentController appointmentController, 
            UserController userController, AppointmentsInDayForm appointmentsInDayForm = null)
        {
            InitializeComponent();
            if (appointment == null)
            {
                throw new ArgumentNullException("appointment");
            }
            this.appointment = appointment;
            calendar = calendarForm;
            if (appointmentsInDayForm != null)
            {
                appointmentsInDayForm.Close();
            }
            FillFields();
            HideOwnerButtonsIfLoggedUserDoesNotOwnTheAppointment();
            this.appointmentController = appointmentController;
            this.userController = userController;
        }

        public void UpdateFields(Appointment editedAppointment)
        {
            if (editedAppointment == null)
            {
                throw new ArgumentNullException("editedAppointment");
            }
            appointmentTitleValue.Text = editedAppointment.Title;
            appointmentDescriptionRichTextBox.Text = editedAppointment.Description;
            appointmentStartDateValue.Text = editedAppointment.StartDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentEndDateValue.Text = editedAppointment.EndDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentOwnerValue.Text = editedAppointment.OwnerUserName;
            guestsListBox.DataSource = editedAppointment.GuestUserNames;
        }

        private void HideOwnerButtonsIfLoggedUserDoesNotOwnTheAppointment()
        {
            if (!UserController.LoggedUserName.Equals(appointment.OwnerUserName))
            {
                deleteAppointmentButton.Visible = false;
                editAppointmentButton.Visible = false;
            }
        }

        private void FillFields()
        {
            appointmentTitleValue.Text = appointment.Title;
            appointmentDescriptionRichTextBox.Text = appointment.Description;
            appointmentStartDateValue.Text = appointment.StartDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentEndDateValue.Text = appointment.EndDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentOwnerValue.Text = appointment.OwnerUserName;
            guestsListBox.DataSource = appointment.GuestUserNames;
        }

        private void DeleteAppointmentButton_Click(object sender, System.EventArgs e)
        {
            string warningMessage = "Delete appointment";
            string warningTitle = "Are you sure that you want to delete this appointment?";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult answer = MessageBox.Show(warningTitle, warningMessage, messageBoxButtons);
            if (answer == DialogResult.Yes)
            {
                appointmentController.DeleteAppointment(appointment);
                calendar.ShowSelectedDisplay();
                this.Close();
            }
        }

        private void EditAppointmentButton_Click(object sender, System.EventArgs e)
        {
            EditAppointmentForm editAppointmentForm = new EditAppointmentForm(appointment, this, calendar, null, appointmentController, userController);
            editAppointmentForm.Show();
        }
        #endregion
    }
}

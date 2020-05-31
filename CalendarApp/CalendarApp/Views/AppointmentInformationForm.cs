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
        #endregion

        #region Methods
        public AppointmentInformationForm(Appointment appointment, CalendarForm calendarForm, AppointmentsInDayForm appointmentsInDayForm = null)
        {
            InitializeComponent();
            this.appointment = appointment;
            calendar = calendarForm;
            if (appointmentsInDayForm != null)
            {
                appointmentsInDayForm.Close();
            }
            FillFields();
            if (!UserController.LoggedUsername.Equals(appointment.OwnerUsername))
            {
                deleteAppointmentButton.Visible = false;
                editAppointmentButton.Visible = false;
            }
        }

        private void FillFields()
        {
            appointmentNameValue.Text = appointment.Title;
            appointmentDescriptionRichTextBox.Text = appointment.Description;
            appointmentStartDateValue.Text = appointment.StartDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentEndDateValue.Text = appointment.EndDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentOwnerValue.Text = appointment.OwnerUsername;
            guestsListBox.DataSource = appointment.GuestUsernames;
        }

        public void UpdateFields(Appointment editedAppointment)
        {
            appointmentNameValue.Text = editedAppointment.Title;
            appointmentDescriptionRichTextBox.Text = editedAppointment.Description;
            appointmentStartDateValue.Text = editedAppointment.StartDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentEndDateValue.Text = editedAppointment.EndDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentOwnerValue.Text = editedAppointment.OwnerUsername;
            guestsListBox.DataSource = editedAppointment.GuestUsernames;
        }

        private void DeleteAppointmentButton_Click(object sender, System.EventArgs e)
        {
            string warningMessage = "Delete appointment";
            string warningTitle = "Are you sure that you want to delete this appointment?";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult answer = MessageBox.Show(warningTitle, warningMessage, messageBoxButtons);
            if (answer == DialogResult.Yes)
            {
                AppointmentController.DeleteAppointment(appointment);
                calendar.ShowSelectedDisplay();
                this.Close();
            }
        }

        private void EditAppointmentButton_Click(object sender, System.EventArgs e)
        {
            EditAppointmentForm editAppointmentForm = new EditAppointmentForm(appointment, this, calendar);
            editAppointmentForm.Show();
        }
        #endregion
    }
}

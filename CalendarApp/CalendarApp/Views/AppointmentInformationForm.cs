using System.Globalization;
using System.Windows.Forms;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class AppointmentInformationForm : Form
    {
        public AppointmentInformationForm(Appointment appointment)
        {
            InitializeComponent();
            appointmentNameValue.Text = appointment.Title;
            appointmentDescriptionRichTextBox.Text = appointment.Description;
            appointmentStartDateValue.Text = appointment.StartDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentEndDateValue.Text = appointment.EndDate.ToString(Constants.FormatDateInAppointmentInformation, new CultureInfo(Constants.EnglishLanguageCode));
            appointmentOwnerValue.Text = appointment.OwnerUsername;
            guestsListBox.DataSource = appointment.GuestUsernames;
        }
    }
}

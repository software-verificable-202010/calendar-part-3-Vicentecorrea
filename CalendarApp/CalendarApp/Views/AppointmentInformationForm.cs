using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}

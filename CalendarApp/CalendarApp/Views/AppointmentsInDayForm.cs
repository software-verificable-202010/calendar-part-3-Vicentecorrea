using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class AppointmentsInDayForm : Form
    {
        private readonly List<Appointment> appointments = new List<Appointment>();
        public AppointmentsInDayForm(List<Appointment> appointmentsInDay, DateTime dayAndTime)
        {
            InitializeComponent();
            appointments = appointmentsInDay;
            if (dayAndTime == dayAndTime.Date)
            {
                dateAndTimeLabel.Text = dayAndTime.ToString(Constants.DayAndMonthFormat, new CultureInfo(Constants.EnglishLanguageCode));
            }
            else
            {
                dateAndTimeLabel.Text = dayAndTime.ToString(Constants.DayAndMonthFormat, new CultureInfo(Constants.EnglishLanguageCode)) + " at " + dayAndTime.Hour + Constants.ZerosOfHour;
            }
            
            AddAppointmentsToListBox();
        }

        private void AddAppointmentsToListBox()
        {
            foreach (Appointment appointment in appointments)
            {
                LinkLabel appointmentLink = new LinkLabel();
                appointmentLink.Text = appointment.Title;
                appointmentsListBox.Tag = appointment;
                appointmentsListBox.Items.Add(appointmentLink.Text);
            }
        }

        private void AppointmentslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Constants.DefaultInitialIndex <= appointmentsListBox.SelectedIndex && appointmentsListBox.SelectedIndex < appointments.Count)
            {
                AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(appointments[appointmentsListBox.SelectedIndex]);
                appointmentInformationForm.Show();
            }
        }
    }
}

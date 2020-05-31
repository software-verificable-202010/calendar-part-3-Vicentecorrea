using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CalendarApp.Controllers;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class AppointmentsInDayForm : Form
    {
        private readonly List<Appointment> myAppointments = new List<Appointment>();
        private readonly List<Appointment> invitedAppointments = new List<Appointment>();
        private readonly CalendarForm calendar;
        public AppointmentsInDayForm(List<Appointment> appointmentsInDay, DateTime dayAndTime, CalendarForm calendarForm)
        {
            InitializeComponent();
            this.calendar = calendarForm;
            SeparateAppointments(appointmentsInDay);
            SetDateAndTimeLabel(dayAndTime);
            AddMyAppointmentsToListBox();
            AddInvitedAppointmentsToListBox();
        }

        private void SetDateAndTimeLabel(DateTime dayAndTime)
        {
            if (dayAndTime == dayAndTime.Date)
            {
                dateAndTimeLabel.Text = dayAndTime.ToString(Constants.DayAndMonthFormat, new CultureInfo(Constants.EnglishLanguageCode));
            }
            else
            {
                dateAndTimeLabel.Text = string.Format("{0} at {1}:00", dayAndTime.ToString(Constants.DayAndMonthFormat, new CultureInfo(Constants.EnglishLanguageCode)), dayAndTime.Hour);
            }
        }

        private void SeparateAppointments(List<Appointment> appointmentsInDay)
        {
            foreach (Appointment appointment in appointmentsInDay)
            {
                if (appointment.OwnerUsername.Equals(UserController.LoggedUsername))
                {
                    myAppointments.Add(appointment);
                }
                else
                {
                    invitedAppointments.Add(appointment);
                }
            }
        }

        private void AddMyAppointmentsToListBox()
        {
            foreach (Appointment appointment in myAppointments)
            {
                LinkLabel appointmentLink = new LinkLabel();
                appointmentLink.Text = appointment.Title;
                myAppointmentsListBox.Tag = appointment;
                myAppointmentsListBox.Items.Add(appointmentLink.Text);
            }
        }

        private void AddInvitedAppointmentsToListBox()
        {
            foreach (Appointment appointment in invitedAppointments)
            {
                LinkLabel appointmentLink = new LinkLabel();
                appointmentLink.Text = appointment.Title;
                invitedAppointmentsListBox.Tag = appointment;
                invitedAppointmentsListBox.Items.Add(appointmentLink.Text);
            }
        }

        private void MyAppointmentslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Constants.DefaultInitialIndex <= myAppointmentsListBox.SelectedIndex && myAppointmentsListBox.SelectedIndex < myAppointments.Count)
            {
                AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(myAppointments[myAppointmentsListBox.SelectedIndex], calendar, this);
                appointmentInformationForm.Show();
            }
        }

        private void InvitedAppointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Constants.DefaultInitialIndex <= invitedAppointmentsListBox.SelectedIndex && invitedAppointmentsListBox.SelectedIndex < invitedAppointments.Count)
            {
                AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(invitedAppointments[invitedAppointmentsListBox.SelectedIndex], calendar, this);
                appointmentInformationForm.Show();
            }
        }
    }
}

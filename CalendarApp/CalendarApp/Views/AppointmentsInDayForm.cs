﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CalendarApp.Controllers;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class AppointmentsInDayForm : Form
    {
        #region Fields
        private readonly List<Appointment> myAppointments = new List<Appointment>();
        private readonly List<Appointment> invitedAppointments = new List<Appointment>();
        private readonly CalendarForm calendar;
        private readonly AppointmentController appointmentController;
        private readonly UserController userController;
        #endregion

        #region Methods
        public AppointmentsInDayForm(List<Appointment> appointmentsInDay, DateTime dayAndTime, CalendarForm calendarForm, AppointmentController appointmentController, UserController userController)
        {
            InitializeComponent();
            this.calendar = calendarForm;
            if (appointmentsInDay == null)
            {
                throw new ArgumentNullException("appointmentsInDay");
            }
            SeparateAppointments(appointmentsInDay);
            SetDateAndTimeLabel(dayAndTime);
            AddMyAppointmentsToListBox();
            AddInvitedAppointmentsToListBox();
            this.appointmentController = appointmentController;
            this.userController = userController;
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
                if (appointment.OwnerUserName.Equals(UserController.LoggedUserName))
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
                AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(myAppointments[myAppointmentsListBox.SelectedIndex], 
                    calendar, appointmentController, userController, this);
                appointmentInformationForm.Show();
            }
        }

        private void InvitedAppointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Constants.DefaultInitialIndex <= invitedAppointmentsListBox.SelectedIndex && invitedAppointmentsListBox.SelectedIndex < invitedAppointments.Count)
            {
                AppointmentInformationForm appointmentInformationForm = new AppointmentInformationForm(invitedAppointments[invitedAppointmentsListBox.SelectedIndex], 
                    calendar, appointmentController, userController, this);
                appointmentInformationForm.Show();
            }
        }
        #endregion
    }
}

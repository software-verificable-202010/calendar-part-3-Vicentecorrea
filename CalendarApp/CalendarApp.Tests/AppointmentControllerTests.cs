using CalendarApp;
using CalendarApp.Controllers;
using CalendarApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Tests
{
    [TestFixture]
    public class AppointmentControllerTests
    {
        private AppointmentController appointmentController = null;

        [SetUp]
        public void Setup()
        {
            appointmentController = new AppointmentController();
        }

        [TearDown]
        public void TearDown()
        {
            appointmentController = null;
        }

        [Test]
        public void IsAppointmentInThisDay_AppointmentThatStartsThisDay_ReturnsTrue()
        {
            // Arange
            DateTime appointmentInputStartDate = new DateTime(2020, 6, 4, 17, 32, 11);
            DateTime appointmentInputEndDate = new DateTime(2020, 6, 5, 3, 49, 18);
            List<string> guestUserNamesInput = new List<string>();
            Appointment appointmentInput = new Appointment("Title", "Description", appointmentInputStartDate, appointmentInputEndDate, "Juan", guestUserNamesInput);
            DateTime dayInput = new DateTime(2020, 6, 4);

            // Act
            bool result = AppointmentController.IsAppointmentInThisDay(appointmentInput, dayInput);

            // Assert
            Assert.IsTrue(result, string.Format("The appointment is not on {0}", dayInput.ToString()));
        }

        [Test]
        public void IsAppointmentInThisDayAndTime_AppointmentAndDatetime_ReturnsTrue()
        {
            // Arange
            DateTime appointmentInputStartDate = new DateTime(2020, 6, 17, 10, 30, 0);
            DateTime appointmentInputEndDate = new DateTime(2020, 6, 17, 21, 45, 30);
            List<string> guestUserNamesInput = new List<string>();
            Appointment appointmentInput = new Appointment("Title", "Description", appointmentInputStartDate, appointmentInputEndDate, "Pedro", guestUserNamesInput);
            DateTime dayAndTimeInput = new DateTime(2020, 6, 17, 18, 51, 26);

            // Act
            bool result = AppointmentController.IsAppointmentInThisDayAndTime(appointmentInput, dayAndTimeInput);

            // Assert
            Assert.IsTrue(result, string.Format("The appointment is not at {0} on {1}", dayAndTimeInput.Hour.ToString(), dayAndTimeInput.Date.ToString()));
        }

        [Test]
        public void LoggedUserCanSeeThisAppointment_AppointmentInWhichUserIsInvited_ReturnsTrue()
        {
            // Arange
            User loggedUser = new User("Diego");
            UserController.LoggedUserName = loggedUser.UserName;

            DateTime appointmentInputStartDate = new DateTime(2020, 6, 17, 10, 30, 0);
            DateTime appointmentInputEndDate = new DateTime(2020, 6, 17, 21, 45, 30);
            List<string> guestUserNamesInput = new List<string> { "Ignacia", "Diego", "Pepe" };
            Appointment appointmentInput = new Appointment("Title", "Description", appointmentInputStartDate, appointmentInputEndDate, "Alberto", guestUserNamesInput);

            // Act
            bool result = AppointmentController.LoggedUserCanSeeThisAppointment(appointmentInput);

            // Assert
            Assert.IsTrue(result, string.Format("The logged in user {0} can't see the appointment {1}", UserController.LoggedUserName, appointmentInput.Title));
        }

        [Test]
        public void GetUserNameAppointments_InvitedAndOwnAppointments_ReturnsListOfAppointments()
        {
            // Arange
            string userNameInput = "Pedro";
            DateTime appointmentDefaultStartDate = new DateTime(2020, 11, 11);
            DateTime appointmentDefaultEndDate = new DateTime(2020, 11, 11);
            AppointmentController.Appointments = new List<Appointment>();
            List<string> ownerUserNames = new List<string> { userNameInput, "Juan", "Diego" };
            List<string> guestListOfUserNameInput = new List<string> { "Fernanda", "Francisca", "Diego" };
            List<string> guestListOfJuan = new List<string> { "Fernanda" };
            List<string> guestListOfDiego = new List<string> { "Francisca", userNameInput };
            List<List<string>> guestUserNames = new List<List<string>> { guestListOfUserNameInput, guestListOfJuan, guestListOfDiego };
            for (int index = Constants.DefaultInitialIndex; index < ownerUserNames.Count; index++)
            {
                Appointment appointmentInput = new Appointment("Title", "Description", appointmentDefaultStartDate, appointmentDefaultEndDate, ownerUserNames[index], guestUserNames[index]);
                AppointmentController.Appointments.Add(appointmentInput);
            }

            int FirstAppointmentIndex = 0;
            int ThirdAppointmentIndex = 2;
            List<Appointment> appointmentsForUserNameInput = new List<Appointment> { AppointmentController.Appointments[FirstAppointmentIndex], AppointmentController.Appointments[ThirdAppointmentIndex] };

            // Act
            List<Appointment> result = AppointmentController.GetUserNameAppointments(userNameInput);

            // Assert
            Assert.AreEqual(appointmentsForUserNameInput, result, string.Format("These are not the appointments in which {0} participates", userNameInput));
        }

        [Test]
        public void GetErrorFeedbackTextCreatingAppointmentWithWrongValues_AllWrongValues_ReturnsExpectedText()
        {
            // Arange
            bool appointmentHasTitle = false;
            bool appointmentHasDescription = false;
            bool appointmentEndDateIsLaterThanStartDate = false;
            string expectedErrorFeedbackText = string.Format("The appointment must have a title{0}The appointment must have a description{1}The end date must be later than the start date",
                Environment.NewLine, Environment.NewLine);

            // Act 
            string result = AppointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongValues(appointmentHasTitle, appointmentHasDescription, appointmentEndDateIsLaterThanStartDate);

            // Assert
            Assert.AreEqual(expectedErrorFeedbackText, result);
        }

        [Test]
        public void GetErrorFeedbackTextCreatingAppointmentWithWrongGuests_ListOfUserNames_ReturnsExpectedText()
        {
            // Arange
            List<string> userNamesThatCannotBeInvitedToAppointment = new List<string> { "Juan", "Ignacia", "Max" };
            string expectedErrorFeedbackText = string.Format("The following users cannot be invited to your appointment because they have a time collision with another appointment:{0}- Juan{1}- Ignacia{2}- Max{3}",
                Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine);

            // Act
            string result = AppointmentController.GetErrorFeedbackTextCreatingAppointmentWithWrongGuests(userNamesThatCannotBeInvitedToAppointment);

            // Assert
            Assert.AreEqual(expectedErrorFeedbackText, result);
        }

        [Test]
        public void CanTheUserBeInvitedToAppointment_UserNameAndAppointment_ReturnsTrue()
        {
            // Arange
            string userNameInput = "Juan";
            DateTime appointmentDefaultStartDate = new DateTime(2020, 8, 10, 20, 34, 11);
            DateTime appointmentDefaultEndDate = new DateTime(2020, 8, 11, 7, 12, 56);
            List<string> guestUserNames = new List<string> { "Ignacio", "Antonia", userNameInput };
            Appointment defaultAppointment = new Appointment("Title", "Description", appointmentDefaultStartDate, appointmentDefaultEndDate, "Diego", guestUserNames);

            AppointmentController.Appointments = new List<Appointment> { defaultAppointment };

            DateTime appointmentInDoubtStartDate = new DateTime(2020, 8, 11, 8, 44, 10);
            DateTime appointmentInDoubtEndDate = new DateTime(2020, 8, 11, 13, 52, 36);
            List<string> guestUserNamesOfAppointmentInDoubt = new List<string>();
            Appointment appointmentInDoubt = new Appointment("Title", "Description", appointmentInDoubtStartDate, appointmentInDoubtEndDate, "Alberto", guestUserNamesOfAppointmentInDoubt);

            // Act
            bool result = AppointmentController.CanTheUserBeInvitedToAppointment(userNameInput, appointmentInDoubt);

            // Assert
            Assert.IsTrue(result, string.Format("The user {0} cannot be invited to the appointment {1} due to a time collision", userNameInput, appointmentInDoubt.Title));
        }

        [Test]
        public void GetUserNamesThatCannotBeInvitedToAppointment_PossibleUserNamesAndAppointment_ReturnsListOfUserNames()
        {
            // Arange
            DateTime appointmentDefaultStartDate = new DateTime(2020, 8, 10, 20, 34, 11);
            DateTime appointmentDefaultEndDate = new DateTime(2020, 8, 11, 7, 12, 56);
            List<string> guestUserNames = new List<string> { "Ignacio", "Antonia", "Juan" };
            Appointment defaultAppointment = new Appointment("Title", "Description", appointmentDefaultStartDate, appointmentDefaultEndDate, "Diego", guestUserNames);

            AppointmentController.Appointments = new List<Appointment> { defaultAppointment };

            DateTime appointmentInDoubtStartDate = new DateTime(2020, 8, 10, 8, 41, 16);
            DateTime appointmentInDoubtEndDate = new DateTime(2020, 8, 10, 23, 12, 46);
            List<string> guestUserNamesOfAppointmentInDoubt = new List<string>();
            Appointment appointmentInDoubt = new Appointment("Title", "Description", appointmentInDoubtStartDate, appointmentInDoubtEndDate, "Alberto", guestUserNamesOfAppointmentInDoubt);

            List<string> possibleUserNames = new List<string> { "Francisca", "Ignacio", "Diego", "Antonia", "Pedro", "Juan" };
            List<string> expectedUserNamesWhoCannotBeInvitedToAppointment = new List<string> { "Ignacio", "Diego", "Antonia", "Juan" };

            // Act
            List<string> result = AppointmentController.GetUserNamesThatCannotBeInvitedToAppointment(possibleUserNames, appointmentInDoubt);

            // Assert
            Assert.AreEqual(expectedUserNamesWhoCannotBeInvitedToAppointment, result);
        }

        [Test]
        public void GetAppointmentsInThisDay_Date_ReturnsListOfAppointments()
        {
            // Arange
            User loggedUser = new User("Antonia");
            UserController.LoggedUserName = loggedUser.UserName;

            DateTime firstAppointmentDefaultStartDate = new DateTime(2020, 8, 16, 20, 34, 11);
            DateTime firstAppointmentDefaultEndDate = new DateTime(2020, 8, 17, 7, 12, 56);
            List<string> firstGuestUserNames = new List<string> { "Ignacio", "Antonia", "Juan" };
            Appointment firstDefaultAppointment = new Appointment("Title", "Description", firstAppointmentDefaultStartDate, firstAppointmentDefaultEndDate, "Diego", firstGuestUserNames);

            DateTime secondAppointmentDefaultStartDate = new DateTime(2020, 8, 17, 2, 12, 51);
            DateTime secondAppointmentDefaultEndDate = new DateTime(2020, 8, 18, 19, 32, 53);
            List<string> secondGuestUserNames = new List<string>();
            Appointment secondDefaultAppointment = new Appointment("Title", "Description", secondAppointmentDefaultStartDate, secondAppointmentDefaultEndDate, "Ignacio", secondGuestUserNames);

            AppointmentController.Appointments = new List<Appointment> { firstDefaultAppointment, secondDefaultAppointment };
            List<Appointment> expectedAppointmentsInThisDay = new List<Appointment> { firstDefaultAppointment };

            DateTime dayInDoubt = new DateTime(2020, 8, 17);

            // Act
            List<Appointment> result = AppointmentController.GetAppointmentsInThisDay(dayInDoubt);

            // Assert
            Assert.AreEqual(expectedAppointmentsInThisDay, result);
        }

        [Test]
        public void GetAppointmentsInThisDayAndTime_Datetime_ReturnsListOfAppointments()
        {
            // Arange
            User loggedUser = new User("Ignacio");
            UserController.LoggedUserName = loggedUser.UserName;

            DateTime firstAppointmentDefaultStartDate = new DateTime(2020, 10, 16, 20, 34, 11);
            DateTime firstAppointmentDefaultEndDate = new DateTime(2020, 10, 19, 7, 12, 56);
            List<string> firstGuestUserNames = new List<string> { "Antonia", "Juan" };
            Appointment firstDefaultAppointment = new Appointment("Title", "Description", firstAppointmentDefaultStartDate, firstAppointmentDefaultEndDate, "Ignacio", firstGuestUserNames);

            DateTime secondAppointmentDefaultStartDate = new DateTime(2020, 8, 11, 2, 12, 51);
            DateTime secondAppointmentDefaultEndDate = new DateTime(2020, 8, 11, 19, 32, 53);
            List<string> secondGuestUserNames = new List<string>();
            Appointment secondDefaultAppointment = new Appointment("Title", "Description", secondAppointmentDefaultStartDate, secondAppointmentDefaultEndDate, "Antonia", secondGuestUserNames);

            DateTime thirdAppointmentDefaultStartDate = new DateTime(2020, 8, 11, 10, 12, 00);
            DateTime thirdAppointmentDefaultEndDate = new DateTime(2020, 8, 12, 3, 42, 15);
            List<string> thirdGuestUserNames = new List<string> { "Fernanda", "Ignacio", "Pedro" };
            Appointment thirdDefaultAppointment = new Appointment("Title", "Description", thirdAppointmentDefaultStartDate, thirdAppointmentDefaultEndDate, "Diego", thirdGuestUserNames);

            AppointmentController.Appointments = new List<Appointment> { firstDefaultAppointment, secondDefaultAppointment, thirdDefaultAppointment };
            List<Appointment> expectedAppointmentsInThisDayAndTime = new List<Appointment> { thirdDefaultAppointment };

            DateTime datetimeInDoubt = new DateTime(2020, 8, 11, 15, 30, 00);

            // Act
            List<Appointment> result = AppointmentController.GetAppointmentsInThisDayAndTime(datetimeInDoubt);

            // Assert
            Assert.AreEqual(expectedAppointmentsInThisDayAndTime, result);
        }
    }
}
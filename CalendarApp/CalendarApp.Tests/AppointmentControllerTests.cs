using CalendarApp.Controllers;
using CalendarApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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
        [Category("Simple Tests")]
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

            // Asert
            Assert.IsTrue(result, string.Format("The appointment is not in the day {0}", dayInput.ToString()));
        }
    }
}
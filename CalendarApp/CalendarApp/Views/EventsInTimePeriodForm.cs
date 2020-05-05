using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarApp.Models;

namespace CalendarApp.Views
{
    public partial class EventsInTimePeriodForm : Form
    {
        List<Event> events = new List<Event>();
        public EventsInTimePeriodForm(List<Event> eventsInTimePeriod)
        {
            InitializeComponent();
            events = eventsInTimePeriod;
            AddEventsToListBox();


        }

        private void AddEventsToListBox()
        {
            foreach (Event cellEvent in events)
            {
                LinkLabel eventLink = new LinkLabel();
                eventLink.Text = cellEvent.Title;
                eventsListBox.Tag = cellEvent;
                eventsListBox.Items.Add(eventLink.Text);
            }
        }

        private void EventslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(events[eventsListBox.SelectedIndex].Description);
            EventInformationForm eventInformationForm = new EventInformationForm(events[eventsListBox.SelectedIndex]);
            eventInformationForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public partial class EventListForm : Form
    {
        private EventList events;
        public Event theEvent;
        public List<Event> displayedEvents;
        public List<Event> eventInfo;
        private Event selectedEvent;

        public EventListForm()
        {

        }

        public EventListForm(EventList events)
        {
            InitializeComponent();
            this.events = events;
            events.SortByDate();
            displayedEvents = events.events;
            displayEvents();
            populatePerformer();
        }

        private void populatePerformer()
        {
            HashSet<Performer> performers = new HashSet<Performer>();

            foreach (Event e in displayedEvents)
            {
                performers.Add(e.Performer);
            }
            cmbPerformers.Items.AddRange(performers.ToArray());
        }

        private void displayEvents()
        {
            lstEvents.Items.Clear();            
            lstEvents.Items.AddRange(displayedEvents.ToArray());
        }
        
        public void UpdateForm()
        {
            try
            {
                if (selectedEvent != null)
                {
                    txtTitle.Text = selectedEvent.Title;
                    lblPerformer.Text = selectedEvent.Performer.ToString();
                    lblTickets.Text = selectedEvent.NumAvailableTickets.ToString();
                    dtpDate.Value = selectedEvent.EventTime;
                    dtpTime.Value = selectedEvent.EventTime;
                    grpEventDetail.Visible = true;
                }
                if (rbtDate.Checked)
                    events.SortByDate();
                else if (rbtTitle.Checked)
                    events.SortByTitle();
                if (chkOpenShows.Checked)
                    displayedEvents = events.OpenShows();
                string performerName = null;
                if (cmbPerformers.SelectedIndex >= 0)
                {
                    performerName = cmbPerformers.SelectedItem.ToString();

                    displayedEvents = events.SearchByPerformer(performerName);
                }
                else
                    displayedEvents = events.events;
                displayEvents();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please use numbers only.");
            }
            finally
            {
                EventDB.SaveEvents(events);
            }
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex >= 0)
                selectedEvent = (Event)lstEvents.SelectedItem;
            else
                selectedEvent = null;
            UpdateForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                selectedEvent.Title = txtTitle.Text;
                DateTime eventDate = dtpDate.Value;
                DateTime eventTime = dtpTime.Value;

                selectedEvent.EventTime = new DateTime(eventDate.Year, eventDate.Month, eventDate.Day, eventTime.Hour, eventTime.Minute, 0);
                UpdateForm();
            }
        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                TicketSales sellTickets = new TicketSales(selectedEvent);
                sellTickets.ShowDialog();
            }
            UpdateForm();
        }

        private void chkOpenShows_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void rbtDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void rbtPerformer_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void rbtTitle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cmbPerformers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            displayedEvents = events.events;
            events.Sort();
            cmbPerformers.SelectedIndex = -1;
            chkOpenShows.Checked = false;
            rbtDate.Checked = false;
            rbtTitle.Checked = false;
            grpEventDetail.Visible = false;
            selectedEvent = null;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            new EventDetail(this).Visible = true;
        }

        public void SaveEvent(Event e)
        {
            events.AddEvent(e);
            UpdateForm();
            populatePerformer();
            EventDB.SaveEvents(events);
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DeleteForm(this, events).Visible = true;
            DeleteEventInfo(selectedEvent);
        }

        public void DeleteEventInfo(Event selectedEvent)
        {
            EventDB.SaveEvents(events);
        }

        private void EventListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventDB.SaveEvents(events);
        }
    }

}
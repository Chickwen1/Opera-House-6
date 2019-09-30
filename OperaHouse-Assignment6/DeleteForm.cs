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
    public partial class DeleteForm : Form
    {
        private EventList events;
        private Event selectedEvent;

        EventListForm parent;
        public DeleteForm(EventListForm parent, EventList events)
        {
            InitializeComponent();
            this.parent = parent;
            this.events = events;
            DeleteEvents();
        }

        public void DeleteEvents()
        {
            lstDeleteEvents.Items.Clear();
            lstDeleteEvents.Items.AddRange(events.events.ToArray());
        }

        private void lstDeleteEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDeleteEvents.SelectedIndex >= 0)
                selectedEvent = (Event)lstDeleteEvents.SelectedItem;
            else
                selectedEvent = null;
            events.RemoveEvent(selectedEvent);
            DeleteEvents();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            parent.UpdateForm();
            this.Close();
        }
    }
}


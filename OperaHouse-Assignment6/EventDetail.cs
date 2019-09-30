using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouse_Assignment6
{
    public partial class EventDetail : Form
    {
        EventListForm parent;
        string title;
        int duration = 0;
        int numTickets = 0;
        double ticketPrice = 0;
        Performer p;
        DateTime eventDate;
        DateTime eventTime;
        DateTime comboTime;


        public EventDetail(EventListForm parent)
        {
            this.parent = parent;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            p = new Performer(txtPerformerName.Text, 0);
            Stage stage = null;
            eventDate = dtpDate.Value;
            eventTime = dtpTime.Value;
            comboTime = new DateTime(eventDate.Year, eventDate.Month, eventDate.Day, eventTime.Hour, eventTime.Minute, 0);
            parent.SaveEvent(new Event("", title, p, numTickets, ticketPrice, comboTime, duration, chkConcession.Checked, stage));
            this.Close();
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                duration = int.Parse(txtDuration.Text);
            }

            catch(FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            }
        }

        private void txtNumTickets_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                numTickets = int.Parse(txtNumTickets.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ticketPrice = double.Parse(txtPrice.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Please use only numbers.");
            }
        }
    }
}

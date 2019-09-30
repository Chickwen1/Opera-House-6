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
    public partial class TicketSales : Form
    {
        public Event theEvent;
        int numTickets = 0;
        public static List<Ticket> ticketList;
        public static List<Ticket> tickets;

        public TicketSales(Event anAvent)
        {
            this.theEvent = anAvent;
            InitializeComponent();

            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }

        private void btnSelll_Click(object sender, EventArgs e)
        {
            theEvent.SellTickets(numTickets);
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            List<int> ticketNums = new List<int>();
           

            //List<Ticket> selectedTickets = (List<Ticket>) lstTickets.SelectedItems.Cast<Ticket>();

            foreach (Ticket t in lstTickets.SelectedItems)
                ticketNums.Add(t.SeatNumber);
            theEvent.ReturnTickets(ticketNums);
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(theEvent.tickets.ToArray());
        }

        private void txtNumTickets_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                numTickets = int.Parse(txtNumTickets.Text);
            }

            catch (FormatException)
            {
                MessageBox.Show("Please use a positive number.");
            }
        }

        private void TicketSales_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

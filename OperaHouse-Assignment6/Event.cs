using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public class Event : IComparable<Event>
    {
        public string id;
        public int totalNumTickets;
        public double regularTicketPrice;

        public string ID { get { return id; } }
        public DateTime EventTime { get; set; }
        public int DurationMinutes { get; set; }
        public string Title { get; set; }
        public Performer Performer { get; set; }
        public Stage Stage { get; set; }

        public bool ConcessionSales { get; set; }

        public int NumAvailableTickets
        {
            get
            {
                int result = 0;
                foreach (Ticket t in tickets)
                {
                    if (!t.Sold)
                        result++;
                }
                return result;
            }
        }

        public List<Ticket> tickets;

        public Event()
        {

        }

        public Event(string id, string title, Performer performer, int numTickets, double ticketPrice, DateTime eventTime, int durationMinutes, bool concessionSales, Stage stage)
        {
            this.id = id;
            this.Title = title;
            this.Performer = performer;
            this.totalNumTickets = numTickets;
            this.regularTicketPrice = ticketPrice;
            this.EventTime = eventTime;
            this.DurationMinutes = durationMinutes;
            this.ConcessionSales = concessionSales;
            this.Stage = stage;
            tickets = new List<Ticket>();
            for (int i = 1; i <= numTickets; i++)
            {
                tickets.Add(new Ticket(i, ticketPrice));

            }
        }

        public override string ToString()
        {
            string result = Title + " by " + Performer + " on " + EventTime.ToShortDateString();
            result += " at " + EventTime.ToShortTimeString() + ". Concessions: ";
            result += ConcessionSales ? "Yes. " : "No. ";
            result += "Tickets available: " + NumAvailableTickets;
            return result;
        }

        public bool IsWeekend()
        {
            if (EventTime.DayOfWeek == DayOfWeek.Sunday || EventTime.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else return false;

        }

        public double ShowExpenses()
        {
            double stageCost = Stage.costPerHour * DurationMinutes / 60.0 + Stage.cleaningFee;
            if (!IsWeekend())
                stageCost *= 0.9;
            return stageCost + Performer.Fee;

        }

        public double Profit()
        {
            return TicketSales() - ShowExpenses();
        }

        public bool Profitable()
        {
            return Profit() > 0;
        }

        public double SellTickets(int numTickets)
        {
            double sales = 0;
            int numSold = 0;
            foreach (Ticket t in tickets)
            {
                if (!t.Sold)
                {
                    sales += t.Price;
                    numSold++;
                    t.Sold = true;

                }
                if (numSold == numTickets)
                    return sales;
            }
            return 0;
        }

        public double ReturnTickets(List<int> ticketNums)
        {
            double result = 0;
            foreach (int i in ticketNums)
            {
                foreach (Ticket t in tickets)
                {
                    if (t.SeatNumber == i && t.Sold)
                    {
                        result += t.Price;
                        t.Sold = false;
                    }
                }
            }
            return result;
        }

        public double TicketSales()
        {
            double result = 0;
            foreach (Ticket t in tickets)
            {
                if (t.Sold)
                    result += t.Price;
            }
            return result;
        }

        //New - students should create
        public bool IsSOldOut
        {
            get
            {
                return NumAvailableTickets == 0;
            }
        }

        public int CompareTo(Event e)
        {
            return this.EventTime.CompareTo(e.EventTime);
        }
    }
}



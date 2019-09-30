using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public class Ticket
    {
        //public Event theEvent;
        public int SeatNumber {get;set;}
        public double Price { get; set; }
        public bool Sold { get; set; }

        public Ticket()
        {

        }

        public Ticket(int seatNumber, double price)
        {
            this.SeatNumber = seatNumber;
            this.Price = price;
            this.Sold = false;
        }
        public override string ToString()
        {
            return string.Format("#{0} {1:c}. Sold: {2}", SeatNumber, Price, (Sold) ? "Yes" : "No"); 
            
        }
        public string ToCSV(Event sender)
        {
            return ("Event Title: " + sender.Title + "Seat Number: " + SeatNumber + "," + "Ticket Price: " + Price.ToString("C"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace OperaHouse_Assignment6
{
    //[Serializable()]
    public class EventList
    {
        public List<Event> events;
        private List<Ticket> tickets;
        //private List<Event> eventList;
        //public List<Event> Events { get { return events; } }
        //public List<Ticket> Tickets { get { return tickets; } }

        public EventList()
        {
            events = new List<Event>();
            tickets = new List<Ticket>();
        }

        public void AddEvent(Event e)
        {
            events.Add(e);
        }

        public void RemoveEvent(Event e)
        {
            events.Remove(e);
        }

        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }



        public void AddEvent(List<Event> events)
        {
            this.events.AddRange(events);
        }

        //Helper method that returns the IDs of all the events in the order listed in the List 
        //This is for testing purposes only
        public string[] eventIDs()
        {
            string[] ids = new string[events.Count];
            int i = 0;
            foreach (Event e in events)
            {
                ids[i] = e.ID;
                i++;
            }
            return ids;
        }

        public void SortByDate()
        {
            events.Sort(new DateComparer());

        }

        public void SortByTitle()
        {
            events.Sort(new TitleComparer());
        }

        public List<Event> SearchByPerformer(string name)
        {
            List<Event> results = new List<Event>();
            foreach (Event e in events)
            {
                if (e.Performer.Name.Equals(name))
                    results.Add(e);
            }
            return results;
        }

        public List<Event> OpenShows()
        {
            List<Event> results = new List<Event>();
            foreach (Event e in events)
            {
                if (!e.IsSOldOut)
                    results.Add(e);
            }
            return results;
        }

        public void Sort()
        {
            events.Sort();
        }

        public List<Event> ShowsShorterThan(int minutes)
        {
            List<Event> results = new List<Event>();
            foreach (Event e in events)
            {
                if (e.DurationMinutes <= minutes)
                    results.Add(e);
            }
            return results;
        }

        

        
    }
}

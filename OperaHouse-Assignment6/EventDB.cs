using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public class EventDB
    {    
        public EventDB()
        {

        }

        public static EventList AllEvents()
        {
            Event shrek1, shrek2,shrek3, deathShow, belushiShow;
            Stage main, lounge;
            Performer drDeath;
            Performer belushi;
            Performer osawaHigh;
            EventList events;

            main = new Stage("Main Stage", 100, 150);
            lounge = new Stage("The Lounge", 75, 50);

            osawaHigh = new Performer("Osawa High School", 0);
            drDeath = new Performer("Dr Death", 1500);
            belushi = new Performer("Jim Belushi", 3500);

            shrek1 = new Event("1", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 18, 19, 30, 0), 60, true, lounge);
            shrek2 = new Event("4", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 19, 19, 30, 0), 60, true, main);
            shrek3 = new Event("5", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 20, 19, 30, 0), 60, true, main);

            deathShow = new Event("2", "Dr. Death's Musical Adventures", drDeath, 200, 20, new DateTime(2015, 4, 25, 19, 0, 0), 90, true, main);
            belushiShow = new Event("3", "Belushi and the Board of Comedy", belushi, 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false, lounge);

            events = new EventList();
            events.AddEvent(new List<Event> { shrek1,shrek2, shrek3, deathShow, belushiShow });

            return events;
        }
        public static void SaveEvents(EventList toSave)
        {
            try
            { 
                TextWriter writer = new StreamWriter("eventfile.xml", false);
                XmlSerializer serializer = new XmlSerializer(typeof(EventList));
                serializer.Serialize(writer, toSave);
                writer.Close();
                writer = new StreamWriter("ticketsales.csv", false);
                foreach(Event e in toSave.events)
                {
                    writer.WriteLine(e.Title + "," + e.TicketSales());
                }
                writer.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("I/O Error occurred while reading: " + e.Message);
            }
        }

        public static EventList GetAllEvents()
        {
            EventList events = null;

            if (File.Exists("eventfile.xml"))
            {
                Stream stream = File.OpenRead("eventfile.xml");
                XmlSerializer deserializer = new XmlSerializer(typeof(EventList));
                events = (EventList)deserializer.Deserialize(stream);
                stream.Close();
            }
            return events;
        }
    }
}


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperaHouse_Assignment6;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OperaTesting
{
    [TestClass]
    public class SortSearchTest
    {
        //string txtFileName = "datafile.txt";
        //string binFileName = "eventfile.bin";

        Event shrek1, shrek2, shrek3, deathShow, belushiShow;
        Stage main, lounge;
        Performer drDeath;
        Performer belushi;
        Performer osawaHigh;
        EventList events;

        [TestInitialize]
        public void SetUp()
        {
            osawaHigh = new Performer("Osawa High School", 0);
            drDeath = new Performer("Dr Death", 1500);
            belushi = new Performer("Jim Belushi", 3500);

            shrek1 = new Event("1", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 18, 19, 30, 0), 60, true, lounge);
            shrek2 = new Event("4", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 19, 19, 30, 0), 60, true, main);
            shrek3 = new Event("5", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 20, 19, 30, 0), 60, true, main);
            deathShow = new Event("2", "Dr. Death's Musical Adventures", drDeath, 200, 20, new DateTime(2015, 4, 25, 19, 0, 0), 90, true, main);
            belushiShow = new Event("3", "Belushi and the Board of Comedy", belushi, 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false, lounge);

            main = new Stage("Main Stage", 100, 150);
            lounge = new Stage("The Lounge", 75, 50);

            events = new EventList();
            events.AddEvent(new List<Event> { shrek1, shrek2, shrek3, deathShow, belushiShow });
        }


        [TestMethod]
        public void TestSortDefaultSort()
        {
            //sort events by date
            events.Sort();

            string[] expected = new string[] { "3", "1", "2" };
            string[] actual = events.eventIDs();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSortByDate()
        {
            //sort events by date
            events.SortByDate();

            string[] expected = new string[] { "3", "1", "2" };
            string[] actual = events.eventIDs();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSortByTitle()
        {
            //sort events by title
            events.SortByTitle();
            string[] expected = new string[] { "3", "2", "1" };
            string[] actual = events.eventIDs();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSortByPerformer()
        {
            //sort events by title
            events.SortByTitle();
            string[] expected = new string[] { "3", "2", "1" };
            string[] actual = events.eventIDs();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSearchPerformer()
        {
            events.AddEvent(new Event("4", "Midsummer Night", osawaHigh, 100, 10, new DateTime(2015, 9, 30, 19, 30, 0), 90, true, main));

            List<Event> osawaEvents = events.SearchByPerformer("Osawa High School");

            string[] expected = new string[] { "1", "4" };
            string[] actual = eventIDs(osawaEvents);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSoldOutShow()
        {
            deathShow.SellTickets(200); //sell out show
            belushiShow.SellTickets(10); //sell some tickets

            Assert.IsTrue(deathShow.IsSOldOut);
            Assert.IsFalse(belushiShow.IsSOldOut);
            Assert.IsFalse(shrek1.IsSOldOut);
        }

        [TestMethod]
        public void TestShortShows()
        {
            List<Event> shortShows = events.ShowsShorterThan(100); //Get shows shorter than 100 minutes

            string[] expected = new string[] { "1", "2" };
            string[] actual = eventIDs(shortShows);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAvailableTickets()
        {
            deathShow.SellTickets(200); //sell out show

            List<Event> openShows = events.OpenShows();

            string[] expected = new string[] { "1", "3" };
            string[] actual = eventIDs(openShows);

            CollectionAssert.AreEqual(expected, actual);
        }

        //Helper method that returns the IDs of all the events in the order listed in the List 
        //This is for testing purposes only
        private string[] eventIDs(List<Event> events)
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
        [TestMethod]
        public void TestSerialization()
        {
            EventList testEvent = new EventList();
            testEvent = events;
            EventDB.SaveEvents(events);
            testEvent = EventDB.GetAllEvents();
            //Assert.AreEqual(5, events);
            //Assert.AreEqual(5, testEvent);
            Assert.AreEqual(testEvent.events[0].ToString(), events.events[0].ToString());
        }
    }

}

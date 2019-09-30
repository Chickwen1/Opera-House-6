using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperaHouse_Assignment6
{
    public class TitleComparer:IComparer<Event>
    {
        public int Compare(Event e1, Event e2)
        {
            return e1.Title.CompareTo(e2.Title);
        }
    }
}

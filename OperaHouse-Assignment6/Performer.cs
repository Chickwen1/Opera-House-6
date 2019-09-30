using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public class Performer
    {
        public string Name { get; set; }
        public double Fee { get; set; }

        public Performer()
        {

        }

        public Performer(string name, double fee)
        {
            this.Name = name;
            this.Fee = fee;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
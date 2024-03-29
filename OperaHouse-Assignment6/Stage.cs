﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment6
{
    [Serializable()]
    public class Stage
    {
        public string StageName { get; set; }
        public double costPerHour { get; set; }
        public double cleaningFee { get; set; }

        public Stage()
        {

        }

        public Stage(string name, double hourlyRate, double cleaningFee)
        {
            this.StageName = name;
            this.costPerHour = hourlyRate;
            this.cleaningFee = cleaningFee;
        }

        public override string ToString()
        {
            return StageName;
        }
    }
}
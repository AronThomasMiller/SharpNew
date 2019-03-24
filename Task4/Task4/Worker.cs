using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Worker
    {
        public abstract double HourRate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double BaseHourRate { get; set; }
        public Worker(string FirstName, string LastName, double BaseHourRate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BaseHourRate = BaseHourRate;
        }
    }
}

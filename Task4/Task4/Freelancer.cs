using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Freelancer : Worker
    {
        public Freelancer(string FirstName, string LastName, double BaseHourRate) : base(FirstName, LastName, BaseHourRate) { }
        public override double HourRate { get => BaseHourRate * 1.5; set { } }
    }
}

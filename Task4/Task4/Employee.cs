using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Employee : Worker
    {
        public Employee(string FirstName, string LastName, double BaseHourRate) : base(FirstName, LastName, BaseHourRate) { }
        public override double HourRate {get => BaseHourRate * 1.1; set { } }
    }
}

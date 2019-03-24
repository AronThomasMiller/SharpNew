using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int HourRate {get;set;}
        public Person (string Name, int Age, int HourRate)
        {
            this.Name = Name;
            this.Age = Age;
            this.HourRate = HourRate;
        }
        public int GetOverallSalary()
        {
            if (Age < 18)
            {
                return 0;
            }
            else return (DateTime.Now.Day * 8 * HourRate);
        }
    }
}

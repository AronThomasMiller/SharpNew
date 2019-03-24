using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class AgeStatisticProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> people)
        {
            var maxAge = people.Max(obj => obj.Age);
            foreach (var person in people)
            {
                if ( person.Age == maxAge)
                {
                    Console.WriteLine("Maximum age has " + person.Name);
                }
            }
            var minAge = people.Min(obj => obj.Age);
            foreach (var person in people)
            {
                if (person.Age == minAge)
                {
                    Console.WriteLine("Minimum age has " + person.Name);
                }
            }
            int sumAge = 0;
            foreach (var person in people)
            {
                sumAge += person.Age;
            }
            sumAge /= people.Count();
            Console.WriteLine("Average age has " + sumAge);
        }
    }
}

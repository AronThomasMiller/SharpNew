using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public  class SalaryProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> people)
        {
            var suitablePersons = people.Where(c => c.Age >= 18);
            foreach (var person in suitablePersons)
            {
                Console.WriteLine(person.ToString());
            }
            var highestRate = suitablePersons.Max(c => c.HourRate);
            var highlyPayedPerson = suitablePersons.Where(c => c.HourRate == highestRate);
            Console.WriteLine("Highly payed person");
            foreach (var person in highlyPayedPerson)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

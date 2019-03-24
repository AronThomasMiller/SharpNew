using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class NamesProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> people)
        {
            var names = people.DistinctBy(c => c.Name).Select(c => c.Name);
            foreach (var name in names)
            {
                var counter = 0;
                foreach (var person in people)
                {
                    if (person.Name == name)
                    {
                        counter++;
                    }
                }
                var res = ((counter * 100)/people.Count());
                Console.WriteLine($"Name : {name}, {res} %");
            }
        }
    }
}

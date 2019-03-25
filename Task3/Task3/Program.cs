using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Person> people = new Person[]
            {
                new Person("Anton", 18, 100),
                new Person("Anton", 18, 100),
                new Person("Vlad", 20, 200),
                new Person("Anna", 16, 200),
                new Person("Sveta", 30, 300),
                new Person("Dima", 38, 50),
                new Person("Petro", 68, 150)
            };
            var salaryProcessor = new SalaryProcessor();
            salaryProcessor.Process(people);
            var ageStatisticProcessor = new AgeStatisticProcessor();
            ageStatisticProcessor.Process(people);
            var nameProcessor = new NamesProcessor();
            nameProcessor.Process(people);
        }
    }
}

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
            foreach (var person in people)
            {
                Console.WriteLine(" Name: " +person.Name + " Age " + person.Age + " Salary per this month " + person.GetOverallSalary() );
                if (person.GetOverallSalary() > 2000)
                {
                    Console.WriteLine("Major");
                }
                else Console.WriteLine("Middle payed");
            }
        }
    }
}

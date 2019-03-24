using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PersonsGenerator personsGenerator = new PersonsGenerator();
            var people = personsGenerator.Generate(50);
            foreach (var result in people)
            {
                result.GetPersonInfo();
            }
        }
    }
}

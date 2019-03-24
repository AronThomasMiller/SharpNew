using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class WorkerGenerator
    {
        public string RandomFirstName()
        {
            string[] firstNames = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian", "abby", "abigail", "adele", "adrian" };
            Random rand = new Random();
            return firstNames[rand.Next(0, firstNames.Length - 1)];
        }
        public string RandomLastName()
        {
            string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar" };
            Random rand = new Random();
            return lastNames[rand.Next(0, lastNames.Length - 1)];
        }
        public int RandomHourRate()
        {
            Random rand = new Random();
            return rand.Next(100);
        }
        public List<Worker> Generate(int amount)
        {
            List<Worker> people = new List<Worker>();
            for (int i = 0; i < amount; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("EMPLOYEE: ");
                    Worker obj = new Employee(RandomFirstName(), RandomLastName(), RandomHourRate());
                    people.Add(obj);
                    Console.WriteLine($"Name {obj.FirstName}, {obj.LastName}. HourRate: {obj.HourRate}.");
                    Thread.Sleep(100);
                    Console.WriteLine();
                }
                else if (i % 3 == 1)
                {
                    Console.Write("SUBCONTRACTOR: ");
                    Worker obj = new Subcontractor(RandomFirstName(), RandomLastName(), RandomHourRate());
                    people.Add(obj);
                    Console.WriteLine($"Name {obj.FirstName}, {obj.LastName}. HourRate: {obj.HourRate}.");
                    Thread.Sleep(100);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("FREELANCER: ");
                    Worker obj = new Freelancer(RandomFirstName(), RandomLastName(), RandomHourRate());
                    people.Add(obj);
                    Console.WriteLine($"Name {obj.FirstName}, {obj.LastName}. HourRate: {obj.HourRate}.");
                    Thread.Sleep(100);
                    Console.WriteLine();
                }
            }
            return people;
        }
    }
}

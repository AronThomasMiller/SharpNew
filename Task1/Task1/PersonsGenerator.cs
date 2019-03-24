using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class PersonsGenerator
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
        public DateTime RandomDay()
        {
            Random rand = new Random();
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }
        public List<Person> Generate(int amount)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < amount; i++)
            {
                Person obj = new Person();
                obj.FirstName = RandomFirstName();
                obj.LastName = RandomLastName();
                obj.HourRate = RandomHourRate();
                obj.BirthDate = RandomDay();
                people.Add(obj);
                Thread.Sleep(500);
            }
            return people;
        }
    }
}


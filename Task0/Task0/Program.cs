using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
    public class Program
    {
        public static DateTime RandomDay(DateTime d1 , DateTime d2)
        {
            Random rand = new Random();
            int range = (d2 - d1).Days;
            return d1.AddDays(rand.Next(range));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RandomDay(new DateTime(1950, 01, 1), new DateTime(2019, 03, 23)));
        }
    }
}

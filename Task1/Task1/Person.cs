using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HourRate { get; set; }
        public int Age => DateTime.Now.Year - BirthDate.Year;
        public string FullName => FirstName + " " + LastName;
        public void GetPersonInfo()
        {
            Console.WriteLine("FullName : " + FullName + " " + "Age : " +  Age + " Salary" + GetSalary() );
        }
        public decimal GetSalary ()
        {
            if (Age < 18)
            {
                return 0;
            }
            else return (160 * HourRate);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class PersonsProcessor
    {
        public abstract void Process(IEnumerable<Person> people);
    }
}

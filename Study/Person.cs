using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Person
    {
        public string Name
        {
            get;
            private set;
        }

        public Person(string name)
        {
            Name = name;
        }
    }
}

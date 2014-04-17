using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
   class MybaseClass
   {
       
        public void Print()
        {
            Console.WriteLine("This is the base class");
        }
    }

    class MyDrivedClass : MybaseClass
        {
           new public void Print()
            {
                Console.WriteLine("This is the derived class");
            }
        }
    
}

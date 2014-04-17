using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class SomeClass
    {

        public string Field1 = "base class field";
        public void Method1(string value)
    {
            Console.WriteLine("Bass class----Method1:{0}",value);
    }

    }

    class OtherClass:SomeClass
    {
        new public string Field1 = "derived class field";//hides the field in the base
     

        public void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }
    }
}

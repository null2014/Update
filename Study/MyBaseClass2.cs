using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class MyBaseClass2
    {
        private int _myInt = 5;
        public virtual int MyProperty {
            get { return _myInt; }
        }
    }

    class MyDrivedClass2:MyBaseClass2
    {
        private int _myInt = 10;
        public override int MyProperty
        {
            get
            {
                return _myInt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class LimitedInt
    {
        const int MaxValue = 100;
        const int MinValue = 0;

        private int _theValue = 0;
        public int TheValue
        {
            get { return _theValue; }
            set {
                if (value < MinValue)
                {
                    _theValue = 0;
                }
                else
                {
                    _theValue = value > MaxValue ? MaxValue : value;
                }
            }
        }
    

        public static implicit operator int(LimitedInt li)
        {
            return li.TheValue;
        }

        public static implicit operator LimitedInt(int x)
        {
            LimitedInt li=new LimitedInt();
            li.TheValue = x;
            return li;
        }

       
        

    }
}

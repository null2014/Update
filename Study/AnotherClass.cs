using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class AnotherClass
    {
        /// <summary>
        /// set的值如果不等于index，，也就是不等于0，那么执行else语句，get输出Temp1的值
        /// </summary>
        int Temp0;
        int Temp1;

        public int this[int index]
        {
            get { return (0 == index) ? Temp0 : Temp1; }
            set {
                if (0 == index)
                {
                    Temp0 = value;
                }
            else
                {
                    Temp1 = value;
                }
            }
        }

    }
}

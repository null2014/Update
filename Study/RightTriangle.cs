using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class RightTriangle
    {
        
            public double A = 3;
            public double B = 4;
            public double Hypoten
            {
                get { return Math.Sqrt( (A * A) + (B * B)); }//Sprt是开平方
            }
        }
    
}

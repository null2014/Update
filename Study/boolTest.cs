using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class boolTest
    {
        public void BoolTest()
        {
            bool thingsAreFine;

            while (true)
            {
                thingsAreFine = GetNuclearReactorCondition();
                if (thingsAreFine)
                {
                    Console.WriteLine("Things are fine");
                }
                else
                {
                    goto NotSoGood;
                }
            }
            NotSoGood:Console.WriteLine("We have a problem");
        }
       
    }
}

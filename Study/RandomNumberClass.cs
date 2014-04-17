using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class RandomNumberClass
    {
        private static Random RandomKey ;//根据时间来随机，每分每秒都不同
        static RandomNumberClass()
        {
            RandomKey =new Random();//Initialize RandomKey
        }

        public int GetRandomNumver()
        {
            return RandomKey.Next();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Study
{
    class DisplayMessage
    {

        public void Display()
        {
            string userMessage = string.Format("100000 in hex is{0:x}", 100000);
            Console.WriteLine(userMessage);
        }

    }
}


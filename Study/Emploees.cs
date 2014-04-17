using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
     class Emploees
    {
        private string empName;
        private int empID;
        private float currPay;
         private int empAge;

         public Emploees(string name, int id, float pay) 
             : this(name,0,id,pay)   {  }

         public Emploees(string name, int age, int id, float pay)
         {
             Name = name;
             ID = id;
             Age = age;
             Pay = pay;
         }

         public string Name {
            get { return empName; }
            set { empName=Name;}
        }

        public int ID {
            get { return empID; }
            set { empID = ID; }
        }

        public float Pay {
            get { return currPay; }
            set { currPay = Pay; }
        }
        public int Age {
            get { return empAge; }
            set { empAge=Age; }
        }
    }
}

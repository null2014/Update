using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Study
{
    class File
    {
       public static int GetHour()
        {
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            return hour;
        }

        public  void TimeUpdate()
        {
            DateTime dt = DateTime.Now;
            if (dt.Hour > 12)
            {
               
                Console.WriteLine("Afternoon");
                return;
                
            }
            else
            {

                Console.WriteLine("Morning");
                return;
            }
        }
        public class MyClass
        {
            public int Val = 20;
        }

        public static void MyMethod(MyClass f1,int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.Val:{0},{1}",f1.Val,f2);
        }

        public static void MyMethodRef(ref MyClass f1, ref int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.Val:{0},f2:{1}",f1.Val,f2);
        }

        public static void RefAsParameter(MyClass f1)
        {
            f1.Val = 50;
            Console.WriteLine("After member assignment:{0}",f1.Val);
            f1=new MyClass();
            Console.WriteLine("After new object creation:{0}",f1.Val);
        }

        public static void RefAsParameterRef(ref MyClass f1)
        {
            f1.Val = 50;
            f1 = new MyClass(); 
        }

      

        public static void AddMethod(out MyClass f1,out int f2)
        {
            f1=new MyClass();
            f1.Val = 25;
            f2 = 15;
        }

        public void ListInts(params int[] inVals)
        {
            if((inVals !=null) && (inVals.Length!=0))
            {
                for (int i = 0; i < inVals.Length; i++)
                {
                    inVals[i] = inVals[i]*10;
                    Console.WriteLine(inVals[i]);
                }
            }
        }

        class A
        {
            long AddValues(int a,int b)    { return a + b;}
            long AddValues(int c, int d, int e) { return c+d+e;}
            long AddValues(float f,float g){return (long)(f+g);}
            long AddValues(long h, long m) { return h+m;}
            //int AddValues(long h, long m) { return h+m;}这个是错误的int 和long不一致
       
        }

        public int Calc(int a, int b, int c)
        {
            return (a + b)*c;
        }

        public void RectArray()
        {
            int[,] myInt;//多维数组
            myInt = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myInt[i, j] = i * j;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myInt[i, j] +"\t");
                    Console.WriteLine();
                }
            }
        }

        public static void Test()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i+"*"+j+"="+i*j+"\t");
                }
                Console.WriteLine("");
            }
        }

        public static void Test1()
        {
            for (int i=1;i<= 9;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+"*"+j+"="+i*j+"\t");
                }
                Console.WriteLine("");
            }
        }

        public static void MultidiArray()
        {
            int[][] myArray=new int[5][];//具有5个不同数组的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i]=new int[i+7];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]+" ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void PrintArray()
        {
        }

        public int Calc(int a,int b=3)
        {
            return a + b;
        }


        //一直减到intVal为0才返回
        public static void Count(int intVal)
        {
            if (intVal == 0)
            {
                return;
            }
            else
            {
               Count(intVal-1);
                Console.WriteLine("{0}",intVal);  
            }
           
            }


        private int TheRealVal = 10;   
        public int MyValue 
        {
             
            set { TheRealVal = value > 100 ?100:value; }//make sure it's not >100
            get { return TheRealVal; }
        }

        public int MyValue2(int Val)
        {
            return Val > 100 ? 100 : Val;
         }

        public int MyValue1 { get; set; }//没有值
        
       
    }

    }


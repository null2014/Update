using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
       
            static void Main(string[] args){
            
            
            //int x = 5;
            //Console.WriteLine((x++) + (x++) + (x++));
            //int y = (x++) + (x++) + (x++);
            //Console.WriteLine(y);
            //Console.ReadLine();
            //int x = 5;
            //int y = x++;
            //Console.WriteLine(y);
           
            //int l = ++x;
            //Console.WriteLine(l);
            //Console.ReadLine();

            //Console.WriteLine(typeof(int));
            //Console.WriteLine(typeof(string));
            //Console.WriteLine(typeof(double[]));

            //int a = 16;
            //int b = a >> 2;
            //Console.WriteLine(b);
            //int c = b >> 2;
            //Console.WriteLine(c);
            //int d = c >> 2;
            //Console.WriteLine(d);
            //Console.ReadLine();


            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 7)  continue;//break 到i=7的时候，直接跳出循环；continue  i=7的时候，不执行下一行，直接进入下一个循环
            //    Console.WriteLine(i);     
            //}

            //ConsoleColor rColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //Console.ForegroundColor = rColor;
           // Window wi=new Window();

                ////冒泡排序
                //int[] source = {23,45,67,89,90,100};
                //for (int i = 0; i < source.Length - 1; i++)
                //{
                //    for (int j = 0; j < source.Length - 1 - i; j++)
                //    {
                //        if (source[j] < source[j + 1])
                //        {
                //            int temp = source[j];
                //            source[j] = source[j + 1];
                //            source[j + 1] = temp;
                //        }
                        
                //    }
                //}
                //for (int i = 0; i < source.Length; i++)
                //{
                //    Console.WriteLine(source[i]);
                //}

               // //i/o             
               //FileStream file=new FileStream(@"d:\temp\test.txt",FileMode.Open);
               // StreamWriter sw=new StreamWriter(file);
               // sw.Write("helloworld");
               // sw.Close();
               // file.Close();

                //Console.WriteLine("This is {0:C}", 500); //{0:c}表示当前货币
                
                 /*
                 This is a test
                 */
               //Console.WriteLine(File.GetHour());

               // //非static方法只能用这种形式
               // File fl=new File();
               // fl.TimeUpdate();
                
               // File.MyClass a1=new File.MyClass();
               // int a2 = 10;
               // File.MyMethod(a1,a2);
               // Console.WriteLine("f1.Val:{0},f2:{1}",a1.Val,a2);
                


               // //ref

               // File.MyClass a3=new File.MyClass();
               // int a4 = 10;
               // File.MyMethodRef(ref a3,ref a4);
               // Console.WriteLine("f1.Val:{0},f2:{1}", a3.Val, a4);
               // Console.ReadLine();


        
               //File.MyClass a5=new File.MyClass();
               //Console.WriteLine("Before method call:{0}",a5.Val);
               // File.RefAsParameter(a5);
               // Console.WriteLine("After method call:{0}",a5.Val);



               // File.MyClass a6=new File.MyClass();
               // int a7;
               // File.AddMethod(out a6,out a7);


               // int first = 5, second = 6, third = 7;
               // File mc=new File();
               //mc.ListInts(first,second,third);

               // File mc1=new File();
               // int result = mc.Calc(c: 2, a: 4, b: 3);//不用管顺序都是abc的相对应
               // Console.WriteLine("{0}",result);


                //File mc2 = new File();
                //mc2.RectArray();


                //File.Test();
                //File.Test1();
                //File fl=new File();
                //fl.Calc(5);//默认b的值为3.输出结果为8
                //fl.Calc(6, 8);//输出为14,将8抵消默认值b
                ////File.MultidiArray();
                //Console.WriteLine();

                //File.Count(3);
               //File fl=new File();
               // Console.WriteLine(fl.MyValue);

              //RightTriangle c=new RightTriangle();
              //  Console.WriteLine(c.Hypoten);
                
              //  File f3=new File();
              //  Console.WriteLine(f3.MyValue1);


                //File f4=new File();
                //f4.MyValue = 201;//set参数到属性
                //Console.WriteLine(f4.MyValue);

                //Emploee a=new Emploee();
                //a.LastName = "Done";
                //a.FirstName = "Jane";

                //File f5=new File();
                //Console.WriteLine(f5.MyValue2(30));

               //RandomNumberClass a=new RandomNumberClass();
               // RandomNumberClass b=new RandomNumberClass();
               // Console.WriteLine("Next Random #{0}",a.GetRandomNumver());
               // Console.WriteLine("Next Radom #{0}",b.GetRandomNumver());

                //Person p = new Person("Bill");
                //Console.WriteLine(p.Name);
                //OtherClass oc=new OtherClass();
                //oc.Method1(oc.Field1);//Base method ： base class field
                //oc.Method1(oc.Field2);//Base method:droved class field
                //oc.Method2(oc.Field2);//Derived method:base class fiedl
                //oc.Method2(oc.Field1);//Derived method :drived class field

               //OtherClass oc=new OtherClass();
               // //Console.WriteLine(oc.Field1);//输出OtherClass 的Field1
               //oc.PrintField1();


               //MyDrivedClass my=new MyDrivedClass();
               // MybaseClass myc = (MybaseClass) my;
               // my.Print();
               // myc.Print();
               // Console.ReadKey();

               // DataReader dr=new DataReader();
               // int? i = dr.GetFromData();//必须有?符号才能调用
               // bool? b = dr.GetBoolData();
               // int myData = dr.GetFromData() ?? 100;//如果myData不为空则为100

               // TimeUtilClass.PrintDate();//不能使用New来创建
               // TimeUtilClass.PrintTime();

               // Car newCar=new Car();//对象用户不知道car类在使用内部radio对象
               // newCar.TurnOnRadio(false);

               // Emploees em=new Emploees();//em不能直接访问empName,empID,curPay私有成员
               // em.Name ="Marry";
               // em.Pay =1000;
               // em.ID = 56;

                //MyDrivedClass2 drivedClass2=new MyDrivedClass2();
                //MyBaseClass2 mybc = (MyBaseClass2) drivedClass2;
                //Console.WriteLine(drivedClass2.MyProperty);
                //Console.WriteLine(mybc.MyProperty);

                //int a, b, x = 14;
                //a = x << 3;
                //b = x >> 3;
                //Console.WriteLine(a);//需要将x 转换成二进制然后移位 112
                //Console.WriteLine(b);//1；

                //int x = 10, y = 9;
                //int highVal = x > y ? x : y;
                //Console.WriteLine("x is {0} greater than y",x>y ?"":"not");//如果x>y,那么是：的左边
                //y = 11;
                //Console.WriteLine("x is {0} greater than y ",x>y?"":"not");//如果x>y 是错的，那么是：的右边


                //LimitedInt li = 500;
                //int value = li;
                
                //Console.WriteLine("li:{0},value:{1}",li.TheValue,value);

                //const int MaxI = 5;
                //for (int i = 0,j=10; i <MaxI ; i++,j+=10)//将i=0,1,2,3,4的时候的j=10,+10,+10
                //{
                //    Console.WriteLine("{0},{1}",i,j);
                //}

                //for (int x = 1; x < 6; x++)
                //{
                //    switch (x)//包含从1-6的case
                //    {
                //        case 2:
                //            Console.WriteLine("{0}",x);
                //            break;
                //        case 5:
                //            Console.WriteLine("{0}",x);
                //            break;
                //        default:
                //            Console.WriteLine("{0} in default case",x);
                //            break;
                //    }
                //}


                for (int i = 0; i < 5; i++)//i<3的时候继续走for循环
                {
                    if (i < 3)
                    {
                        continue;
                    }
                    Console.WriteLine("{0}",i);
                    
                }

                using (TextWriter tw=File.CreateText("d:\temp\t.txt"))
                {
                    
                }
                using (TextReader tr=File.OpenText(""))
                {
                    
                }
                Console.ReadLine();
            }
        
    

    }
}

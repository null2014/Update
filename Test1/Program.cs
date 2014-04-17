using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("请输入操作指令 商品编号 商品数量 eg:input 001 23（input/output/search）");
                string proList = Console.ReadLine();


                try
                {
                    //输入close结束程序
                    if (proList == "close")
                    {
                        flag = false;
                        continue;
                    }


                    string[] lists = Regex.Split(proList, " ", RegexOptions.IgnoreCase);
                    if (lists.Length != 3 && lists[0] !="search")
                    {
                        throw new ArithmeticException("worng paramenter");
                    }

                    
                    switch (lists[0])
                    {
                        case "input":
                            Console.WriteLine("input");
                            break;
                        case "ouput":
                            Console.WriteLine("Output");
                            break;
                        case "search":
                            Console.WriteLine("search");
                            break;
                        default:
                            throw new ArgumentException("nothing to do");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("something is worng:"+e.Message);
                }
            }
        }
    }
}








            
           
                 
           
                
                

            


            
            
            




          
           

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
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
                    if (proList == "close")
                    {
                        flag = false;
                        continue;
                    }
                    string[] lists = Regex.Split(proList, " ", RegexOptions.IgnoreCase);
                    
                    if (lists.Length != 3 && lists[0] != "search")
                    {
                        throw new ArgumentException("Please input right parameter");
                    }
                    //DataTable da = SqlHelper.ExceuteDataTable("select * from GoodsInf where GoodsID='" + GoodsID + "'");


                    //for (int i = 0; i < da.Rows.Count; i++)
                    //{
                    //    int a = Convert.ToInt32(da.Rows[i][0]);

                    //    Console.WriteLine(a);
                    //}

                    //object da = SqlHelper.GetSingle("select * from GoodsInf where GoodsID='" + GoodsID + "'");
                    
                    //定义变量
                    int GoodsID = 0;
                    int GoodsCounts = 0;
                    bool Exist = false;
                    if (lists[0] !="search")
                    {
                       // string Operate = lists[0];
                         GoodsID = Convert.ToInt32(lists[1]);
                         GoodsCounts = Convert.ToInt32(lists[2]);
                         Exist =
                            SqlHelper.Exists("select '" + GoodsID + "' from GoodsInf where GoodsID='" + GoodsID + "'");         
                    }

                   
                    //Console.WriteLine(Exist);

                    switch (lists[0])
                    {
                        case "input":
                            if (GoodsID != null && Exist == false)
                            {
                                SqlHelper.ExecuteNonQuery("insert into GoodsInf(GoodsID,GoodsCounts) values('" + GoodsID +
                                                          "'," +
                                                          GoodsCounts + ")");
                                SqlHelper.ExecuteNonQuery(
                                    "insert into Log(GoodsCounts,DateTime,Operation,GoodsID) values( '" + GoodsCounts +
                                    "',GETDATE(),'input' ,'" + GoodsID + "')");
                                Console.WriteLine("input is successful");
                            }
                            else
                            {

                                SqlHelper.AddGoodsCounts(GoodsID, GoodsCounts);
                                SqlHelper.ExecuteNonQuery(
                                    "insert into Log(GoodsCounts,DateTime,Operation,GoodsID) values( '" + GoodsCounts +
                                    "',GETDATE(),'update' ,'" + GoodsID + "')");
                            }
                            break;
                        case "output":
                            if (GoodsID != null && Exist == true)
                            {
                                SqlHelper.MinusGoodsCounts(GoodsID, GoodsCounts);
                                SqlHelper.ExecuteNonQuery(
                                    "insert into Log(GoodsCounts,DateTime,Operation,GoodsID) values( '" + GoodsCounts +
                                    "',GETDATE(),'output' ,'" + GoodsID + "')");
                                Console.WriteLine("output is successful");
                            }
                            else
                            {
                                Console.WriteLine("GoodsID is not enoght");
                            }
                            break;
                        case "search":

                            Console.WriteLine("\t" + "GoodsID:   GoodsCounts:   Operation:     DateTime:");
                            DataTable search =
                                SqlHelper.ExceuteDataTable("select * from Log ");
                            DataRowCollection rows = search.Rows;
                            for (int i = 0; i < rows.Count; i++)
                            {
                                DataRow row = rows[i];
                                int goodsID = (int) row["GoodsID"];
                                int goodsCounts = (int) row["GoodsCounts"];
                                string operation = (String) row["Operation"];
                                DateTime date = (DateTime) row["DateTime"];

                                Console.WriteLine("\t" + "      {0}        {1}         {2}   {3}", goodsID,
                                    goodsCounts, operation, date);

                            }

                            break;
                        default:
                            throw new ArgumentException("nothing to do");                 
                }
                }
                catch (Exception e)
                {

                    Console.WriteLine("something is worng:" + e.Message);
                }

            }
        }

        public static string GetSql(int count)
        {
            return string.Format("update GoodsInf set GoodsCounts= GoodsCounts +{0} where GoodsID=GoodsID", count);
        }

       

    }
    }


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test
{
    internal class SqlHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;

        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();

                }

            }
        }

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }



        //public static void Insert(ProInf pro)
        //{
        //    SqlHelper.ExecuteNonQuery(@"Insert into ProInf(GoodsID,GoodsCounts) values(@GoodsID,@GoodsCounts)",
        //        new SqlParameter("@GoodsID", pro.GoodsID),
        //        new SqlParameter("@ProCount", pro.GoodsCounts));
        //}

        public static DataTable ExceuteDataTable(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];

                }
            }
        }

        public static bool Exists(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    // object val = cmd.ExecuteScalar();
                    int cmdResult = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cmdResult == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }

            }


        }

        //仅仅返回查询结果集中第一行第一列，而忽略其他行和列
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    object val = cmd.ExecuteScalar();
                    return val;
                }
            }
        }

        public static object GetSingle(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    object bj = cmd.ExecuteScalar();
                    if (bj == null)
                    {
                        return null;
                    }
                    else
                    {
                        return bj;
                    }
                }
            }
        }

        public static SqlDataReader ExceuteReader(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteReader();

                }
            }

        }

        public static void AddGoodsCounts(int GoodsID, int changCounts)
        {

            int lastCount;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select GoodsCounts from GoodsInf where GoodsID=" + GoodsID;
                    int counts = Convert.ToInt32(cmd.ExecuteScalar());
                    lastCount = counts + changCounts;

                    cmd.CommandText = "update GoodsInf set GoodsCounts='" + lastCount + "' where GoodsID=" + GoodsID;
                    cmd.ExecuteNonQuery();

                }

            }
        }

        public static void MinusGoodsCounts(int GoodsID, int lastCount)
        {

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select GoodsCounts from GoodsInf where GoodsID=" + GoodsID;
                    int counts = Convert.ToInt32(cmd.ExecuteScalar());
                    lastCount = counts -lastCount;
                    if (lastCount <0)
                    {
                        Console.WriteLine("GoodsCounts is not enough");
                    }

                    cmd.CommandText = "update GoodsInf set GoodsCounts='" + lastCount + "' where GoodsID=" + GoodsID;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Test()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into GoodsInf(GoodsID,GoodsCounts) values(110,100)";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

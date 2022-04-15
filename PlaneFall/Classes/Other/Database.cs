using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneFall.Classes.Other
{
    static class Database
    {
        private static string _connStr;

        public static object[][] GetTable(string tableName)
        {
            string CommandText = $"select * from [{tableName}]";
            SqlDataAdapter da = new SqlDataAdapter(CommandText, _connStr);
            DataSet ds = new DataSet();
            da.Fill(ds, $"[{tableName}]");

            List<object[]> result = new List<object[]>();

            for(int i = 0; i < ds.Tables[$"[{tableName}]"].Rows.Count; i++)
            {
                result.Add(ds.Tables[$"[{tableName}]"].Rows[i].ItemArray);
            }

            return result.ToArray();
        }
        public static void Insert(string table, object[] data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into [{table}] values(";
            for (int i = 0; i < data.Length; i++)
            {
                command.CommandText += $"@par{i}";
                if (i != data.Length-1)
                    command.CommandText += ", ";

                command.Parameters.AddWithValue($"@par{i}", data[i]);
            }
            command.CommandText += ")";
        }
        public static void Update(string table, int id, string paramName, object data)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"update [{table}] set ";
            
            command.CommandText += ")";
        }
        private static void MyExecuteNonQuery(SqlCommand command)
        {
            SqlConnection cn;
            cn = new SqlConnection(_connStr);
            cn.Open();
            command.Connection = cn;
            command.ExecuteNonQuery();
            cn.Close();
        }
    }
}

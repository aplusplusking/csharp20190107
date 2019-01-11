using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection Cn = null;
            try
            {
                string conStr = "Provider=Ora OLEDB.ORACLE;data source=topcredu;User ID=scott;Password=tiger";
                Cn = new OleDbConnection(conStr);
                OleDbCommand cmdSelect = new OleDbCommand("select count(*) from emp",
               Cn);
                Cn.Open();
                object count = cmdSelect.ExecuteScalar();
                Console.WriteLine("Count of Emp = {0}", count);
                Cn.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
            finally
            {
                if (Cn.State == ConnectionState.Open)
                { Cn.Close(); }
            }
        }
    }
}
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
class Example
{
    public static void Main()
    {
        string str = "data source=topcredu;User ID = scott; Password = tiger";
        OracleConnection Conn = new OracleConnection(str);
        //Adapter 생성
        OracleDataAdapter adapter =
        new OracleDataAdapter("select * from emp", Conn);
        //CommandBuilder 개체를 이용하여 SQL 명령을 만든다.
        OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
        DataSet ds = new DataSet();

        adapter.Fill(ds, "사원");

        Console.WriteLine($"Data Count :{ds.Tables["사원"].Rows.Count}");

        DataColumn[] keys = new DataColumn[1];
        keys[0] = ds.Tables["사원"].Columns["empno"];
        ds.Tables["사원"].PrimaryKey = keys;
        DataRow findrow = ds.Tables["사원"].Rows.Find(7369);
        if (findrow != null)
        {
            findrow.Delete();
            adapter.Update(ds, "사원");
            //삭제 후 데이터 출력
            foreach (DataRow row in ds.Tables["사원"].Rows)
            {
                foreach (DataColumn col in ds.Tables["사원"].Columns)
                    Console.Write("{0, -10}", row[col.ColumnName]);
            }
            Console.WriteLine();
        }
    }
}
    
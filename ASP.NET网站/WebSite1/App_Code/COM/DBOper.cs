using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
///DBOper 的摘要说明
/// </summary>
public class DBOper
{
	public DBOper()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public static OleDbCommand CreateCommandDBCon()
    {
        //Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\bin\LocalAccess40.mdb
        //Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI
        //Provider=SQLOLEDB;Data Source=(local);User ID=sa;password=chen;
        string connectionString = "Provider=SQLOLEDB;data source=lak;initial catalog=Test;User ID=sa;password=5219162;";
        OleDbConnection conn = new OleDbConnection(connectionString);       
        return  conn.CreateCommand();
    }
    /// <summary>
    /// 执行SQLText脚本，返回影响行数
    /// </summary>
    /// <param name="strSQLText"></param>
    /// <returns></returns>
    public static int execNonQueryBySQLText(string strSQLText)
    {
        OleDbCommand comm = DBOper.CreateCommandDBCon();
        comm.CommandType = CommandType.Text;
        comm.CommandText = strSQLText;
       int affectedRows = -1;
        try
        {
            comm.Connection.Open();
            affectedRows = comm.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            comm.Connection.Close();
        }
        return affectedRows;
    }
    /// <summary>
    /// 执行SQL文本，返回DataTable
    /// </summary>
    /// <param name="strSQLText">SQL文本</param>
    /// <returns>DataTable</returns>
    public static DataTable execQueryBySQLText(string strSQLText)
    {
        OleDbCommand comm = DBOper.CreateCommandDBCon();
        comm.CommandType = CommandType.Text;
        comm.CommandText = strSQLText;        

        DataTable table = null;
        try
        {
            comm.Connection.Open();
            OleDbDataReader reader = comm.ExecuteReader();
            table = new DataTable();
            table.Load(reader);
            reader.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        finally
        {
            comm.Connection.Close();
        }
        return table;
    }
    
}

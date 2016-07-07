using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/// <summary>
///Magazine 的摘要说明
/// </summary>
public class Magazine
{
	public Magazine()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public string magazineId;
    public string magazineName;
    public string mdescription;
    public string magazineKey;
    public static DataTable selectDataTable(Magazine obj)
    {
        string strSQL = "select * from magazine where 1=1 ";
        if (obj.magazineId != null&&obj.magazineId!="")
            strSQL = strSQL + "and magazineId='" + obj.magazineId + "'";

        DataTable dt = DBOper.execQueryBySQLText(strSQL);

        return dt;
    }
    public static int insertRecord(Magazine obj)
    {
        string strSQL = "insert into magazine(magazineId,magazineName,mdescription,magazineKey) values('" + obj.magazineId + "','" + obj.magazineName + "','" + obj.mdescription + "','" + obj.magazineKey + "')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(Magazine obj)
    {
        string strSQL = "delete from magazine where magazineId='" + obj.magazineId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(Magazine obj)
    {
        string strSQL = "update magazine set magazineName='" + obj.magazineName + "',mdescription='" + obj.mdescription + "',magazineKey='" + obj.magazineKey + "' where magazineId='" + obj.magazineId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
}

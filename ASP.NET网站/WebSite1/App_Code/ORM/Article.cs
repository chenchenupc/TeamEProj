using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;

/// <summary>
///Article 的摘要说明
/// </summary>
public class Article
{
	public Article()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public string articleId;
    public string articleName;
    public string articleKey;
    public string author;
    public string adescription;
    public string limits;
    public string magazineId;
    public static DataTable selectDataTable(Article obj)
    {
        string strSQL = "select * from article where 1=1 ";
        if (obj.articleName != "" && obj.articleName != null)
            strSQL = strSQL + "and articleName='" + obj.articleName + "'";
        if (obj.magazineId != null&&obj.magazineId!="")
            strSQL = strSQL + "and magazineId='" + obj.magazineId + "'";
        DataTable dt = DBOper.execQueryBySQLText(strSQL);

        return dt;
    }
    public static int insertRecord(Article obj)
    {
        string strSQL = "insert into article(articleId,articleName,articleKey,author,adescription,limits,magazineId) values('" + obj.articleId + "','" + obj.articleName + "','" + obj.articleKey + "','" + obj.author + "','" + obj.adescription + "','" + obj.limits + "','" + obj.magazineId + "')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(Article obj)
    {
        string strSQL = "delete from article where articleId='" + obj.articleId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(Article obj)
    {
        string strSQL = "update article set articleName='" + obj.articleName + "',articleKey='" + obj.articleKey + "',author='" + obj.author + "',adescription='" + obj.adescription + "',limits='" + obj.limits + "',magazineId='" + obj.magazineId + "' where articleId='" + obj.articleId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
}

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
///UpImage 的摘要说明
/// </summary>
public class UpImage
{
	public UpImage()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public string imageId;
    public string savepath;
    public string magazineId;
    public int sequence;
    public string imageDesc;
    public DateTime uptime;
    public string articleId;
    public static DataTable selectDataTable(UpImage obj)
    {
        string strSQL = "select * from upImage where 1=1 ";
        if (obj.magazineId != "" && obj.magazineId != null)
            strSQL = strSQL + "and magazineId='" + obj.magazineId + "'";
        if (obj.articleId != "" && obj.articleId != null)
            strSQL = strSQL + "and articleId='" + obj.articleId + "'";

        DataTable dt = DBOper.execQueryBySQLText(strSQL);

        return dt;
    }
    public static int insertRecord(UpImage obj)
    {
        string strSQL = "insert into upImage(imageId,savepath,magazineId,sequence,imageDesc,uptime,articleId) values('" + obj.imageId + "','" + obj.savepath + "','" + obj.magazineId + "'," + obj.sequence + ",'" + obj.imageDesc + "','" + obj.uptime + "','" + obj.articleId + "')";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int deleteRecord(UpImage obj)
    {
        string strSQL = "delete from upImage where imageId='" + obj.imageId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
    public static int updateRecord(UpImage obj)
    {
        string strSQL = "update upImage set savepath='" + obj.savepath + "',magazineId='" + obj.magazineId + "',sequence=" + obj.sequence + ",imageDesc='" + obj.imageDesc + "',uptime='" + obj.uptime + "',articleId='" + obj.articleId + "' where imageId='" + obj.imageId + "'";
        int iRet = DBOper.execNonQueryBySQLText(strSQL);
        return iRet;
    }
}

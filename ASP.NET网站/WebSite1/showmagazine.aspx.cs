using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class showmagazine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string createHtmlStr()
    {
        string magId = Request.QueryString["magid"].ToString();
        string sqlstr = "select * from upImage where magazineId ='" + magId + "' order by sequence asc";
        DataTable dt = DBOper.execQueryBySQLText(sqlstr);
        int pageNum = dt.Rows.Count;
        string htmlStr = "";
        for (int i = 1; i <= pageNum; i++)
        {
            string str = "<div class=\"page\" style=\"background-image:url(./image/"+magId+"/" + i + ".jpg)\"></div>";
            htmlStr += str;
        }
        return htmlStr;
    }
}

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

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public string createHtml()
    {
        string sqlstr = "select * from magazine";
        DataTable dt = DBOper.execQueryBySQLText(sqlstr);
        int magNum = dt.Rows.Count;
        string htmlStr = "";
        for (int i = 1; i <= magNum; i++)
        {
            string str = "<li><a href=\"showmagazine.aspx?magid=" + i.ToString() + "\" target=\"_blank\">第" + i.ToString() + "期</a></li>";
            htmlStr += str;
        }
        return htmlStr;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Users obj = new Users();
        obj.username = TextBox1.Text;
        obj.password = TextBox2.Text;
        if (Users.ifLogin(obj))
        {
            ComTool.Redirect("management.aspx");
        }
        else
        {
            ComTool.Alert("用户名或密码错误！");
        }
    }
}

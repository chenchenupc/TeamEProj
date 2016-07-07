using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

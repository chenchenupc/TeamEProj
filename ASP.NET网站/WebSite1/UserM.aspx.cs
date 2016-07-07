using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbxUserName.Text.Trim() == "")
        {
            ComTool.Alert("请输入用户名！");
        }
        else if (tbxUserPWD.Text.Trim() == "")
        {
            ComTool.Alert("请输入密码！");
        }
        else
        {
            Users obj = new Users();
            obj.username = tbxUserName.Text;
            obj.password = tbxUserPWD.Text;
            if (Users.insertRecord(obj) == 1)
            {
                ComTool.Alert("新增成功！");
            }
            else
            {
                ComTool.Alert("新增失败！");
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("UsersList.aspx");
    }
}

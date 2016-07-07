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
using System.IO;

public partial class addmagazine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() == "")
        {
            ComTool.Alert("请输入期刊编号！");
        }
        else if (TextBox2.Text.Trim() == "")
        {
            ComTool.Alert("请输入期刊名称！");
        }
        else if (TextBox3.Text.Trim() == "")
        {
            ComTool.Alert("请输入期刊描述！");
        }
        else if (TextBox4.Text.Trim() == "")
        {
            ComTool.Alert("请输入关键字！");
        }
        else
        {
            Magazine obj = new Magazine();
            obj.magazineId = TextBox1.Text;
            obj.magazineName = TextBox2.Text;
            obj.mdescription = TextBox3.Text;
            obj.magazineKey = TextBox4.Text;
            if (Magazine.insertRecord(obj) == 1)
            {
                ComTool.Alert("新增成功！");
            }
            else
            {
                ComTool.Alert("新增失败！");
            }
            string crPath = "./image/" + obj.magazineId + "/";
            string path = Server.MapPath(crPath);
            Directory.CreateDirectory(path);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("dealmagazine.aspx");
    }
}

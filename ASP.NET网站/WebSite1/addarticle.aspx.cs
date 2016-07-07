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

public partial class addarticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = DBOper.execQueryBySQLText("Select * from magazine");
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "magazineId";
            DropDownList1.DataBind();
        }  
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() == "")
        {
            ComTool.Alert("请输入文章编号！");
        }
        else if (TextBox2.Text.Trim() == "")
        {
            ComTool.Alert("请输入文章名称！");
        }
        else if (TextBox4.Text.Trim() == "")
        {
            ComTool.Alert("请输入作者！");
        }
        
        else if (TextBox6.Text.Trim() == "")
        {
            ComTool.Alert("请输入权限！");
        }
        else if (DropDownList1.SelectedValue.Trim() == "")
        {
            ComTool.Alert("请输入期刊编号！");
        }
        else
        {
            Article obj = new Article();
            obj.articleId = TextBox1.Text;
            obj.articleName = TextBox2.Text;
            obj.articleKey = TextBox3.Text;
            obj.author = TextBox4.Text;
            obj.adescription = TextBox5.Text;
            obj.limits = TextBox6.Text;
            obj.magazineId = DropDownList1.SelectedValue;
            if (Article.insertRecord(obj) == 1)
            {
                ComTool.Alert("新增成功！");
            }
            else
            {
                ComTool.Alert("新增失败！");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("dealarticle.aspx");
    }
}

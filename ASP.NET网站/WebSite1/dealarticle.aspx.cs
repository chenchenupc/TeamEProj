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

public partial class addarticle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon());
            DataTable dt = DBOper.execQueryBySQLText("Select * from magazine");
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "magazineId";
            DropDownList1.DataValueField = "magazineId";
            DropDownList1.DataBind();
        }  
    }
    private Article searchCon()
    {
        Article obj = new Article();
        obj.articleName = TextBox1.Text.Trim();
        obj.magazineId=DropDownList1.SelectedValue;
        return obj;
    }
    private void BindData(Article obj)
    {
        DataTable dt = Article.selectDataTable(obj);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData(searchCon());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BindData(searchCon());
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("addarticle.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sqlstr1 = "delete from article where articleId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        string sqlstr2 = "delete from upImage where articleId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        string sqlstr3 = "select* from upImage where articleId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        DataTable dt = DBOper.execQueryBySQLText(sqlstr3);
        for (int j = 0; j < dt.Rows.Count;j++ )
        {
            string path = dt.Rows[j]["savepath"].ToString();
            File.Delete(path);
        }
        int i = DBOper.execNonQueryBySQLText(sqlstr2);
        if (DBOper.execNonQueryBySQLText(sqlstr1) == 1)
            BindData(searchCon());
        else
            ComTool.Alert("删除失败");

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData(searchCon());
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string sqlstr = "update article set articleName='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim() + "',articleKey='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim() + "',author='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim() + "',adescription='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim() + "',limits='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim() + "',magazineId='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[7].Controls[0])).Text.ToString().Trim() + "' where articleId='"
            + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        if (DBOper.execNonQueryBySQLText(sqlstr) == 1)
        {
            GridView1.EditIndex = -1;
            BindData(searchCon());
        }
        else
            ComTool.Alert("更新失败");
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindData(searchCon());
    }
}

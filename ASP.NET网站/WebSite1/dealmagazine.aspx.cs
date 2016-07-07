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

public partial class dealmagazine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon());
        }
    }
    private Magazine searchCon()
    {
        Magazine obj = new Magazine();
        obj.magazineId = TextBox1.Text.Trim();
        return obj;
    }
    private void BindData(Magazine obj)
    {
        DataTable dt = Magazine.selectDataTable(obj);
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
        ComTool.Redirect("addmagazine.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string j = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string sqlstr = "delete from magazine where magazineId='" + GridView1.DataKeys[e.RowIndex].Value.ToString()+"'";
        string sqlstr1 = "delete from article where magazineId='" + GridView1.DataKeys[e.RowIndex].Value.ToString()+ "'";
        string sqlstr2 = "delete from upImage where magazineId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        string sqlstr3 = "select* from upImage where magazineId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        DataTable dt = DBOper.execQueryBySQLText(sqlstr3);
        for (int k = 0; k < dt.Rows.Count; k++)
        {
            string path1 = dt.Rows[k]["savepath"].ToString();
            File.Delete(path1);
        }
        int i=DBOper.execNonQueryBySQLText(sqlstr2);
        i = DBOper.execNonQueryBySQLText(sqlstr1);
        if (DBOper.execNonQueryBySQLText(sqlstr) == 1)
            BindData(searchCon());
        else
            ComTool.Alert("删除失败");
        string dePath = "./image/" + j + "/";
        string path = Server.MapPath(dePath);
        Directory.Delete(path);
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData(searchCon());
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string sqlstr = "update magazine set magazineName='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim() + "',mdescription='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim() + "',magazineKey='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim() + "' where magazineId='"
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

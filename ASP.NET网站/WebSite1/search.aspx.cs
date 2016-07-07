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

public partial class search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BindData(searchCon());
    }
    private DataTable searchCon()
    {

        string strsqlarticle = "select * from article where author='" + TextBox1.Text + "'";
        DataTable dt = new DataTable();
        DataTable dtarticle = DBOper.execQueryBySQLText(strsqlarticle);
        for (int i = 0; i < dtarticle.Rows.Count; i++)
        {
            string strsqlpicture = "select * from upImage where articleId='" + dtarticle.Rows[i]["articleId"] + "'";
            DataTable dtupImage = DBOper.execQueryBySQLText(strsqlpicture);
            dt.Merge(dtupImage);
        }
        return dt;
    }
    private void BindData(DataTable dt)
    {
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindData(searchCon());
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string str = "delete from upImage where imageId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        string str1 = "select * from upImage where imageId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        DataTable dt = DBOper.execQueryBySQLText(str1);
        string path = dt.Rows[0]["savepath"].ToString();
        if (DBOper.execNonQueryBySQLText(str) == 1)
            BindData(searchCon());
        else
            ComTool.Alert("删除失败");
        File.Delete(path);
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData(searchCon());
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string sqlstr = "update upImage set magazineId='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim() + "',articleId='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim() + "',sequence='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim() + "',imageDesc='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim() + "',uptime='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim() + "' where imageId='"
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

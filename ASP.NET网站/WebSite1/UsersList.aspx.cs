using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UsersList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData(searchCon());
        }
    }
    private Users searchCon()
    {
        Users obj = new Users();
        obj.username = TextBox1.Text.Trim();
        return obj;
    }
    private void BindData(Users obj)
    {
        DataTable dt = Users.selectDataTable(obj);
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
        ComTool.Redirect("UserM.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string str = "delete from users where userId='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        if (DBOper.execNonQueryBySQLText(str) == 1)
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
        string sqlstr = "update users set username='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim() + "',password='"
            + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim() + "' where userId='"
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

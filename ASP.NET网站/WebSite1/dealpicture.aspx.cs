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

public partial class dealpicture : System.Web.UI.Page
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
            dt = DBOper.execQueryBySQLText("Select * from article");
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "articleName";
            DropDownList2.DataValueField = "articleName";
            DropDownList2.DataBind();
        }  
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BindData(searchCon());
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("addPicture.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue !=""&&DropDownList2.SelectedValue=="")
        {
           
            DropDownList2.Items.Clear();
            ListItem item = new ListItem();
            item.Text = "请选择";
            item.Value = "";
            DropDownList2.Items.Insert(0, item);
            DataTable dt = DBOper.execQueryBySQLText("Select * from article where magazineId='" + DropDownList1.SelectedValue + "'");
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "articleName";
            DropDownList2.DataValueField = "articleName";
            DropDownList2.DataBind();
            
        }
        //else
        //{
        //    DropDownList2.Items.Clear();
        //    ListItem item = new ListItem();
        //    item.Text = "请选择";
        //    item.Value = "";
        //    DropDownList2.Items.Insert(0, item);
        //    DataTable dt = DBOper.execQueryBySQLText("Select * from article");
        //    DropDownList2.DataSource = dt;
        //    DropDownList2.DataTextField = "articleName";
        //    DropDownList2.DataValueField = "articleName";
        //    DropDownList2.DataBind();
        //}
    }
    private UpImage searchCon()
    {
        UpImage obj = new UpImage();
        obj.magazineId = DropDownList1.SelectedValue;
        if (DropDownList2.SelectedValue != "")
        {
            string strSQL = "select * from article where articleName='" + DropDownList2.SelectedValue + "'";
            DataTable dt = DBOper.execQueryBySQLText(strSQL);
            obj.articleId = dt.Rows[0]["articleId"].ToString();
        }
        else
        {
            obj.articleId = "";
        }

        return obj;
    }
    private void BindData(UpImage obj)
    {
        DataTable dt = UpImage.selectDataTable(obj);
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
        string str = "delete from upImage where imageId='" + GridView1.DataKeys[e.RowIndex].Value.ToString()+"'";
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

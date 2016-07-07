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

public partial class addPicture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = DBOper.execQueryBySQLText("Select * from magazine");
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "magazineId";
            DropDownList2.DataValueField = "magazineId";
            DropDownList1.DataBind();
            dt = DBOper.execQueryBySQLText("Select * from article");
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "articleName";
            DropDownList2.DataValueField = "articleName";

            DropDownList2.DataBind();
        }  
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = DBOper.execQueryBySQLText("Select * from article where magazineId='" + DropDownList1.SelectedValue + "'");
        DropDownList2.DataSource = dt;
        DropDownList2.DataTextField = "articleName";
        DropDownList2.DataValueField = "articleName";
        DropDownList2.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string upPath = "./image/"+DropDownList1.SelectedValue+"/";  //上传文件路径
        //int upLength = 5;        //上传文件大小
        string upFileExtName = "|jpg|jpeg|";

        HttpFileCollection _files = System.Web.HttpContext.Current.Request.Files;
        string webFilePath = "";

        for (int i = 0; i < _files.Count; i++)
        {
            string name = _files[i].FileName;

            FileInfo fi = new FileInfo(name);

            string oldfilename = fi.Name;
            string scExtension = fi.Extension.ToLower();

            string fileName = TextBox3.Text + fi.Extension; // 文件名称，当前时间（yyyyMMddhhmmssfff）
            webFilePath = Server.MapPath(upPath) + fileName;        // 服务器端文件路径

            if (upFileExtName.IndexOf(scExtension.Replace(".", "")) == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件类型不符" + scExtension + "');", true);
                return;
            }

            //if ((fi.Length / (1024 * 1024)) > upLength)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('大小超出 " + upLength + " M的限制，请处理后再上传！');", true);
            //    return;
            //}

            try
            {
                _files[i].SaveAs(webFilePath);
                UpImage obj = new UpImage();
                obj.imageId = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                obj.savepath = webFilePath;
                obj.magazineId = DropDownList1.SelectedValue;
                obj.sequence = System.Int32.Parse(TextBox3.Text);
                obj.uptime = DateTime.Now;
                string strsql = "select * from article where articleName='" + DropDownList2.SelectedValue + "' and magazineId='" + DropDownList1.SelectedValue + "'";
                DataTable dt1 = DBOper.execQueryBySQLText(strsql);
                obj.articleId = dt1.Rows[0]["articleId"].ToString();
                obj.imageDesc = TextBox4.Text;
                UpImage.insertRecord(obj);
                ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件上传成功');", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "upfileOK", "alert('提示：文件上传失败" + ex.Message + "');", true);
            }

        }
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ComTool.Redirect("dealpicture.aspx");
    }
}

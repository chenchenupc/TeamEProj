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

public partial class showpicture : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sevPath = Server.MapPath("./").ToString();
        string imgPath = Request.QueryString["picurl"].Replace(sevPath,"");
        Image1.ImageUrl = imgPath;
    }
   
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
///Common 的摘要说明
/// </summary>
public class ComTool
{
    public ComTool()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static void Alert(string msg)
    {
        System.Web.HttpContext.Current.Response.Write("<script>alert('" + msg + "');</script>");
    }
    public static void Redirect(string reUrl)
    {
        System.Web.HttpContext.Current.Response.Write("<script>location.href='" + reUrl + "';</script>");
    }
    public static void parentRedirect(string reUrl)
    {
        System.Web.HttpContext.Current.Response.Write("<script>parent.location.href='" + reUrl + "';</script>");
    }
    public static void frame3Redirect(string reUrl)
    {
        System.Web.HttpContext.Current.Response.Write("<script>parent.frame3.location.href='" + reUrl + "';</script>");
    }
}

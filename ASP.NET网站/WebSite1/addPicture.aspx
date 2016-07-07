<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addPicture.aspx.cs" Inherits="addPicture" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style2
        {
            width: 153px;
        }
        .style5
        {
            width: 153px;
            height: 35px;
        }
        .style8
        {
            width: 259px;
            height: 20px;
        }
        .style9
        {
            width: 259px;
            height: 35px;
        }
        .style10
        {
            width: 259px;
        }
        .style11
        {
            width: 259px;
            height: 66px;
        }
        .style12
        {
            width: 153px;
            height: 66px;
        }
        .style13
        {
            width: 259px;
            height: 30px;
        }
        .style14
        {
            width: 153px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div style="height: 249px">
    <table style="height: 201px; width: 640px">
        <tr>
            <td class="style8"><h3 style="width: 79px">请输入：</h3></td>
        </tr>
         <tr>
            <td class="style9">期刊号：</td>
            <td class="style5">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="150px" 
                    AutoPostBack="True">
                </asp:DropDownList>
             </td>
        </tr>
         <tr>
            <td class="style13">文章名称：</td>
            <td class="style14">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="26px" Width="150px">
                </asp:DropDownList>
             </td>
        </tr>
         <tr>
            <td class="style10">当前期刊中图片页码：</td>
            <td class="style2">
                <asp:TextBox ID="TextBox3" runat="server" Width="146px"></asp:TextBox>
                 </td>
        </tr>
        <tr>
            <td class="style11">图片描述：</td>
            <td class="style12"> 
                <asp:TextBox ID="TextBox4" runat="server" Height="58px" Width="290px"></asp:TextBox>
                </td>
        </tr>
         <tr>
            <td class="style10">&nbsp;</td>
            <td class="style2"> 
                <input id="File1" type="file" name="File" /></td>
        </tr>
        <tr>
            <td class="style10">
            </td>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="上传" />
                &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="Button2" runat="server" Text="返回" onclick="Button2_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

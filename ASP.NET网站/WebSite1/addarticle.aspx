<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addarticle.aspx.cs" Inherits="addarticle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 95px;
        }
        .style2
        {
            width: 95px;
            height: 26px;
        }
        .style3
        {
            height: 26px;
        }
        .style4
        {
            width: 95px;
            height: 30px;
        }
        .style5
        {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 288px">
    <table style="height: 140px; width: 492px">
        <tr>
            <td class="style1">文章编号：</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style1">文章名称：</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style1">关键字：</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style2">作者：</td>
            <td class="style3">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style2">文章描述：</td>
            <td class="style3">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style2">权限</td>
            <td class="style3">
                <asp:TextBox ID="TextBox6" runat="server" Height="22px"></asp:TextBox>
                    </td>
        </tr>
        <tr>
            <td class="style4">期刊编号：</td>
            <td class="style5">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="145px" 
                        AppendDataBoundItems="True">
                        <asp:ListItem Value="">请选择：</asp:ListItem>
                    </asp:DropDownList>
                    </td>
        </tr>
        <tr>
            <td></td>
            <td>
            <table style="width: 387px">
            <tr>
                <td><asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="添加" /></td>
                <td><asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="返回" /></td>
            </tr>
                </table>
                    </td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>

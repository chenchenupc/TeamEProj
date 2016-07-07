<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 106px;
        }
        .style2
        {
            width: 106px;
            height: 27px;
        }
        .style3
        {
            height: 27px;
        }
        .style4
        {
            width: 106px;
            height: 26px;
        }
        .style5
        {
            height: 26px;
        }
    </style>
</head>
<body>
    <br />
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
    <div align="center">
    <h1>电子书管理系统登陆</h1>
    </div>
    <br />
    <br />
    <br />
    <div align="center">
    
        <table style="width: 33%; margin-top: 15px;">
            <tr>
                <td class="style2">
                    用户名：</td>
                <td class="style3" >
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    密码：</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

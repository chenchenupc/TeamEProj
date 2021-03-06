﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="UsersList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 110px;
        }
        .style3
        {
            width: 137px;
        }
        .style4
        {
            width: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    管理员列表</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    查询条件：</td>
                <td class="style2">
                    管理员姓名：</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" 
                        Width="85px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNew" runat="server" Text="新增" Width="80px" 
                        onclick="btnNew_Click" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="4">
                    <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" 
                        AutoGenerateColumns="False" 
                        onpageindexchanging="GridView1_PageIndexChanging" PageSize="10" 
                        AutoGenerateDeleteButton="True" AutoGenerateEditButton="True"
                        DataKeyNames="userId" OnRowDeleting="GridView1_RowDeleting"
                        OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
                        OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" 
                        ForeColor="#333333" GridLines="None">
                        <RowStyle BackColor="#EFF3FB" />
                        <Columns>
                        <asp:BoundField DataField="userid" HeaderText="管理员编号"><ItemStyle Width="30%" /></asp:BoundField>
                        <asp:BoundField DataField="username" HeaderText="管理员姓名" ><ItemStyle Width="25%" /></asp:BoundField>
                        <asp:BoundField DataField="password" HeaderText="密码" ><ItemStyle Width="30%" /></asp:BoundField>
                 </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

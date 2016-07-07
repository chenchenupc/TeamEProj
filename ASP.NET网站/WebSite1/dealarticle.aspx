﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dealarticle.aspx.cs" Inherits="addarticle" %>

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
        .style5
        {
            width: 112px;
            height: 25px;
        }
        .style6
        {
            width: 110px;
            height: 25px;
        }
        .style7
        {
            width: 137px;
            height: 25px;
        }
        .style8
        {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:100%;">
            <tr>
                <td class="style5">
                    文章列表</td>
                <td class="style6">
                    </td>
                <td class="style7">
                    </td>
                <td class="style8">
                    </td>
            </tr>
            <tr>
                <td class="style4">
                    查询条件：</td>
                <td class="style2">
                    文章名：</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="147px"></asp:TextBox>
                </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    期刊号</td>
                <td class="style3">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="152px" 
                        AppendDataBoundItems="True" >
                        <asp:ListItem Value=""></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" 
                        Width="85px" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNew" runat="server" Text="新增" Width="80px" 
                        onclick="btnNew_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="4">
                    <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" 
                        AutoGenerateColumns="False" 
                        onpageindexchanging="GridView1_PageIndexChanging" 
                        AutoGenerateDeleteButton="True" AutoGenerateEditButton="True"
                        DataKeyNames="articleId" OnRowDeleting="GridView1_RowDeleting"
                        OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
                        OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" 
                        ForeColor="#333333" GridLines="None">
                        <RowStyle BackColor="#EFF3FB" />
                        <Columns>
                        <asp:BoundField DataField="articleId" HeaderText="文章编号"><ItemStyle Width="12%" /></asp:BoundField>
                        <asp:BoundField DataField="articleName" HeaderText="文章名称" ><ItemStyle Width="12%" /></asp:BoundField>
                        <asp:BoundField DataField="articleKey" HeaderText="关键字" ><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:BoundField DataField="author" HeaderText="作者" ><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:BoundField DataField="adescription" HeaderText="文章描述" ><ItemStyle Width="15%" /></asp:BoundField>
                        <asp:BoundField DataField="limits" HeaderText="权限" ><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:BoundField DataField="magazineId" HeaderText="期刊编号" ><ItemStyle Width="12%" /></asp:BoundField>
                        
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

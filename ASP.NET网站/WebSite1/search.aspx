﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style4
        {
           
        }
        .style17
        {
            height: 35px;
            width: 111px;
        }
        .style18
        {
            height: 35px;
            width: 215px;
        }
        .style19
        {
            height: 35px;
        }
        .style20
        {
            height: 69px;
            width: 111px;
        }
        .style21
        {
            height: 69px;
            width: 215px;
        }
        .style22
        {
            height: 69px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 531px">
        <table style="height: 278px; width: 791px">
            <tr>
                <td class="style17">请输入：</td>
                <td class="style18">
                </td>
                <td class="style19">
                </td>
            </tr>
             <tr>
                <td class="style20">作者姓名：</td>
                <td class="style21">
                    <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="187px"></asp:TextBox>
                </td>
                <td class="style22">
                    <asp:Button ID="Button1" runat="server" Text="检索" Width="75px" Height="31px" 
                        onclick="Button1_Click" />
                </td>
            </tr>
             <tr>
                <td class="style4" colspan="3">
                     <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" 
                        AutoGenerateColumns="False" 
                        onpageindexchanging="GridView1_PageIndexChanging" PageSize="10" 
                        AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" 
                        DataKeyNames="imageId" OnRowDeleting="GridView1_RowDeleting"
                        OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
                        OnRowCancelingEdit="GridView1_RowCancelingEdit" CellPadding="4" 
                        ForeColor="#333333" GridLines="None" 
                        >
                        <RowStyle BackColor="#EFF3FB" />
                        <Columns>
                        <asp:BoundField DataField="magazineId" HeaderText="期刊编号" ><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:BoundField DataField="articleId" HeaderText="文章编号"><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:BoundField DataField="sequence" HeaderText="页码" ><ItemStyle Width="10%" /></asp:BoundField>
            
                        <asp:BoundField DataField="imageDesc" HeaderText="图片简介" ><ItemStyle Width="17%" /></asp:BoundField>
                        <asp:BoundField DataField="uptime" HeaderText="上传时间"><ItemStyle Width="10%" /></asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a href='showpicture.aspx?picurl=<%#Eval("savepath").ToString() %>' target="_blank">查看</a>
                            </ItemTemplate>
                        </asp:TemplateField>
               
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

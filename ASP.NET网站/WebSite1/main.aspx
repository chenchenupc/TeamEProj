<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="zh-CN" style="overflow-y:hidden">
<head runat="server">
    <title>蓝黄春秋</title>
    <link rel="stylesheet" href="./style/index.css" />
    <script src="./style/jquery-1.12.3.min.js"></script>
    <script src="./style/index.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="head">
    <div class="mid clearfix">
        <img src="./turnBook/img/logo.png" alt="miss-image" />
        <ul class="navLv1">
            <li>
                <a href="#">期刊浏览</a>
                <ul class="navLv2">
                   
                    <%=createHtml() %>
                </ul>
            </li>
            <li>
                <a href="#">电子期刊</a>
                <ul class="navLv2">
                    <li><a href="#">第一期</a></li>
                    <li><a href="#">第二期</a></li>
                    <li><a href="#">第三期</a></li>
                    <li><a href="#">第四期</a></li>
                </ul>
            </li>
            <li>
                <a href="#">期刊介绍</a>
                <ul class="navLv2">
                    <li><a href="#">第一期</a></li>
                    <li><a href="#">第二期</a></li>
                    <li><a href="#">第三期</a></li>
                    <li><a href="#">第四期</a></li>
                </ul>
            </li>
        </ul>
        <span><a id="load-text">管理员登陆</a></span>
    </div>
</div>
<div class="body">
    <div class="mid">
        <div class="left"></div>
        <div class="right"></div>
        <div class="load">
            <div class="loadTitle"><span>管理员登陆</span><img src="./turnBook/img/close.png" id="closeBtn" /></div>
            <div class="loadContent">
                <label><h3>账号：</h3><asp:TextBox ID="TextBox1" runat="server" placeholder="请输入账号"></asp:TextBox></label>
                <label><h3>密码：</h3><asp:TextBox ID="TextBox2" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox></label>
                <asp:Button ID="Button1" runat="server" Text="登陆" BorderStyle="None" 
                            BackColor="#0060FF" Height="40px" Width="310px" 
                    style="color:White" onclick="Button1_Click"/>
            </div>
            <div class="other">
                <span><a>用户注册</a></span><span><a>忘记密码</a></span>
            </div>
        </div>
    </div>
</div>
</form>
</body>
</html>

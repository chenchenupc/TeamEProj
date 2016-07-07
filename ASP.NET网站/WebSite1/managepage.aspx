<%@ Page Language="C#" AutoEventWireup="true" CodeFile="managepage.aspx.cs" Inherits="managepage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
     <meta charset="UTF-8" />
    <title>back</title>
    <link rel="stylesheet" href="./style/back.css" />
    <script src="./style/jquery-1.12.3.min.js"></script>
    <script src="./style/back.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="head">
    <div class="mid clearfix">
        <img src="./turnBook/img/logo.png" alt="miss-image">
        <h1>《蓝黄春秋》后台管理系统</h1>
        <span><a id="out-text">退出登陆</a></span>
    </div>
</div>
<div class="nav">
    <h3><i></i>账号管理</h3>
    <ul class="navLv1">
        <li><a href="#">管理员列表维护</a></li>
        <li><a href="#">功能2</a></li>
        <li><a href="#">功能3</a></li>
    </ul>
    <h3><i></i>数据管理</h3>
    <ul class="navLv1">
        <li><a href="#">期刊维护</a></li>
        <li><a href="#">文章维护</a></li>
        <li><a href="#">素材维护</a></li>
    </ul>
    <h3><i></i>搜索管理</h3>
    <ul class="navLv1">
        <li><a href="#">上传日期检索</a></li>
        <li><a href="#">关键字检索</a></li>
        <li><a href="#">作者检索</a></li>
    </ul>
</div>
<!--后面放一个frameset-->
    </form>
</body>
</html>

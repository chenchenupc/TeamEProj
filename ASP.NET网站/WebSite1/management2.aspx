<%@ Page Language="C#" AutoEventWireup="true" CodeFile="management2.aspx.cs" Inherits="management2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8" />
    <title></title>
    <link rel="stylesheet" href="./style/back.css" />
    <script src="./style/jquery-1.12.3.min.js"></script>
    <script src="./style/back.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
    <h3><i></i>账号管理</h3>
    <ul class="navLv1">
        <li><a href="UsersList.aspx" target='frame3'>管理员列表维护</a></li>
       
    </ul>
    <h3><i></i>数据管理</h3>
    <ul class="navLv1">
        <li><a href="dealmagazine.aspx" target='frame3'>期刊维护</a></li>
        <li><a href="dealarticle.aspx" target='frame3'>文章维护</a></li>
        <li><a href="dealpicture.aspx" target='frame3'>素材维护</a></li>
    </ul>
    <h3><i></i>搜索管理</h3>
    <ul class="navLv1">
        <li><a href="search.aspx" target='frame3'>上传日期检索</a></li>
        <li><a href="search.aspx" target='frame3'>关键字检索</a></li>
        <li><a href="search.aspx" target='frame3'>作者检索</a></li>
    </ul>
</div>
    </form>
</body>
</html>

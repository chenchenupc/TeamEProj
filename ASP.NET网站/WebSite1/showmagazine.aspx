<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showmagazine.aspx.cs" Inherits="showmagazine" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width = 1050, user-scalable = no" />
    <title>Book</title>
    <script src="./style/jquery.min.1.7.js"></script>
    <script src="./style/modernizr.2.5.3.min.js"></script>
    <script src="./style/addpage.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="flipbook-viewport">
    <div class="container">
        <div class="flipbook" id="flipbook">
            <%=createHtmlStr() %>
        </div>
    </div>
    </div>
    </form>
</body>
</html>

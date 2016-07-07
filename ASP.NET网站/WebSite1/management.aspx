<%@ Page Language="C#" AutoEventWireup="true" CodeFile="management.aspx.cs" Inherits="management" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>蓝黄春秋</title>
</head>
    <frameset rows="70,*" border="0px" style="background-image: url(./turnBook/img/bg2.jpg)">
        <frame src="management1.aspx" noresize="noresize" name="frame1" >
        <frameset cols="240,*">
            <frame src="management2.aspx" noresize="noresize" name="frame2">
            <frame src="management3.aspx" noresize="noresize" name="frame3" style="background:rgba(255,255,255,0.5)">
        </frameset>
    </frameset>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>        
<frame name="topFrame" src="top.aspx" scrolling="NO">
<body>
<frameset rows="96,*" frameborder="NO" border="1" framespacing="0">

        <frameset id="main" cols="168,*" frameborder="NO" border="0" framespacing="0">
             <frame id="leftFrame" src="left.aspx" scrolling="YES">
             <frame name="mainFrame" src="main.html">
        </frameset>
    </frameset>
</body>
</html>

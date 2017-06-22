<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDemo.aspx.cs" Inherits="newsUI.getDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <%-- <form id="form1" runat="server" method="get" action="getDemo.aspx">--%><%--get提交--%>
        <%--<form id="form1" runat="server" method="post" action="ifLogin.aspx">--%> <%--post提交模式完成用户登录（链接数据库）--%>
     <form id="form1" runat="server" method="post" action="ifLogin.ashx"> <%--post提交一般处理程序--%>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="登录："></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="密码;"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:Button ID="GetButton" runat="server" Text="提交" />
    
    </div>
    </form>
</body>
</html>

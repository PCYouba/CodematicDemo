<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspNet.aspx.cs" Inherits="newsUI.AspNet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1"  method="post"  runat="server">
    <div>
    

        标准标签： 登录名：<asp:TextBox ID="TextBox1" name="TextBox1" runat="server"></asp:TextBox>
        密　码：<asp:TextBox ID="TextBox2" name="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button提交" OnClick="Button1_Click" />
        <br />
        <br />
       </div>
    </form>

</body>
</html>

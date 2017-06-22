<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shuoshuo.aspx.cs" Inherits="newsUI.zzzzz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <script type="text/javascript" src="ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="ueditor/ueditor.all.js"></script>
    <link rel="stylesheet" href="ueditor/themes/default/css/ueditor.css" />
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()"></textarea>
　　　　<script type="text/javascript">
　　　　　　var editor = new baidu.editor.ui.Editor();
　　　　　　editor.render("myEditor");
　　　　</script>
<div id="myButton" runat="server">
<asp:Button ID="Button" runat="server" Text="获取数据" OnClick="Button_Click"  />  <asp:Label ID="LabelResule" runat="server" Text="操作提示："></asp:Label>
    <%foreach (System.Data.DataRow dr in newstable.Rows)
	{%>
		<span><a href="newview.aspx?newid=<%=dr[0]%>">返回</a> </span>
	<%}%>

</div>
    

    <script type="text/javascript">
        function setUeditor() {
            var myEditor = document.getElementById("myEditor");
            myEditor.value = editor.getContent();
        }



    </script>
</form>
</body>
</html>

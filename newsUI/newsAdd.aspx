<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newsAdd.aspx.cs" Inherits="newsUI.newsAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="ueditor/ueditor.all.js"></script>
    <link rel="stylesheet" href="ueditor/themes/default/css/ueditor.css" />


    <title></title>
    <link rel="stylesheet" type="text/css" href="Css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="Css/bootstrap-responsive.css" />
    <link rel="stylesheet" type="text/css" href="Css/style.css" />
    <script type="text/javascript" src="Js/jquery2.js"></script>
    <script type="text/javascript" src="Js/jquery2.sorted.js"></script>
    <script type="text/javascript" src="Js/bootstrap.js"></script>
    <script type="text/javascript" src="Js/ckform.js"></script>
    <script type="text/javascript" src="Js/common.js"></script>
    <script type="text/javascript" src="Js/jquerypicture.js"></script>
    
    <style type="text/css">
        body {font-size: 20px;
            padding-bottom: 40px;
            background-color:#e9e7ef;
        }
        .sidebar-nav {
            padding: 9px 0;
        }

        @media (max-width: 980px) {
            /* Enable use of floated navbar text */
            .navbar-text.pull-right {
                float: none;
                padding-left: 5px;
                padding-right: 5px;
            }
        }


    </style>
</head>
<body>
   <form action="#" method="post" runat="server" class="definewidth m20" enctype="multipart/form-data">
<table class="table table-bordered table-hover m10" style="margin-left:10px;margin-top:3px;">
    <tr>
        <td width="10%" class="tableleft">类别</td>
        <td>

            <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem Value="1">微博推广</asp:ListItem>
                       <asp:ListItem Value="2">微信推广</asp:ListItem>
                       <asp:ListItem Value="3">软文推广</asp:ListItem>
                       <asp:ListItem Value="4">媒体到场</asp:ListItem>
                       <asp:ListItem Value="5">金融世纪</asp:ListItem>
                       <asp:ListItem Value="6">公益活动</asp:ListItem>
                   </asp:DropDownList>
            
        </td>
    </tr>
    
   
    <tr>
        <td class="tableleft">新闻标题</td>
        <td><asp:TextBox ID="TBnewsTitle" runat="server"></asp:TextBox></td>
        <%--<td class="tableleft">视频大小</td>--%>
        <%--<td><input type="text" name="videosNumber"/></td>--%>
    </tr>
    <tr>
        <td class="tableleft">发布时间</td>
        <td><asp:TextBox ID="TBnewsReleaseTime" runat="server"></asp:TextBox></td>

    </tr>
     <tr>
        <td class="tableleft">发布人</td>
        <td><asp:TextBox ID="TBuser" runat="server"></asp:TextBox></td>
      
    </tr>
    <tr>
        <td class="tableleft">关键字</td>
        <td><asp:TextBox ID="TBKeyword" runat="server"></asp:TextBox></td>
    
	
    <tr>
        <td class="tableleft">新闻内容</td>
     
    </tr>
  
</table>
       <div>

  <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()"></textarea>
　　　　<script type="text/javascript"> 
　　　　　　var editor = new baidu.editor.ui.Editor();
　　　　　　editor.render("myEditor");
　　　　</script>

           <div id="myButton" runat="server">
<%--<asp:Button ID="Button" runat="server" Text="获取数据"  />--%>
    <button type="submit" name="Button" id="Button">获取数据</button>
</div>
       </div>                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" /> &nbsp;&nbsp;        <asp:Label ID="LabelResule" runat="server" Text="操作提示："></asp:Label>

</form>


      <script type="text/javascript">
        function setUeditor() {
            var myEditor = document.getElementById("myEditor");
            myEditor.value = editor.getContent();
        }

    </script>
</body>
</html>

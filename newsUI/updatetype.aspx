<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updatetype.aspx.cs" Inherits="newsUI.updatetype" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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


        .auto-style1 {
            width: 434px;
        }


    </style>

</head>
<body>
   <font color="#777777"><strong>修改类别：</strong></font> 
<form action="#" runat="server" method="post" class="definewidth m20" enctype="multipart/form-data">
<table style="margin-left:10px;margin-top:3px;">
    <tr>
         <td class="auto-style1">类别名称：</td>
		 <td>  <asp:TextBox ID="TBtype" runat="server"></asp:TextBox></td>
    </tr>
	<tr>
         <td class="auto-style1">备注：</td>
		 <td><input type="text" name="classname" style="height: 100px;wight：200px;"/></td>
    </tr>
	
    <tr>
        
       <td class="auto-style1">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" /> &nbsp;&nbsp;  <a href="typeQuery.aspx"> <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" Height="26px" /></a>
          
        </td>
    </tr>
</table>
</form>


</body>
</html>

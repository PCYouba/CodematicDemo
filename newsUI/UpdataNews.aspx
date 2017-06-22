<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdataNews.aspx.cs" Inherits="newsUI.UpdataNews" %>

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

    <style type="text/css">
        body {font-size: 20px;
		font-size: 20px;
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
        #fenye{
    padding-left: 300px;
}
         </style>
</head>
<body>
    <form id="form1" runat="server">
       <font color="#777777"><strong>修改新闻：</strong></font>
  <%--  <input type="text" name="menuname" id="menuname"class="abc input-default" placeholder="" value="">&nbsp;&nbsp; 
    <button type="submit" class="btn btn-primary">查询</button>&nbsp;&nbsp; --%>
	

        <asp:HiddenField ID="UserId" runat="server" OnValueChanged="HiddenField1_ValueChanged" />
	

<table class="table table-bordered table-hover definewidth m10">
     <tr>
          <th>新闻类别</th>
         <td>
             <asp:TextBox ID="TBnewType" runat="server"></asp:TextBox>
         </td>
         </tr> 
    <tr>
        <th>新闻内容</th>
      
         <td>
             <asp:TextBox ID="TBnewsContent" runat="server" MaxLength="550" TextMode="MultiLine"></asp:TextBox>
         </td>
        
    </tr>

    <tr>
        <th>新闻标题</th>
         <td>
             <asp:TextBox ID="TBnewsTitle" runat="server"></asp:TextBox>
         </td>
    </tr>
   
    <tr>
         <th>发布人</th>
         <td>
             <asp:TextBox ID="TBnewsUser" runat="server"></asp:TextBox>
         </td>
    </tr>

     <tr>
          <th>发布日期</th>
          <td>
             <asp:TextBox ID="TBnewsReleaseTime" runat="server"></asp:TextBox>
         </td>
    </tr>
        <tr>
               <th>操作</th>
          <td> 
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" />
                </td>
               
           </tr>
       
       </table>
    </form>
</body>
</html>

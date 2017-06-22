<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modifyUser.aspx.cs" Inherits="newsUI.modifyUser" %>

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
   <form id="form1" runat="server">
     <font color="#777777"><strong>用户修改：</strong></font>
   
<table class="table table-bordered table-hover definewidth m10">
    <%--<thead>--%>
    <tr>
        <th>登录名</th>
        <td>
                    <asp:TextBox ID="TBusername" runat="server"></asp:TextBox>
                </td>
    
     </tr>
    <%--</thead>--%>
    <tr>
        <th>真实名</th>
        <td>
                     <asp:TextBox ID="TBuserTrue" runat="server"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>密码</th>
         <td>
                     <asp:TextBox ID="TBuserpwd" runat="server"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>Email</th>
        <td>
                   <asp:TextBox ID="TBuserEmail" runat="server"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>手机号码</th>
        <td>
                    <asp:TextBox ID="TBuserTel" runat="server"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>用户身份</th>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem Value="1">管理员</asp:ListItem>
                       <asp:ListItem Value="0">普通用户</asp:ListItem>
                   </asp:DropDownList>
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

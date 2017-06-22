<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="newsUI.Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        body {
		  background-color: #99CCFF
               /*#c5d9e2;*/  /*网页背景的颜色*/
		}
		#beijing
		{
			position: relative;
			height:500px ;
		    width:500px;
			margin: 0 auto;
            border-radius: 30px ;
			background-color: #FFFFFF;
              
			
		}

       
         .auto-style1 {
             width: 514px;
             height: 444px;
             margin:0 auto;
         }

      
        

        </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
            &nbsp;<asp:Label ID="LblTishi" runat="server">用户注册</asp:Label>
        </p>
      
       <table class="auto-style1">
    <%--<thead>--%>
    <tr>
        <th>登录名</th>
        <td>
                    <asp:TextBox ID="TBusername" runat="server" Height="34px" Width="186px"></asp:TextBox>
                </td>
    
     </tr>
    <%--</thead>--%>
    <tr>
        <th>真实名</th>
        <td>
                     <asp:TextBox ID="TBuserTrue" runat="server" Height="33px" Width="185px"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>密码</th>
         <td>
                     <asp:TextBox ID="TBuserpwd" runat="server" Height="34px" Width="186px"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>Email</th>
        <td>
                   <asp:TextBox ID="TBuserEmail" runat="server" Height="34px" Width="186px"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>手机号码</th>
        <td>
                    <asp:TextBox ID="TBuserTel" runat="server" Height="35px" Width="186px"></asp:TextBox>
                </td>
    </tr>

    <tr>
         <th>用户身份</th>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="185px">
                       <asp:ListItem Value="1">管理员</asp:ListItem>
                       <asp:ListItem Value="0">普通用户</asp:ListItem>
                   </asp:DropDownList>
               </td>
    </tr>
      
           <tr>
               <th>操作</th>
          <td> 
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" Height="34px" Width="126px" />&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" Height="34px" Width="126px" />
                </td>
               
           </tr>
       
       </table>





   
        
    </form>
</body>
</html>

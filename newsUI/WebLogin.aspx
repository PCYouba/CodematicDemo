<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebLogin.aspx.cs" Inherits="newsUI.WebLogin" %>

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

        #shangbeijing
        {
            position:absolute;
            left: 0px;
			top: 0px;
			height: 85px;
			width: 500px;
            border-radius: 30px;
			background-color:  #02b4fe;
            color: #ffffff; /*字体的颜色*/
		  text-align: center; /*字体位置  居中*/
          font-size: xx-large;
          padding-top:100px;
        }

     a
     {
         color:gray;
     }
        

        </style>

</head>
<body>
    <form id="form1" runat="server">
    <p>
            &nbsp;</p>
       
    <div>
    
        <br />
    
    </div>
        <div id="beijing">
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="用户名：" BorderStyle="None" ForeColor="#999999" Height="33px" Width="100px"></asp:Label>
            <asp:TextBox ID="TBname" runat="server" Height="30px" Width="300px" OnTextChanged="TBname_TextChanged"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="密 码 ：" ForeColor="#999999" Height="30px" Width="100px"></asp:Label>
            <asp:TextBox ID="TBPassword" runat="server" Height="30px" Width="300px"></asp:TextBox>
            <br />
             &nbsp;&nbsp;&nbsp;<asp:Label ID="LblTishi" runat="server"></asp:Label><%--提示框--%>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Butlogin" runat="server" OnClick="ButOK_Click" Text=" LOGIN IN" Height="50px" Width="150px" BackColor="#02B4FE" BorderStyle="None" ForeColor="White" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Butsign" runat="server" BackColor="#D9D9D9" BorderStyle="None" ForeColor="White" Height="50px" Text=" SIGN UP" Width="150px" OnClick="Butsign_Click" />
            <br />
             <br />&nbsp;
            
<%--          <asp:Button ID="Buttjump" runat="server" OnClick="Buttjump_Click" Text="转到管理员登录" BorderStyle="None" ForeColor="#999999" Height="30px" Width="100px" />--%>
       
           
            <br />
            
         <div id="shangbeijing">PiLiPaLa</div>
         <div id="denglu"> <a href="#" style="margin-left:40%">转到管理员登录</a></div>
         <div id="zhuce"></div>
         <div id="tiaozhuan"></div>
       </div>
    </form>

<%--    <script type="text/javascript">
        function tishi() {

           alert("登录失败，请确认用户名和密码。");
          
        }
        
    </script>--%>

</body>
</html>

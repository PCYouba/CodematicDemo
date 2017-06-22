<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userList.aspx.cs" Inherits="newsUI.userList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Css/bootstrap.css" />
<link rel="stylesheet" type="text/css"
	href="Css/bootstrap-responsive.css" />
<link rel="stylesheet" type="text/css" href="Css/style.css" />
<script type="text/javascript" src="Js/jquery2.js"></script>
<script type="text/javascript" src="Js/jquery2.sorted.js"></script>
<script type="text/javascript" src="Js/bootstrap.js"></script>
<script type="text/javascript" src="Js/ckform.js"></script>
<script type="text/javascript" src="Js/common.js"></script>

<style type="text/css">
body {font-size: 20px;
	padding-bottom: 40px;
	background-color: #e9e7ef;
}

.sidebar-nav {
	padding: 9px 0;
}

@media ( max-width : 980px) {
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
   <form class="form-inline definewidth m20" action="#" method="get">
		 <font color="#777777"><strong>用户信息：</strong></font> 
		
	</form>
	<table class="table table-bordered table-hover definewidth m10">
		<thead>
			<tr>
				<th>登录名</th>
			    <th>真实名</th>
                <th>手机</th>
				<th>邮箱</th>
				<th>删除</th>
				<th>修改</th>
			</tr>
		</thead>
        <%foreach (System.Data.DataRow dr in usertable.Rows)
            { %>

           

		<tr>
			<td><%=dr[1] %></td>
		    <td><%=dr[2] %></td>
              <td><%=dr[3] %></td>
			<td><%=dr[4] %></td>
			<td>
			    <a onclick="javascript:return confirm('确认删除吗？')" href="del.ashx?flag=user&userid=<%=dr[0] %>">删除</a>
            </td>

			<td>
				<a href="modifyUser.aspx?userid=<%=dr[0] %>"> 修改</a>
			</td>

		</tr>
        <%} %>

	</table>


 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button type="button"  id="addnew">
     
			<a href="studentQuery.aspx">添加用户</a>
		</button>

    <div id="fenye">
                                
                                <a href="#">共【<%=pi.totalcount %>】条，共【<%=pi.pagecount %>】页，当前第【<%=pi.pageindex %>】页</a>
                                <a href="userList.aspx">返回主页</a>
                              
                                <a href="userList.aspx?page=<%=pi.pageindex-1==0?1:pi.pageindex-1 %>">上一页</a>
                                <a href="userList.aspx?page=<%=pi.pageindex+1>=pi.pagecount?pi.pagecount:pi.pageindex+1 %>">下一页</a>

                                <a href="userList.aspx?page=<%=pi.pagecount %>">尾页</a>

                                
                            </div>

</body>
</html>

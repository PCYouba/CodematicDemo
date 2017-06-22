<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comment.aspx.cs" Inherits="newsUI.comment" %>

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
        #fenye{
    padding-left: 300px;
}

    </style>
</head>
<body>
   <form class="form-inline definewidth m20" action="#" method="get">
     <font color="#777777"><strong>浏览评价：</strong></font>
   <%-- <input type="text" name="menuname" id="menuname"class="abc input-default" placeholder="" value="">&nbsp;&nbsp; 
    <button type="submit" class="btn btn-primary">查询评价</button>&nbsp;&nbsp; --%>
	
</form>
<table class="table table-bordered table-hover definewidth m10">
    <thead>
    <tr>
        <th>评价内容</th>
        <th>评价人</th>
        <th>评价时间</th>
        <th>操作</th>
       
    </tr>
    </thead>
	    
      <%foreach (System.Data.DataRow dr in commtable.Rows)
            { %>

        <tr>
                
                <td><%=dr[4] %></td>
                <%--发布人--%>
            <%foreach (System.Data.DataRow drr in usertable.Rows)
                { %>
            <%if (Convert.ToInt32(dr[2]) == Convert.ToInt32(drr[0]))
                {%>
                    <td><%=drr[2] %></td>
                <%}%>
				

            <%} %>
                <td><%=dr[5].ToString().Split(' ')[0] %></td>
                <td> <a onclick="javascript:return confirm('确认删除吗？')" href="commdel.ashx?flag=comment&commentid=<%=dr[0] %>">删除</a></td>
               
        </tr>
             <%} %>
       
       </table>

    <div id="fenye">
                                
                                <a href="#">共【<%=pi.totalcount %>】条，共【<%=pi.pagecount %>】页，当前第【<%=pi.pageindex %>】页</a>
                                <a href="comment.aspx">返回主页</a>
                              
                                <a href="comment.aspx?page=<%=pi.pageindex-1==0?1:pi.pageindex-1 %>">上一页</a>
                                <a href="comment.aspx?page=<%=pi.pageindex+1>=pi.pagecount?pi.pagecount:pi.pageindex+1 %>">下一页</a>

                                <a href="comment.aspx?page=<%=pi.pagecount %>">尾页</a>

                                
                            </div>
</body>
</html>

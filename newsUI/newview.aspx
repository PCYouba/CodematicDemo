<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newview.aspx.cs" Inherits="newsUI.newview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="ueditor/ueditor.config.js"></script>
    <script type="text/javascript" src="ueditor/ueditor.all.js"></script>
    <link rel="stylesheet" href="ueditor/themes/default/css/ueditor.css">
   <title>P.C.Y新闻发布平台-新闻预览页</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
      <div id="page">
		<div id="header">
			<div id="section">
				<div><a href="index.aspx"><img src="images/logo.gif" alt="Logo" /></a></div>
				<span>官方邮箱：Park.C.Y.News@136.com <br /><br />咨询电话：+ 888 888 888</span>
			</div>
			<ul>
				<li ><a href="index.aspx">主页</a></li>
				<li><a href="consulting.aspx">热点新闻</a></li>
				<li><a href="Comming.aspx">服务项目</a></li>
				    <%--<li><a href="#">金融经济</a></li>
				<li><a href="#">科技发明</a></li>--%>
				<li><a href="#">走进Park.C.Y</a></li>
				<li><a href="Aboutus.aspx">关于我们</a></li>
			</ul>
			<div id="tagline">
				<div>
					<h4>News Release Platform</h4>
					<p>致力于以最低投入、最短时间、最多平台、最大效益的情况下实现真正的网络营销</p>
				</div>
			</div>
		</div>
		<div id="content">
			<div id="home">
				<div>
					<div id="aside">
						<div>
							<h1>Welcome to <span class="last">P.C.Y新闻发布平台</span></h1>
                           
							<h1>《<%=curtnew.newsTitle %>》</h1>
						<p><%=curtnew.newsContent %></p> 
                        <p>发布时间：<%=curtnew.newsReleaseTime.ToString().Split(' ')[0] %></p>
                        </div>

                        <div>
                            <h4><a href="shuoshuo.aspx?newid=<%=curtnew.newsId%>">我要评论：</a></h4>
                            <%foreach (System.Data.DataRow dr in commtable.Rows)
                                {%>
                            <%if (Convert.ToInt32(curtnew.newsId)== Convert.ToInt32(dr[1]))
	                     {%>
		 

                            <%foreach (System.Data.DataRow drr in usertable.Rows)
                                {%>
                            <%if (Convert.ToInt32(dr[2])== Convert.ToInt32(drr[0]))
	                            {%>
		                        <p>评论人：<%=drr[2]%></p>
	                            <%}%>
                                <%}%>

                            <p>评论内容：<%=dr[4]%></p>
                            <p>评论时间：<%=dr[5]%></p>
                            <h4>-----------------------------------------------------------------------------------</h4>

                            <%} %>
                            <%}%>
                        </div>

					</div>
					
                   
				</div>
			</div>
		</div>
		<div id="footer">
			<div>
				<div id="connect">
					<a href="#" target="_blank"><img src="images/icon-facebook.gif" alt="Facebook" /></a>
					<a href="#" target="_blank"><img src="images/icon-twitter.gif" alt="Twitter" /></a>
					<a href="#" target="_blank"><img src="images/icon-youtube.gif" alt="Youtube" /></a>
				</div>
				<div class="section">
					<ul>
						<li><a href="index.aspx">主页</a></li>
						<li><a href="Aboutus.aspx">关于我们</a></li>
						<li><a href="#">概况介绍</a></li>
						<li><a href="#">交流合作</a></li>
						<li><a href="#">公共服务</a></li>
						<li class="last"><a href="Aboutus.aspx">联系我们</a></li>
					</ul>

                    
					<p>&copy; Copyright 0000. Company Name. All Rights Reserved.</p>
				</div>
			</div>
		</div>
	</div>
<div style="display:none"><script src='http://v7.cnzz.com/stat.php?id=155540&web_id=155540' language='JavaScript' charset='gb2312'></script></div>
    </form>
</body>
</html>

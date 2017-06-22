<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulting.aspx.cs" Inherits="newsUI.consulting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <title>P.C.Y新闻发布平台-新闻列表页</title>
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
				<li><a href="#">服务项目</a></li>
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
					<div >
						<div>
							<h1>Welcome to <span class="last">P.C.Y新闻发布平台</span>--新闻列表页</h1>
							
							
                            		 <div class="news_mainR aGray">

            	<ul>
                    <%foreach (System.Data.DataRow dr in newsinfotable.Rows)
                        { %>
                	<li>
                   
                      
                   <%-- <a href="newview.aspx?newid=<%=dr[0]%>"><%=dr[3].ToString().PadRight(50).Substring(0,19) %></a>--%>
                        <h4> <a href="newview.aspx?newid=<%=dr[0]%>"><%=dr[3].ToString().PadRight(50).Substring(0,20) %></a>
                          ---------------
                         <span><%=dr[6].ToString().Split(' ')[0] %></span></h4>
                    </li>
                    <% } %>
                        
                </ul>
               </div>
                            <div>
                                
                                <a href="#">共【<%=pi.totalcount %>】条，共【<%=pi.pagecount %>】页，当前第【<%=pi.pageindex %>】页</a>
                                <a href="index.aspx">返回主页</a>
                                <%--<a href="consulting.aspx?page=<%=pi.pageindex-1 %>">上一页</a>
                                <a href="consulting.aspx?page=<%=pi.pageindex+1 %>">下一页</a>--%>
                                <a href="consulting.aspx?page=<%=pi.pageindex-1==0?1:pi.pageindex-1 %>">上一页</a>
                                <a href="consulting.aspx?page=<%=pi.pageindex+1>=pi.pagecount?pi.pagecount:pi.pageindex+1 %>">下一页</a>

                                <a href="consulting.aspx?page=<%=pi.pagecount %>">尾页</a>

                                 <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                            <asp:Button ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
                                

                            </div>
                           

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
						<li><a href="userindex.html">主页</a></li>
						<li><a href="#">关于我们</a></li>
						<li><a href="#">概况介绍</a></li>
						<li><a href="#">交流合作</a></li>
						<li><a href="#">公共服务</a></li>
						<li class="last"><a href="#">联系我们</a></li>
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




           
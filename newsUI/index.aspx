<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="newsUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>P.C.Y新闻发布平台-首页</title>
    <%--<link rel="stylesheet" type="text/css" href="js/style.css" />--%>
	<link rel="stylesheet" type="text/css" href="style.css" />
	<!--[if IE 6]>
		<link rel="stylesheet" type="text/css" href="ie6.css" />
	<![endif]-->
</head>
<body>
	<div id="page">
		<div id="header">
			<div id="section">
				<div><a href="index.aspx"><img src="images/logo.gif" alt="Logo" /></a></div>
				<span>官方邮箱：Park.C.Y.News@136.com <br /><br />咨询电话：+ 888 888 888</span>
			</div>
			<ul>
				<li ><a href="index.aspx">主页</a></li>
				<li><a href="consulting.aspx">热点新闻</a></li>
				<li><a href="work.aspx">服务项目</a></li>
				<%--<li><a href="#">金融经济</a></li>
				<li><a href="#">科技发明</a></li>--%>
				<li><a href="Comming.aspx">走进Park.C.Y</a></li>
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
							<h1>Welcome to <span class="last">P.C.Y新闻发布平台</span>--首页</h1>
							
                                <%--<img src="images/model1.jpg" alt="Image" />
                               插入企业视频介绍--%>
                                <h4>企业视频介绍：</h4>
                <video width="450" height="310"  controls="controls"><!--autoplay="autoplay"自动播放   controls="controls"播放面板-->
			    <source src="images/0.mp4" type="video/mp4"/>
			    <source src="myvideo.ogv" type="video/ogg"/>
			    <source src="myvideo.webm" type="video/webm"/>
			    <object width="" height="" type="application/x-shockwave-flash" data="myvideo.swf">
				<param name="movie" value="myvideo.swf" />
				<param name="flashvars" value="autostart=true&amp;file=myvideo.swf" />
			    </object>
                <div>当前浏览器不支持 video直接播放，点击这里下载视频： <a href="img/0.mp4">下载视频</a></div>
			
		        </video>
							
							<p>六年的互联网整合营销专业实战经验，有效的解决了中小企业网络营销：开展难、效果差、成本高、推广平台单一等瓶颈，以最低投入、最短时间、最多平台、最大效益的情况下实现真正的网络营销，不断增加企业及个人的曝光率，提高转化率。一站式营销解决方案，为您开拓市场，重塑品牌！</p>
							<p>如何实现网络营销品牌竞争优势、突显差异化、明确定位呢?多年来经历了网络营销市场的磨砺和对全国网络营销市场的分析与了解，单一的网咯推广手段，只能让企业陷入一个网络营销恶性循环中去，甚至不相信互联网，对互联网失去信心，认为自己不适合网络营销。企业现在需要做的不仅仅是怎么样让你的增加曝光率，而是要考虑用户的习惯、用户的体验、更贴合用户，从而达到营销的目的。</p>
						</div>
						<ul>
							<li>
                               
                                 <br />
                                 <br />
								<h2><a href="consulting.aspx"><span class="last">更多资讯>></span></a></h2>
								
							</li>
							<li>
								<h2></h2>
                                </li>
                            <%foreach (System.Data.DataRow dr in newsinfotable.Rows)
                                         {%>
								<li>
                                    <span><%=dr[6].ToString().Split(' ')[0] %></span>
                                    --------
                                    <a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 15) %></a>
								</li>
								<%} %>
							
						</ul>
					</div>
					<div id="calendar">
						<h3>热点内容</h3>
						<ul>
                             <%foreach (System.Data.DataRow dr in newsinfotable.Rows)
                                         {%>
							<li>
								<div>
                                 
									<span>△</span>
									<h2><a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 19) %></a></h2>
								</div>
								<p><%=dr[4].ToString().Substring(0,80) %>......</p>
                               <%-- <%=curtnew.newsContent %>--%>
							</li>
						<%} %>
								
								
						</ul>
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
<div style="display:none"><script src='http://v7.cnzz.com/stat.php?id=155540&web_id=155540' language='JavaScript' charset='gb2312'></script></div></body>
</html>
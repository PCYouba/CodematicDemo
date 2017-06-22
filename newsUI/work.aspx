<%@ Page Title="" Language="C#" MasterPageFile="~/NewsMoban.Master" AutoEventWireup="true" CodeBehind="work.aspx.cs" Inherits="newsUI.work" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to <span class="last">P.C.Y新闻发布平台</span>--服务项目</h1>
   
    <div>
         <h1>微博推广</h1>
        <ul>
        <%foreach (System.Data.DataRow  dr in newstableweibo.Rows)
        {%>
            <li>
                <h4>
         <a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 15) %>...</a> 
                    -----------------
                    <span><%=dr[6].ToString().Split(' ')[0] %></span>
                </h4>
            </li>
      <% }%>
        </ul>
    </div>
   
     <div>
         <h1>微信推广</h1>
        <ul>
        <%foreach (System.Data.DataRow  dr in newstableweixin.Rows)
        {%>
            <li>
                <h4>
         <a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 15) %>...</a> 
                    -----------------
                    <span><%=dr[6].ToString().Split(' ')[0] %></span>
                </h4>
            </li>
      <% }%>
        </ul>
    </div>

      <div>
         <h1>软文推广</h1>
        <ul>
        <%foreach (System.Data.DataRow  dr in newstableruanwen.Rows)
        {%>
            <li>
                <h4>
         <a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 15) %>...</a> 
                    -----------------
                    <span><%=dr[6].ToString().Split(' ')[0] %></span>
                </h4>
            </li>
      <% }%>
        </ul>
    </div>

      <div>
         <h1>媒体到场</h1>
        <ul>
        <%foreach (System.Data.DataRow  dr in newstablemeiti.Rows)
        {%>
            <li>
                <h4>
         <a href="newview.aspx?newid=<%=dr[0] %>"><%=dr[3].ToString().PadRight(50).Substring(0, 15) %>...</a> 
                    -----------------
                    <span><%=dr[6].ToString().Split(' ')[0] %></span>
                </h4>
            </li>
      <% }%>
        </ul>
    </div>
    <h2><a href="consulting.aspx">了解更多>></a></h2>
</asp:Content>

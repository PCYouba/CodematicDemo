<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="rr2.Web.commentInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		commentId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommentId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newsId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ownUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblownUserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		checkUserId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheckUserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commentContent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommentContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commentTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommentTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ext1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblext1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ext2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblext2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ext3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblext3" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





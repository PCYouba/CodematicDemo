﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="rr2.Web.newsInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		newsId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TypeId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTypeId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newsTitle
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newsContent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newsCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newsReleaseTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewsReleaseTime" runat="server"></asp:Label>
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





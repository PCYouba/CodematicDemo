<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="rr2.Web.NewInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		newId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newTitle
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newCoutent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewCoutent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		typeId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltypeId" runat="server"></asp:Label>
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
		newTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		newNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnewNR" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





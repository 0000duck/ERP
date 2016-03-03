<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="ERP.Web.Materials.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MMaterial
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMMaterial" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MStandard
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMStandard" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMUnit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWName" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>





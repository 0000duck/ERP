<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="MemberChangePassword.aspx.cs" Inherits="ERP.Web.MemberChangePassword" Title="ERP-修改密码" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
<div style="height:649px">
 <img src="images/修改密码.jpg" />
<br />
<br />
<br />
<br />
<br />
<table align="center" cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td align="center">
    <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F6F3" 
        BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
        Font-Names="Verdana" Font-Size="XX-Large">
        <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
        <PasswordHintStyle Font-Italic="True" ForeColor="#888888" />
        <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
        <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
            ForeColor="White" />
        <TextBoxStyle Font-Size="0.8em" />
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
</asp:ChangePassword>
        </td>
    </tr>
    
</table>
<br />
<br />
<div style="height:649px">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

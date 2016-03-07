<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="WarehouseAdd.aspx.cs" Inherits="ERP.Web.WarehouseAdd" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 207px;
        }
        .style3
        {
            width: 383px;
        }
    .style4
    {
        width: 207px;
        height: 32px;
    }
    .style5
    {
        width: 383px;
        height: 32px;
    }
    .style6
    {
        height: 32px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style1">
                    
                    <tr>
                        <td align="right" class="style2" height="32">
                            仓库名称：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxWName" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxMCode" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxWName" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            仓库面积：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxWArea" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxWArea" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxWArea" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            仓库地址：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxWAddress" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxWAddress" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxWAddress" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            仓库描述：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxWDescribe" runat="server" TextMode="MultiLine"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxWDescribe" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxWDescribe" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>

                    </table>
                    
            </td>
        </tr>
        <tr><td height="32">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="ButtonSubmit" runat="server" Text="提交"  
                style="height: 26px; width: 40px;" onclick="ButtonSubmit_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="reset" name="buttonCancel" id="button" value="重置" />
            
            </td></tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

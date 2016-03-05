<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="AddInWarehouse.aspx.cs" Inherits="ERP.Web.WareHouseManager.WebForm1" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
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
    </style>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
               <img src="img/9.jpg"></td>
        </tr>
        <tr>
            <td>
                <table align="left" cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="right" class="style2" height="32">
                            货物编号：</td>
                        <td align="left" class="style3">
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            当前数量：</td>
                        <td align="left" class="style3" height="32">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td align="left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            最大存储量：</td>
                        <td align="left" class="style3" height="32">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td align="left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            当前最大出货量：</td>
                        <td class="style3" height="32">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            当前最大进货量：</td>
                        <td class="style3" height="32">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            操作类型：</td>
                        <td align="left" class="style3" height="32">
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="入库" />
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="出库" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            进出数量：</td>
                        <td align="left" class="style3" height="32">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> <span style="color: #FF0000">
                            *</span>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                ControlToValidate="TextBox6" ErrorMessage="输入数据不合理！" Type="Double" 
                                Font-Size="Small"></asp:RangeValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            提（送）货人名：</td>
                        <td class="style3" height="32">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBox7" Font-Size="Small"></asp:RequiredFieldValidator></td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
                    
            </td>
        </tr>
        <tr><td height="32">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="确定" onclick="Button1_Click1" 
                style="height: 26px; width: 40px;" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="reset" name="button" id="button" value="取消" />
            </td></tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

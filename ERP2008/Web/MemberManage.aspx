﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="MemberManage.aspx.cs" Inherits="ERP.Web.MemberManage" Title="ERP-查看所有用户" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
<div style="height:649px">
 <!--img src="images/查看所有用户.jpg" /-->
 <br />
<br />
<br />
<br />
<br />
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="center">
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" 
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onrowdatabound="GridView1_RowDataBound" PageSize="5" 
                    Font-Size="Medium">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <Columns>
                        <asp:BoundField DataField="UserId" HeaderText="用户ID" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="UserName" HeaderText="用户名" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LoweredUserName" HeaderText="昵称" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LastActivityDate" HeaderText="最后登录时间" >
                        <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:CommandField ShowDeleteButton="false" ShowEditButton="false" />
                                </Columns>
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                
                <br />
                <br />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

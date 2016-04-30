<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="WarehouseAlter.aspx.cs" Inherits="ERP.Web.WarehouseAlter" Title="ERP-修改仓库信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
<div style="height:649px">
 <!--img src="images/修改仓库信息.jpg" /-->
 <br />
<br />
<br />
<br />
<br />
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="center">
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    onrowcancelingedit="GridView1_RowCancelingEdit" 
                    onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating" DataKeyNames="WID" CellPadding="4" 
                    Font-Size="Small" ForeColor="#333333" HorizontalAlign="Center" AllowPaging="True" 
                    onpageindexchanging="GridView1_PageIndexChanging" PageSize="5" 
                    GridLines="None">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="WID" HeaderText="仓库序号" >
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="WName" HeaderText="仓库名称" >
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="WArea" HeaderText="仓库面积" >
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="WAddress" HeaderText="仓库地址" >
                        
                        </asp:BoundField>
                        <asp:BoundField DataField="WDescribe" HeaderText="仓库描述" >
                        
                        </asp:BoundField>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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

<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="InventoryQuery.aspx.cs" Inherits="ERP.Web.InventoryQuery" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
    <table   cellpadding="0" cellspacing="0" class="style1">
<tr>
    <td>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        查询方式：
        <asp:DropDownList ID="DropDownListMethodSelect" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownListMethodSelect_SelectedIndexChanged" Height="20px" 
                    Width="125px">
                    <asp:ListItem>按物料代码查询</asp:ListItem>
                    <asp:ListItem>按物料名称查询</asp:ListItem>
                    <asp:ListItem>按仓库名称查询</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label" runat="server" Text="请选择物料代码"></asp:Label>
        <asp:DropDownList ID="DropDownListMCode" runat="server"
                    DataSourceID="SqlDataSourceMCode" DataTextField="MCode" DataValueField="MCode" 
                    Height="20px" Width="70px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceMCode" runat="server"
                    ConnectionString="<%$ ConnectionStrings:ERPDB %>" 
                    SelectCommand="SELECT DISTINCT [MCode] FROM [Materials]" 
                    ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownListMName" runat="server"
                    DataSourceID="SqlDataSourceMName" DataTextField="MName" DataValueField="MName" 
                    Height="20px" Width="70px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceMName" runat="server"
                    ConnectionString="<%$ ConnectionStrings:ERPDB %>" 
                    SelectCommand="SELECT DISTINCT [MName] FROM [Materials]" 
                    ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownListWName" runat="server"
                    DataSourceID="SqlDataSourceWName" DataTextField="WName" DataValueField="WName" 
                    Height="20px" Width="70px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceWName" runat="server"
                    ConnectionString="<%$ ConnectionStrings:ERPDB %>" 
                    SelectCommand="SELECT DISTINCT [WName] FROM [Warehouses]" 
                    ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
        </asp:SqlDataSource>
        
        <asp:Button ID="ButtonQuery" runat="server" Text="查询" style="height: 26px" 
        onclick="ButtonQuery_Click" />
    </td>
</tr>

<table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="center">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" 
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onrowdatabound="GridView1_RowDataBound" PageSize="5" Font-Size="Small">
                                <RowStyle BackColor="#EFF3FB" />
                                <Columns>
                                    <asp:BoundField HeaderText="序号" />
                                    <asp:BoundField DataField="MCode" HeaderText="物料代码" />
                                    <asp:BoundField DataField="MName" HeaderText="物料名称" />
                                    <asp:BoundField DataField="MModel" HeaderText="规格型号" />
                                    <asp:BoundField DataField="MMaterial" HeaderText="材质" />
                                    <asp:BoundField DataField="MStandard" HeaderText="国标" />
                                    <asp:BoundField DataField="MUnit" HeaderText="单位" />
                                    <asp:BoundField DataField="MNumber" HeaderText="数量" />
                                    <asp:BoundField DataField="WName" HeaderText="所在仓库" />
                                </Columns>
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>


    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

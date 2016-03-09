<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="RecordsOut.aspx.cs" Inherits="ERP.Web.RecordsOut" Title="无标题页" %>
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
<table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 查询方式<asp:DropDownList ID="DropDownListMethodSelect" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownListMethodSelect_SelectedIndexChanged" Height="20px" 
                    Width="125px">
                    <asp:ListItem>按物料名称查询</asp:ListItem>
                    <asp:ListItem>按日期查询</asp:ListItem>
                    <asp:ListItem>按经办人查询</asp:ListItem>
                </asp:DropDownList> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:Label ID="Label1" runat="server" Text="请输入物料编号："></asp:Label>
                <asp:DropDownList ID="DropDownListRMName" runat="server" 
                    DataSourceID="SqlDataSourceRMName" DataTextField="RMName" DataValueField="RMName" 
                    Height="20px" Width="70px">
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownListRHander" runat="server" 
                    DataSourceID="SqlDataSourceRHander" DataTextField="RHander" 
                    DataValueField="RHander" Visible="False" Height="20px">
                </asp:DropDownList>

                <asp:Button ID="ButtonQuery1" runat="server" onclick="ButtonQuery1_Click" 
                    style="height: 26px" Text="查询" />
                <br />
                </td>
                </tr>
                
     

                <tr>
                    <td height="26">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="从" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownListDateFrom" runat="server" DataTextFormatString="{0:yyyy-MM-dd}"
                        DataSourceID="SqlDataSourceRTime" DataTextField="RTime" DataValueField="RTime" 
                        Visible="False" Height="20px">
                    </asp:DropDownList>
                    <asp:Label ID="Label3" runat="server" Text="到" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownListDateTo" runat="server" DataTextFormatString="{0:yyyy-MM-dd}"
                        DataSourceID="SqlDataSourceRTime" DataTextField="RTime" DataValueField="RTime" 
                        Visible="False" Height="20px">
                    </asp:DropDownList>
                    <asp:Button ID="ButtonQuery2" runat="server" Text="查询" Visible="False" 
                        onclick="ButtonQuery2_Click" />
                    <asp:SqlDataSource ID="SqlDataSourceRMName" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ERPDB%>" 
                        SelectCommand="SELECT DISTINCT [RMName] FROM [Records]" 
                        ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSourceRHander" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ERPDB%>" 
                        SelectCommand="SELECT DISTINCT [RHander] FROM [Records]">
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSourceRTime" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:ERPDB%>" 
                        SelectCommand="SELECT DISTINCT [RTime] FROM [Records]">
                    </asp:SqlDataSource>
                    </td>
                </tr>
                </table>
                
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
                                    <asp:BoundField DataField="RMCode" HeaderText="物料代码" />
                                    <asp:BoundField DataField="RMName" HeaderText="物料名称" />
                                    <asp:BoundField DataField="RQuantity" HeaderText="出库量" />
                                    <asp:BoundField DataField="RHander" HeaderText="经办人" />
                                    <asp:BoundField DataField="RTime" HeaderText="出库时间" />
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
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

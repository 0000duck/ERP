<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="InventoryOut.aspx.cs" Inherits="ERP.Web.InventoryOut" Title="无标题页" %>
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
                            出库物料名称：</td>
                        <td align="left" class="style3">
                            <asp:DropDownList ID="DropDownListMName" runat="server"
                            DataSourceID="SqlDataSourceMName" DataTextField="MName" DataValueField="MName" 
                                onselectedindexchanged="DropDownListMName_SelectedIndexChanged">
                            </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="ButtonQuery" runat="server" Text="查询" 
                                onclick="ButtonQuery_Click" />

                            <asp:SqlDataSource ID="SqlDataSourceMName" runat="server"
                            ConnectionString="<%$ ConnectionStrings:ERPDB %>" 
                            SelectCommand="SELECT [MName] FROM [Materials]" 
                            ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
                            </asp:SqlDataSource>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>

                </table>
                    <br />
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
                                    <asp:BoundField DataField="MNumber" HeaderText="当前数量" />
                                    <asp:BoundField DataField="WName" HeaderText="所在仓库" />
                                </Columns>
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                            <br />
                <table align="center" cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="right" class="style2" height="32">
                            出库数量：
                        </td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxNumberIn" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            提货人：
                        </td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxSenderMan" runat="server" BackColor="Silver" 
                                ReadOnly="True"></asp:TextBox>
                        </td>
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

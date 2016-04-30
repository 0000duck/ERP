<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="InventoryIn.aspx.cs" Inherits="ERP.Web.InventoryIn" Title="ERP-入库管理" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
    <div style="height:649px;">
    <!--img src="images/采购入库.jpg" /-->
<br />
<br />
<br />
<br />
<br />

    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="center">
                            入库物料名称： &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
        </tr>
    </table>
    <br />
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td align="center">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" 
                                onpageindexchanging="GridView1_PageIndexChanging" 
                                onrowdatabound="GridView1_RowDataBound" PageSize="5" 
                Font-Size="Small">
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
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
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
        </td>
    </tr>               
    </table>
    <br />                
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="center" >
                            入库数：
                            <asp:TextBox ID="TextBoxNumberIn" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
         </tr>
         <tr>
         <td align="center">
                            送货人：
                            <asp:TextBox ID="TextBoxSenderMan" runat="server" BackColor="Silver" 
                                ReadOnly="True"></asp:TextBox>
         </td>
         </tr>
         <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
         </tr>
         <tr>
             <td align="center" >          
            <asp:Button ID="ButtonSubmit" runat="server" Text="提交"  
                style="height: 26px; width: 40px;" onclick="ButtonSubmit_Click" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="reset" name="buttonCancel" id="button" value="重置" />
            </td>
        </tr>
    </table>

</div>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

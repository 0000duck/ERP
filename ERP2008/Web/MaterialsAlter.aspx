﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="MaterialsAlter.aspx.cs" Inherits="ERP.Web.MaterialsAlter" Title="无标题页" %>
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
    <table cellspacing="1" class="style1">
    <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            物料名称：<asp:TextBox ID="TextBoxMName" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="ButtonQuery" runat="server" Text="查询" 
                onclick="ButtonQuery_Click" style="height: 26px" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    onrowcancelingedit="GridView1_RowCancelingEdit" 
                    onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
                    onrowupdating="GridView1_RowUpdating" DataKeyNames="MID" CellPadding="4" 
                    Font-Size="Small" ForeColor="#003366" HorizontalAlign="Center" 
                    Width="576px" AllowPaging="True" 
                    onpageindexchanging="GridView1_PageIndexChanging" PageSize="5">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="MID" HeaderText="序号" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MCode" HeaderText="物料代码" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MName" HeaderText="物料名称" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MModel" HeaderText="型号规格" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MMaterial" HeaderText="材质" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MStandard" HeaderText="国标" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MUnit" HeaderText="单位" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MNumber" HeaderText="数量" >
                        <ControlStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="WName" HeaderText="仓库名称" >
                        <ControlStyle Width="150px" />
                        </asp:BoundField>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                    <FooterStyle BackColor="#3399FF" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                
                <br />
                <br />
        </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>

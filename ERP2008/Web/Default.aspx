<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ERP.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolderOperationMenu">
    <table border="0" align="right" cellpadding="0" cellspacing="0">
                                                                                <tr>
                                                                                    <td width="60">
                                                                                        <table width="87%" border="0" cellpadding="0" cellspacing="0">
                                                                                            <tr>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        <input type="checkbox" name="checkbox62" value="checkbox" />
                                                                                                    </div>
                                                                                                </td>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        全选</div>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td width="60">
                                                                                        <table width="90%" border="0" cellpadding="0" cellspacing="0">
                                                                                            <tr>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        <img src="images/22.gif" width="14" height="14" /></div>
                                                                                                </td>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        新增</div>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td width="60">
                                                                                        <table width="90%" border="0" cellpadding="0" cellspacing="0">
                                                                                            <tr>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        <img src="images/33.gif" width="14" height="14" /></div>
                                                                                                </td>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        修改</div>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                    <td width="52">
                                                                                        <table width="88%" border="0" cellpadding="0" cellspacing="0">
                                                                                            <tr>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        <img src="images/11.gif" width="14" height="14" /></div>
                                                                                                </td>
                                                                                                <td class="STYLE1">
                                                                                                    <div align="center">
                                                                                                        删除</div>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                            
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolderRealContent">
    <div style="height:649px">
    <img src="img/Default.jpg">
  </div>
                        
                                            
</asp:Content>

<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolderBottomNav">

                           <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td class="STYLE4">&nbsp;&nbsp;共有 120 条记录，当前第 1/10 页</td>
            <td><table border="0" align="right" cellpadding="0" cellspacing="0">
                <tr>
                  <td width="40"><img src="images/first.gif" width="37" height="15" /></td>
                  <td width="45"><img src="images/back.gif" width="43" height="15" /></td>
                  <td width="45"><img src="images/next.gif" width="43" height="15" /></td>
                  <td width="40"><img src="images/last.gif" width="37" height="15" /></td>
                  <td width="100"><div align="center"><span class="STYLE1">转到第
                    <input name="textfield" type="text" size="4" style="height:12px; width:20px; border:1px solid #999999;" /> 
                    页 </span></div></td>
                  <td width="40"><img src="images/go.gif" width="37" height="15" /></td>
                </tr>
            </table></td>
          </tr>
        </table>                                     
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Dbs.Page11" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Pd1" align="center" ><table id="Page1Table"  text-align="center">
            <tr>
                <td >
                    编号
                </td>
                <td>
                   <asp:TextBox runat="server" Width="80px"></asp:TextBox>
                </td>
                <td> 部门
                <asp:TextBox runat="server" Width="80px"></asp:TextBox>
                </td>
                <td> 
                <asp:Button runat="server" Width="40px" Text="确定" ID="Btn_query" 
                        onclick="Btn_query_Click" /></asp:Button>
                </td>
            </tr>
            <tr>
            <td colspan="4">
               <asp:GridView ID="gvBookInfo" runat="server"  PageSize="3" AllowPaging="True" 
                    AutoGenerateColumns="False" Font-Size="9pt" 
                    OnPageIndexChanging="gvBookInfo_PageIndexChanging" 
                    OnRowDeleting="gvBookInfo_RowDeleting"  Width="678px" HorizontalAlign="Center" 
                    onselectedindexchanged="gvBookInfo_SelectedIndexChanged">
                    <RowStyle HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#DFF5F5" />
                    <Columns>
                        <asp:BoundField DataField="productid" HeaderText="条形码" ReadOnly="True" />
                        <asp:BoundField DataField="productname" HeaderText="名称" />
                        <asp:BoundField DataField="color" HeaderText="颜色" />
                        <asp:BoundField DataField="supplierid" HeaderText="供应商编号" />
                        <asp:BoundField DataField="description" HeaderText="备注" />
                        <asp:BoundField DataField="price" HeaderText="价格" />
                      <%--  <asp:HyperLinkField DataNavigateUrlFormatString="AddBook.aspx?bookcode={0}" HeaderText="详情"
                            Text="详情" DataNavigateUrlFields="bookcode" >
                            <ControlStyle ForeColor="Black" />
                            <ItemStyle ForeColor="Black" />
                            <HeaderStyle ForeColor="Black" />
                        </asp:HyperLinkField>
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="True" >
                            <HeaderStyle ForeColor="Black" />
                            <ItemStyle ForeColor="Black" />
                            <ControlStyle ForeColor="Black" />
                        </asp:CommandField>--%>
                    </Columns>
                </asp:GridView>
            </td>
            </tr>
    </table>
</div>
<div>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
</div>
</asp:Content>

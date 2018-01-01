<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Dbs.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div align="center">

 <table class="daohang2" border="1px" border-color="Blue">
   <tr>
    <td>编号
    </td>
    <td colspan="2"><asp:TextBox runat="server" ID="Code"></asp:TextBox></td>
   </tr>
   <tr>
     <td>名称
     </td>
     <td colspan="2"><asp:TextBox runat="server" ID="Name"></asp:TextBox></td>
   </tr>
   <tr align="center">
        <td>性别
        </td>
        
        <td><input type="radio" id="radio2" name="group1"  />男</td>
       
         <td><input type="radio" id="radio1" name="group1" />女</td>
   </tr>
   <tr>
       <td>备注
       </td>
       <td colspan="2">
       <asp:TextBox runat="server" ID="TbMemo" Height="90px"></asp:TextBox></td>
   </tr>
   <tr>
    <td>&nbsp</td>
    <td align="right"><asp:Button runat="server" ID="BtnSign" Text="注册" 
            onclick="BtnSign_Click" />
    </td>
    <td><asp:Button runat="server" ID="BtnCancel" Text="取消" />
    </td>
   </tr>
   </table>
  
</div>
</asp:Content>

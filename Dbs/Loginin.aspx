<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginin.aspx.cs" Inherits="Dbs.Loginin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link  rel="Stylesheet" href="../css/css.css" type="text/css" />
   <%-- <link rel="stylesheet" href="wcss.css" type="text/css" />--%>
</head>
<body>
    <form id="form1" runat="server">
    <div  id="ddiv">
        <table class="waikuang" >
            <tr>
                <td colspan="3">
                </td>
            </tr>
                <td colspan="2">用户名</td>
                <td><asp:TextBox runat="server" ID="T_Name" ></asp:TextBox></td>
            <tr>
                 <td colspan="2">密码</td>
                <td><asp:TextBox ID="T_PS" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td width="80px">
            </td >
            <td align="center">
            <asp:Button runat="server" ID="B_L" Text="登陆" onclick="B_L_Click" Width="44px" />
            </td>
            <td align="center">
                <asp:Button runat="server" ID="B_C" Text="取消" />
            </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

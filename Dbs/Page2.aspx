﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Dbs.Page2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:gridview ID="Gridview1" runat="server"  AllowPaging="True"  PageSize="5" 
                    AutoGenerateColumns="False" Font-Size="9pt" ></asp:gridview>
    </div>
    </form>
</body>
</html>


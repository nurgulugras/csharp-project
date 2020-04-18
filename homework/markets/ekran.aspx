<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ekran.aspx.cs" Inherits="ekran" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr><td>
            <asp:Label ID="lburun" runat="server" Text="Aradığınız Ürün Nedir?"></asp:Label>
            </td></tr>
        <tr><td>
            <asp:TextBox ID="tburun" runat="server" OnTextChanged="tburun_TextChanged"></asp:TextBox>
            </td></tr>
        <tr><td>
            <asp:GridView ID="gvurun" runat="server">
            </asp:GridView>
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

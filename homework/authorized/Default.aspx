<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr><td colspan="2" align="center">
            <asp:Label ID="Label1" runat="server" Text="Sitemize Hoşgeldiniz:"></asp:Label>
            </td></tr>
        <tr><td>
            <asp:Label ID="Label2" runat="server" Text="Kullanıcı Adınız:"></asp:Label>
            <td>
                <asp:TextBox ID="tbkul" runat="server"></asp:TextBox>
            </td></td></tr>
        <tr><td>
            <asp:Label ID="Label3" runat="server" Text="Şifreniz:"></asp:Label>
            <td>
                <asp:TextBox ID="tbsifre" runat="server"></asp:TextBox>
            </td></td></tr>
         <tr><td colspan="2" align="center">
             <asp:Button ID="btgiris" runat="server" OnClick="btgiris_Click" Text="Giriş" />
             </td></tr>
        
    </table>
    </div>
    </form>
</body>
</html>

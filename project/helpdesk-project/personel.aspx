<%@ Page Language="C#" AutoEventWireup="true" CodeFile="personel.aspx.cs" Inherits="personel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><br /><br /><br /><br /><br />
    <table align="center" width="50%">
        <tr><td>
            <asp:Label ID="Label1" runat="server" Text="Sorun Gönderen Kullanıcı :"></asp:Label>
            </td><td>
                <asp:Label ID="lbKul" runat="server"></asp:Label>
            </td></tr>
         <tr><td>
             <asp:Label ID="Label2" runat="server" Text="Sorunu : "></asp:Label>
             </td><td>
                 <asp:Label ID="lbSor" runat="server"></asp:Label>
             </td></tr>
         <tr><td>
             <asp:Label ID="Label3" runat="server" Text="Çözüm : "></asp:Label>
             </td><td>
                 <asp:TextBox ID="tbCozum" runat="server"></asp:TextBox>
             </td></tr>
         <tr><td colspan="2" align="center">
             <asp:Button ID="btGonder" runat="server" Text="Gönder" />
             </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

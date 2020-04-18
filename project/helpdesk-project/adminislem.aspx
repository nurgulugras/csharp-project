<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminislem.aspx.cs" Inherits="adminislem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" width="100%">
        <tr><td align="center">
            <asp:GridView ID="gvSorun" runat="server" OnSelectedIndexChanged="gvSorun_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seç" />
                </Columns>
            </asp:GridView>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Seçilen Kullanıcı :"></asp:Label>
&nbsp;<asp:TextBox ID="tbSecKul" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Sorunu :"></asp:Label>
&nbsp;<asp:TextBox ID="tbSorun" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Sorunun Gönderileceği Personel :"></asp:Label>
&nbsp;<asp:TextBox ID="tbPersonel" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lbAciklama" runat="server"></asp:Label>
            </td>
        </tr>
        <tr><td align="center">
            <asp:GridView ID="gvDestek" runat="server" OnSelectedIndexChanged="gvDestek_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seç" />
                </Columns>
            </asp:GridView>
            </td><td align="center">
                <asp:Button ID="btGonder" runat="server" Text="Gönder" OnClick="btGonder_Click" />
                <br />
                <br />
                <br />
                <asp:Button ID="btCikis" runat="server" OnClick="btCikis_Click" Text="Çıkış" />
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

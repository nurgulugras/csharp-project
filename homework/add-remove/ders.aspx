<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ders.aspx.cs" Inherits="ders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
        <tr><td colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Ders Ekle Sil"></asp:Label>
            </td></tr>
        <tr><td colspan="2">
            <asp:GridView ID="gvekle" runat="server" OnSelectedIndexChanged="gvekle_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="ekle" />
                </Columns>
            </asp:GridView>
            </td></tr>
        <tr><td colspan="2">
            <asp:GridView ID="gvsil" runat="server" OnSelectedIndexChanged="gvsil_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="sil" />
                </Columns>
            </asp:GridView>
            </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

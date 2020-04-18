<%@ Page Language="C#" AutoEventWireup="true" CodeFile="otobus.aspx.cs" Inherits="otobus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" width="50%">
        <tr> <td align="center">
            <asp:Button ID="bt1" runat="server" Font-Bold="True" Font-Size="Larger" Text="1" OnClick="bt1_Click" />
            </td><td align="center">
                <asp:Button ID="bt2" runat="server" Font-Bold="True" Font-Size="Larger" Text="2" OnClick="bt2_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="bt3" runat="server" Font-Bold="True" Font-Size="Larger" Text="3" OnClick="bt3_Click" />
            </td><td align="center">
                <asp:Button ID="bt4" runat="server" Font-Bold="True" Font-Size="Larger" Text="4" OnClick="bt4_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="bt5" runat="server" Font-Bold="True" Font-Size="Larger" Text="5" OnClick="bt5_Click" />
            </td><td align="center">
                <asp:Button ID="bt6" runat="server" Font-Bold="True" Font-Size="Larger" Text="6" OnClick="bt6_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="bt7" runat="server" Font-Bold="True" Font-Size="Larger" Text="7" OnClick="bt7_Click" />
            </td><td align="center">
                <asp:Button ID="bt8" runat="server" Font-Bold="True" Font-Size="Larger" Text="8" OnClick="bt8_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="bt9" runat="server" Font-Bold="True" Font-Size="Larger" Text="9" OnClick="bt9_Click" />
            </td><td align="center">
                <asp:Button ID="bt10" runat="server" Font-Bold="True" Font-Size="Larger" Text="10" OnClick="bt10_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="bt11" runat="server" Font-Bold="True" Font-Size="Larger" Text="11" OnClick="bt11_Click" />
            </td><td align="center">
                <asp:Button ID="bt12" runat="server" Font-Bold="True" Font-Size="Larger" Text="12" OnClick="bt12_Click" />
            </td></tr>
        <tr> <td align="center">
            <asp:Label ID="Label2" runat="server" Text="koltuk no:"></asp:Label>
            </td><td align="center">
                <asp:TextBox ID="tbkoltuk" runat="server" ></asp:TextBox>
            </td></tr>
        <tr> <td align="center">
            <asp:Label ID="Label1" runat="server" Text="yolcu ismi:"></asp:Label>
            </td><td align="center">
                <asp:TextBox ID="tbyolcu" runat="server"></asp:TextBox>
            </td></tr>
        <tr> <td align="center">
            <asp:Button ID="btiptal" runat="server" Text="iptal" OnClick="btiptal_Click" />
            </td><td align="center">
                <asp:Button ID="btsat" runat="server" Text="sat" OnClick="btsat_Click" />
            </td></tr>
        
    </table>
    </div>
    </form>
</body>
</html>

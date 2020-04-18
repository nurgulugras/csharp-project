<%@ Page Language="C#" AutoEventWireup="true" CodeFile="randevual.aspx.cs" Inherits="randevual" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" >
        <tr>
            <td>
                Poliknikler:<td>
                Doktorlar:<td>
                &nbsp;</td>
        </tr>
        <tr><td>
            <asp:ListBox ID="lbPol" runat="server" Height="152px" Width="92px" AutoPostBack="True" OnSelectedIndexChanged="lbPol_SelectedIndexChanged"></asp:ListBox>
            <td>
                <asp:ListBox ID="lbDoktor" runat="server" Height="154px" Width="98px" AutoPostBack="True"></asp:ListBox>
            <td>
                <asp:Calendar ID="cTarih" runat="server" OnSelectionChanged="cTarih_SelectionChanged"></asp:Calendar>
            </td></td></td></tr>
       
        <tr><td colspan="3">&nbsp; Tc:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; İsim:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Saat:</td></tr>
        <tr><td>
            <asp:TextBox ID="Tbtc" runat="server"></asp:TextBox>
            <td>
                <asp:TextBox ID="Tbisim" runat="server"></asp:TextBox>
            <td>
                <asp:ListBox ID="lbsaat" runat="server" AutoPostBack="True" Height="114px" Width="114px"></asp:ListBox>
            </td></td></td></tr>
        <tr><td colspan="2">
            <asp:GridView ID="gvRandevu" runat="server">
            </asp:GridView>
            <td>
                <asp:Button ID="btRandevu" runat="server" OnClick="btRandevu_Click" Text="Randevu Al" />
            </td></td></tr>
    </table>
    </div>
    </form>
</body>
</html>

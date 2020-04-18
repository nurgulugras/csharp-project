<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kullanici.aspx.cs" Inherits="kullanici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div><br /><br /><br /><br /><br />
    <table align="center" width="50%">
        <tr><td> Alan Türleri : <br />
            <asp:DropDownList ID="ddlTur" runat="server" OnSelectedIndexChanged="ddlTur_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            </td><td> 
                Sorunu Yazınız :<br /> <asp:TextBox ID="tbSorun" runat="server"></asp:TextBox>
            </td><td>
                <asp:Button ID="btYolla" runat="server" Text="Yolla" OnClick="btYolla_Click" />
            </td></tr>
        <tr><td> Çözülen Sorunlar : <br />
            <asp:ListBox ID="lbSorun" runat="server" OnSelectedIndexChanged="lbSorun_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
            </td><td>
               Çözüm : <br /> <asp:GridView ID="gvCozum" runat="server">
                </asp:GridView>
            </td>
            <td> 
                <asp:Label ID="lbHaber" runat="server"></asp:Label>
                <br /><br />
                <asp:Button ID="btCikis" runat="server" OnClick="btCikis_Click" Text="Çıkış" />
            </td>
        </tr>
       
    </table>
    </div>
    </form>
</body>
</html>

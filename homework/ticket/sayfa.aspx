<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sayfa.aspx.cs" Inherits="sayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" width="50%">
        <tr><td align="center">Nereden ?</td></tr>
          <tr><td align="center">
              <asp:DropDownList ID="ddlNereden" runat="server">
              </asp:DropDownList>
              </td></tr>
          <tr><td align="center">Nereye ?</td></tr>
          <tr><td align="center">
              <asp:DropDownList ID="ddlNereye" runat="server">
              </asp:DropDownList>
              </td></tr>
          <tr><td align="center">Ne zaman ?</td></tr>
          <tr><td align="center">
              <asp:Calendar ID="cTakvim" runat="server"></asp:Calendar>
              </td></tr>
          <tr><td align="center">
              <asp:Button ID="btAra" runat="server" OnClick="btAra_Click" Text="Sefer Ara" />
              </td></tr>
          <tr><td align="center">
              <asp:GridView ID="gvSeferler" runat="server" OnSelectedIndexChanged="gvSeferler_SelectedIndexChanged">
                  <Columns>
                      <asp:ButtonField CommandName="Select" Text="Sefer Seç" />
                  </Columns>
              </asp:GridView>
              </td></tr>
    </table>
    </div>
    </form>
</body>
</html>

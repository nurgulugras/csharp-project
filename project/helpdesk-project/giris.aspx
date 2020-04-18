<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    </style>
   
        
    
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
   
        
    
</head>
<body >
    <form id="form1"  runat="server">
        
    <div>
  <table align="center">
      <tr><td colspan="2">
          <asp:Label ID="Label1" runat="server" Text="Yardım Masasına Hoşgeldiniz"></asp:Label>
          </td></tr>
       <tr><td>
           <asp:Label ID="Label2" runat="server" Text="Kullanıcı Adnız:"></asp:Label>
           </td></tr>
       <tr><td colspan="2">
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           </td></tr>
       <tr><td>
           <asp:Label ID="Label3" runat="server" Text="Şifreniz:"></asp:Label>
           </td></tr>
       <tr><td colspan="2">
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           </td></tr>
       <tr><td colspan="2">
           <asp:Button ID="btGiris" runat="server" OnClick="Button1_Click" Text="Giriş" />
           </td></tr>
       <tr><td colspan="2" align="center" class="auto-style1">
           <asp:Label ID="lbUyari" runat="server" Text="Label"></asp:Label>
           </td></tr>
  </table>
    </div>
    </form>
</body>
</html>

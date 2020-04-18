<%@ Page Language="C#" AutoEventWireup="true" CodeFile="proje.aspx.cs" Inherits="proje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
             <td colspan="3" align="center">
                 <asp:GridView ID="gvOgrenci" runat="server" OnSelectedIndexChanged="gvOgrenci_SelectedIndexChanged">
                     <Columns>
                         <asp:ButtonField ButtonType="Button" CommandName="Select" Text="seç" />
                     </Columns>
                 </asp:GridView>
                </td>
            </tr>
            <tr>
             <td rowspan="3">
                 <asp:ListBox ID="lbGrup" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:TextBox ID="tbProje" runat="server"></asp:TextBox>
                </td>
                
               
                
            </tr>
            <tr><td align="center">
                <asp:Button ID="Button1" runat="server" Text="btKaydet" OnClick="Button1_Click" />
                </td></tr>
        </table>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCookie.aspx.cs" Inherits="Client_server_Site_Example.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 196px;
            height: 204px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem>Hp</asp:ListItem>
                            <asp:ListItem>Dell</asp:ListItem>
                            <asp:ListItem>Lenovo</asp:ListItem>
                            <asp:ListItem>Asus</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GotoReadyCookie" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Readcookie.aspx.cs" Inherits="Client_server_Site_Example.Readcookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 195px;
            height: 209px;
        }
        .auto-style2 {
            height: 52px;
        }
        .auto-style3 {
            width: 25px;
        }
        .auto-style4 {
            height: 52px;
            width: 25px;
        }
        .auto-style5 {
            width: 25px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">&nbsp; Item selected by User<br />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:BulletedList ID="BulletedList1" runat="server" OnClick="BulletedList1_Click">
                            <asp:ListItem>SamSung</asp:ListItem>
                            <asp:ListItem>HP</asp:ListItem>
                            <asp:ListItem>Dell</asp:ListItem>
                            <asp:ListItem>Asus</asp:ListItem>
                            <asp:ListItem>Lenovo</asp:ListItem>
                        </asp:BulletedList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p>
        ;</p>
</body>
</html>

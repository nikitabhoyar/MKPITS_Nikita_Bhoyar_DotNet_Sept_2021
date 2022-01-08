﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspNetProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 220px;
        }
        .auto-style3 {
            height: 45px;
        }
        .auto-style4 {
            width: 220px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm1.aspx" Text="Button" />
            </td>
            <td>PostBack Url<br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm2.aspx">LinkButton</asp:LinkButton>
            </td>
            <td>PostBack Url<br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm2.aspx?Name= Nikita">HyperLink</asp:HyperLink>
            </td>
            <td class="auto-style5">Navigate Url<br />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button3" runat="server" Text="How To Direct" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <div class="auto-style3">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Server Transmitted" />
            <br />
            <br />
            <br />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>

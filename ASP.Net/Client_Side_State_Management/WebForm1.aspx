<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client_server_Site_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 24%;
            height: 187px;
        }
        .auto-style5 {
            width: 106px;
            height: 22px;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style7 {
            width: 106px;
            height: 58px;
        }
        .auto-style8 {
            height: 58px;
        }
        .auto-style9 {
            width: 106px;
            height: 18px;
        }
        .auto-style10 {
            height: 18px;
        }
        .auto-style11 {
            width: 106px;
            height: 10px;
        }
        .auto-style12 {
            height: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">Enter a Number</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Label1" runat="server" Text="Answer1"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Button ID="Button3" runat="server" Height="35px" OnClick="Button3_Click" Text="Step1" Width="126px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Enter a Number</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="118px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="Answer2"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="Button4" runat="server" Height="35px" OnClick="Button4_Click" Text="Step2" Width="124px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

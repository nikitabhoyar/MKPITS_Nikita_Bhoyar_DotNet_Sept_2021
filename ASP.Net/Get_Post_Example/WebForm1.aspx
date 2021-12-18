<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Get_Post_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style8 {
            width: 225px;
            height: 218px;
            border: 1px solid #0000FF;
            background-color: #00FFFF;
        }
        .auto-style9 {
            width: 112px;
        }
        .auto-style10 {
            height: 27px;
        }
        .auto-style11 {
            width: 112px;
            height: 27px;
        }
        .auto-style12 {
            height: 37px;
        }
        .auto-style13 {
            width: 112px;
            height: 37px;
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
       
        <table class="auto-style8">
            <tr>
                <td colspan="2">Get Method </td>
            </tr>
            <tr>
                <td>Firstname</td>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" Text="............"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Lastname</td>
                <td class="auto-style13">
                    <asp:Label ID="Label2" runat="server" Text="........."></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Rollno</td>
                <td class="auto-style9">
                    <asp:Label ID="Label3" runat="server" Text="........."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Class<br />
                </td>
                <td class="auto-style11">
                    <asp:Label ID="Label4" runat="server" Text="..........."></asp:Label>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td class="auto-style9">
                    <asp:Label ID="Label5" runat="server" Text="..........."></asp:Label>
                </td>
            </tr>
        </table>
       
    </form>
        </center>
</body>
</html>

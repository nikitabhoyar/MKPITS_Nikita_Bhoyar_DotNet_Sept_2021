<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Get_Post_Example.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 266px;
            height: 269px;
            border: 1px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style10 {
            width: 50px;
        }
        .auto-style11 {
            width: 50px;
            height: 52px;
        }
        .auto-style12 {
            width: 50px;
            height: 54px;
        }
        .auto-style14 {
            width: 20px;
            height: 52px;
        }
        .auto-style15 {
            width: 20px;
            height: 54px;
        }
        .auto-style16 {
            width: 20px;
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style4">
                <tr>
                    <td colspan="2">&nbsp;Get Example&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Firstname</td>
                    <td class="auto-style16">
                        <asp:Label ID="Label1" runat="server" Text=".........."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Lastname</td>
                    <td class="auto-style14">
                        <asp:Label ID="Label2" runat="server" Text=".........."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">Rollno</td>
                    <td class="auto-style16">
                        <asp:Label ID="Label3" runat="server" Text="..........."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Class</td>
                    <td class="auto-style15">
                        <asp:Label ID="Label4" runat="server" Text="..........."></asp:Label>
                    </td>
                </tr>
               
              </table>
             </div>
        </form>
    </center>
         </body>
    </html>

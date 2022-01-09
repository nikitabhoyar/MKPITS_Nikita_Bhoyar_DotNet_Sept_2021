<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_Example.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 762px;
            height: 394px;
        }
        .auto-style2 {
            width: 240px;
        }
        .auto-style3 {
            width: 240px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="5">LINQ Operator.<br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">Simple query var result = from n in num select n ;</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="69px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">var dresult = from d in digits select;reverse();</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList3" runat="server" Width="69px">
                        </asp:DropDownList>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">
                        <br />
                        unique factor </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList4" runat="server" Width="69px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">Union of 2 Array numbers</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Width="69px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">Intersect of 2 array Intersect </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DropDownList6" runat="server" Width="69px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">Except Other Array</td>
                    <td><asp:DropDownList ID="DropDownList7" runat="server" Width="69px" Height="16px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">Aggregate Functions</td>
                    <td>Max ,&nbsp; Min , Average , Sum , Count.</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;Max&nbsp;</td>
                    <td class="auto-style2">Min</td>
                    <td class="auto-style2">Average</td>
                    <td class="auto-style2">Sum</td>
                    <td>Count</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Any is used like OR </td>
                    <td class="auto-style2">All is used like AND</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

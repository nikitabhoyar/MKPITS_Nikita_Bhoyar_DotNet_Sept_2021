<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ajax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 417px;
            height: 234px;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 133px;
        }
        .auto-style4 {
            width: 150px;
            height: 2px;
        }
        .auto-style5 {
            width: 133px;
            height: 2px;
        }
        .auto-style6 {
            height: 2px;
        }
        .auto-style7 {
            width: 150px;
            height: 33px;
        }
        .auto-style8 {
            width: 133px;
            height: 33px;
        }
        .auto-style9 {
            height: 33px;
        }
        .auto-style10 {
            width: 150px;
            height: 12px;
        }
        .auto-style11 {
            width: 133px;
            height: 12px;
        }
        .auto-style12 {
            height: 12px;
        }
        .auto-style13 {
            width: 150px;
            height: 41px;
        }
        .auto-style14 {
            width: 133px;
            height: 41px;
        }
        .auto-style15 {
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Username</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="173px"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" runat="server" BehaviorID="TextBox3_TextBoxWatermarkExtender" TargetControlID="TextBox3" WatermarkText="Enter email or mobile no" />
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style7">Password</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox2" runat="server" Height="19px" Width="174px"></asp:TextBox>
                        <ajaxToolkit:PasswordStrength ID="TextBox2_PasswordStrength" runat="server" BehaviorID="TextBox2_PasswordStrength" TargetControlID="TextBox2" />
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3"></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

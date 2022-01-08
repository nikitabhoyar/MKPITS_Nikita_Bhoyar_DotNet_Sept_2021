<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Asp.Net_Validation_Controls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style7 {
            width: 722px;
        }
        .auto-style8 {
            width: 500px;
            height: 459px;
        }
        .auto-style9 {
            width: 122px;
        }
        .auto-style10 {
            width: 133px;
        }
        .auto-style11 {
            width: 122px;
            height: 56px;
        }
        .auto-style12 {
            width: 133px;
            height: 56px;
        }
        .auto-style13 {
            height: 56px;
        }
        .auto-style14 {
            width: 122px;
            height: 44px;
        }
        .auto-style15 {
            width: 133px;
            height: 44px;
        }
        .auto-style16 {
            height: 44px;
        }
        .auto-style17 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style7">
            <table class="auto-style8">
                <tr>
                    <td class="auto-style17" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Validation Controls&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Name</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox1" runat="server" Height="26px"></asp:TextBox>
&nbsp;</td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your FullName"></asp:RequiredFieldValidator>
                        +
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">Contact</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBox2" runat="server" Height="27px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter 10 Digit Mobile Number" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Email</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox3" runat="server" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">Age</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="TextBox4" runat="server" Height="25px"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Age should between 18 and 60" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Password</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox5" runat="server" Height="23px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Password missmatch"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Confirm Password</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox6" runat="server" Height="24px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Button ID="Button1" runat="server" Text="Button" Width="128px" />
                    </td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>

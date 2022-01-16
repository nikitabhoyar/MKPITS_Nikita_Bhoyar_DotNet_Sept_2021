<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Theme="Green"    CodeBehind="WebForm1.aspx.cs"  Inherits="Master_Page_Example2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 259px; height: 158px">
    <tr>
        <td colspan="2" style="height: 40px">&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="ProductList"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 107px">
            <asp:ListBox ID="ListBox1" runat="server" Width="128px">
                <asp:ListItem>Mobile</asp:ListItem>
                <asp:ListItem>Laptop</asp:ListItem>
                <asp:ListItem>Camera</asp:ListItem>
                <asp:ListItem>Phone11</asp:ListItem>
                <asp:ListItem>Hp Headset</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 107px; height: 20px;"></td>
        <td style="height: 20px"></td>
    </tr>
    <tr>
        <td style="height: 20px;" colspan="2">&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" Width="79px" />
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 107px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>


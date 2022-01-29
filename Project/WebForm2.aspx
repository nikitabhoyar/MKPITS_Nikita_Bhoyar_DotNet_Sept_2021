<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Project_of_Asp.Net.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 166px">
    <tr>
        <td colspan="2">&nbsp; </td>
    </tr>
    <tr>
        <td style="height: 20px; width: 102px;">
            <asp:Label ID="Label2" runat="server" Text="Product List" SkinID="Head"></asp:Label>
        </td>
        <td style="height: 20px"></td>
    </tr>
    <tr>
        <td style="width: 102px">
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Mobile</asp:ListItem>
                <asp:ListItem>Laptops</asp:ListItem>
                <asp:ListItem>PC</asp:ListItem>
                <asp:ListItem>Camera</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 102px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 102px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" Theme ="Pink" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project_of_Asp.Net.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 185px">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label4" runat="server" SkinID="Head" Text="Registration Form"></asp:Label>
            <br />
        </td>
    </tr>
    <tr>
        <td style="width: 144px">
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" style="margin-left: 40"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 144px">
            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="22px" style="margin-left: 40"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 144px">
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

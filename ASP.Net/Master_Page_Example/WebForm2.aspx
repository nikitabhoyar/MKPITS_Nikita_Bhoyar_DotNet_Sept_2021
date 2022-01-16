<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Theme="Green" CodeBehind="WebForm2.aspx.cs" Inherits="Master_Page_Example2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 221px; height: 132px">
    <tr>
        <td colspan="2">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Text="Registration Form"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 58px; height: 34px; color: #FF0066;">
            <asp:Label ID="Label5" runat="server" ForeColor="#FF3300" Text="Name"></asp:Label>
        </td>
        <td style="height: 34px">
            <asp:TextBox ID="TextBox1" runat="server" Width="157px" style="margin-left: 0"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 58px">
            <asp:Label ID="Label4" runat="server" Text="Address" ForeColor="#FF6600"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" ForeColor="#FF0066" Text="Button" />
        </td>
    </tr>
</table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Project_of_Asp.Net.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 157px; height: 163px">
    <tr>
        <td colspan="2" style="height: 11px">Forms<br />
        </td>
    </tr>
    <tr>
        <td style="width: 188px">
            <asp:Label ID="Label2" runat="server" BackColor="Aqua" BorderColor="Black" ForeColor="#6600CC" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" ForeColor="#FF6699" style="margin-left: 50" Width="80px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 188px">
            <asp:Label ID="Label3" runat="server" BackColor="#66FFFF" ForeColor="#6600FF" Text="Address"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" ForeColor="#FF99CC" style="margin-left: 50" Width="80px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#66FFFF" ForeColor="#9966FF" Text="Button" />
        </td>
    </tr>
</table>
</asp:Content>

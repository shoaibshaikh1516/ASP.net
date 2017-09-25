<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            color: #CC0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
    <span class="style5">Welcome&nbsp;</span>&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Guest"></asp:Label>
    &nbsp;&nbsp;to hompage&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
</asp:Content>


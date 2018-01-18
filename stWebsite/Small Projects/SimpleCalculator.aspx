<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SimpleCalculator.aspx.cs" Inherits="Small_Projects_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1>Simple Calculator</h1>

    <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>

     <br /> <br />
    <asp:Label ID="Label1" runat="server" Text="First Value:"></asp:Label>
    <asp:TextBox ID="firstNumber_TB" runat="server"></asp:TextBox>

    <br />
    <asp:Label ID="Label2" runat="server" Text="Second Value:"></asp:Label>
    <asp:TextBox ID="secondNumber_TB" runat="server"></asp:TextBox>

    <br />

    <asp:Button ID="add_BTN" runat="server" Text="+" OnClick="add_BTN_Click" />
    <asp:Button ID="subtract_BTN" runat="server" Text="-" OnClick="subtract_BTN_Click" />
    <asp:Button ID="multiply_BTN" runat="server" Text="*" OnClick="multiply_BTN_Click" />
    <asp:Button ID="division_BTN" runat="server" Text="/" OnClick="division_BTN_Click" />

    <br />

    <asp:Label ID="answer" runat="server" Text=""></asp:Label>
</asp:Content>


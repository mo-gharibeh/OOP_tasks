<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="forms.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Reset1 {
            width: 171px;
            height: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Num1 "></asp:Label>
             &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Num2 "></asp:Label>
             &nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="60px" Text="+" Width="111px" Font-Size="Larger" OnClick="Button1_Click" BorderStyle="Outset" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="60px" Text="-" Width="111px" Font-Size="Larger" OnClick="Button2_Click" BorderStyle="Outset" />
        &nbsp;<br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="60px" Text="*" Width="111px" Font-Size="Larger" OnClick="Button3_Click" BorderStyle="Groove" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="60px" Text="/" Width="111px" Font-Size="Larger" OnClick="Button4_Click" BorderStyle="Outset" />
    </form>
</body>
</html>

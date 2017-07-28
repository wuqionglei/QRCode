<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QRCode.aspx.cs" Inherits="QRCode.QRCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 463px">
    <form id="form1" runat="server">
        <asp:Button ID="btnStart" runat="server" Height="31px" OnClick="btnStart_Click" Text="生成" Width="73px" />
        <asp:TextBox ID="tbxMsg" runat="server" Height="29px" Width="230px"></asp:TextBox>
        <p>
            <asp:Image ID="Image" runat="server" Height="308px" Width="308px" />
        </p>
    </form>
</body>
</html>

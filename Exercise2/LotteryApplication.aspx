<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LotteryApplication.aspx.cs" Inherits="LotteryApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Lottokone</h1>
        <p>Valitse haluamasi lotto:</p>

        <asp:DropDownList ID="ddlLotteryType" runat="server">
            <asp:ListItem Value="Lotto"></asp:ListItem>
            <asp:ListItem Value="Viking Lotto"></asp:ListItem>
        </asp:DropDownList><br />

        <p>Montako riviä haluat arpoa:</p>
        <asp:TextBox ID="txtNumbersToDraw" runat="server" />
        <br /><br />

        <asp:Button ID="btnDrawNumbers" runat="server" Text="Arvo rivit" OnClick="btnDrawNumbers_Click" />
        <br /><br />

        <asp:Label ID="lbDrawnNumbers" runat="server" />
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WindowCalculatorProgram.aspx.cs" Inherits="WindowCalculatorProgram" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="input">
            <asp:Label ID="lblWidth" runat="server" Text="Ikkunan leveys:"></asp:Label>
            <asp:TextBox ID="txtWidth" runat="server" style="margin-left: 60px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="mm"></asp:Label><p />
                
            <asp:Label ID="lblHeight" runat="server" Text="Ikkunan korkeus:"></asp:Label>
            <asp:TextBox ID="txtHeight" runat="server" style="margin-left: 49px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="mm"></asp:Label><p />
            
            <asp:Label ID="lblBorderWidth" runat="server" Text="Karmin leveys:"></asp:Label>
            <asp:TextBox ID="txtBorderWidth" runat="server" style="margin-left: 64px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="mm"></asp:Label><p />
        </div>
        <div>
            <asp:Button id="btnCalculateWindow" runat="server" Text="Laske hinta" OnClick="btnCalculateWindow_Click" /><p />
        </div>
        <div id="results">
            <asp:Label ID="lblArea" runat="server" Text="Ikkunan pinta-ala:"></asp:Label>
            <asp:TextBox ID="txtArea" runat="server" Enabled="false" style="margin-left: 66px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="m2"></asp:Label><p />
            
            <asp:Label ID="lblCirc" runat="server" Text="Karmin piiri:"></asp:Label>
            <asp:TextBox ID="txtCirc" runat="server" Enabled="false" style="margin-left: 100px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="m"></asp:Label><p />
            
            <asp:Label ID="lblPrice" runat="server" Text="Tarjoushinta (ilman ALV):"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" Enabled="false" style="margin-left: 16px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="€"></asp:Label><p />
        </div>
    </form>
</body>
</html>

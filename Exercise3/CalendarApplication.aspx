<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarApplication.aspx.cs" Inherits="CalendarApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Tänään on: <asp:Label ID="lbCurrentDate" runat="server" /></h1>

        Valitse haluamasi päivä: <asp:Label ID="lbSelectedDate" runat="server" /><br />
        Valitun ja tämän päivän erotus: <asp:Label ID="lbDifference" runat="server" /><p />

        <asp:Button ID="btnPrevious" runat="server" Text="< Edellinen" OnClick="btnPrevious_Click" Width="100"/>
        <asp:Button ID="btnNext" runat="server" Text="Seuraava >" OnClick="btnNext_Click" Width="100"/><p />
        <asp:Calendar ID="calendarDate" runat="server" OnSelectionChanged="calendarDate_SelectionChanged" AutoPostBack="true" />
    </div>
    </form>
</body>
</html>

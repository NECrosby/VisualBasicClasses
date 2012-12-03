<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Karate Members</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 style="font-family: Arial, Helvetica, sans-serif">
            Members Table, Karate Database</h2>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="KarateDataSource" 
        Font-Names="Arial" Width="640px">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                SortExpression="ID">
            <ControlStyle Font-Names="Arial" />
            </asp:BoundField>
            <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" 
                SortExpression="Last_Name" />
            <asp:BoundField DataField="First_Name" HeaderText="First_Name" 
                SortExpression="First_Name" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            <asp:BoundField DataField="Date_Joined" DataFormatString="{0:d}" 
                HeaderText="Date_Joined" SortExpression="Date_Joined">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="KarateDataSource" runat="server" 
        ConnectionString="<%$ ConnectionStrings:KarateConnectionString %>" 
        SelectCommand="SELECT [ID], [Last_Name], [First_Name], [Phone], [Date_Joined] FROM [Members] ORDER BY [Last_Name]">
    </asp:SqlDataSource>
    </form>
</body>
</html>

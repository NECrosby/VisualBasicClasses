<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 style="font-family: Arial, Helvetica, sans-serif">
            Payments by Karate Students</h2>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                ForeColor="#333399">Payments</asp:HyperLink>
&nbsp; |&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" 
                ForeColor="#333399" NavigateUrl="~/Default2.aspx">Schedule</asp:HyperLink>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BorderColor="#333399" BorderStyle="Solid" BorderWidth="1px" CellPadding="2" 
                DataSourceID="PaymentsDataSource" Font-Names="Arial,Helvetica,sans serif" 
                Width="640px">
                <Columns>
                    <asp:BoundField DataField="First_Name" HeaderText="First Name" 
                        SortExpression="First_Name" />
                    <asp:BoundField DataField="Last_Name" HeaderText="Last Name" 
                        SortExpression="Last_Name" />
                    <asp:BoundField DataField="Payment_Date" DataFormatString="{0:d}" 
                        HeaderText="Payment Date" SortExpression="Payment_Date">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Amount" DataFormatString="{0:c}" HeaderText="Amount" 
                        SortExpression="Amount" />
                </Columns>
                <HeaderStyle BackColor="#333399" BorderColor="#333399" BorderStyle="Solid" 
                    BorderWidth="1px" ForeColor="White" HorizontalAlign="Left" />
            </asp:GridView>
            <asp:SqlDataSource ID="PaymentsDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:KaratePaymentsConnectionString %>" 
                SelectCommand="SELECT Members.First_Name, Members.Last_Name, Payments.Payment_Date, Payments.Amount FROM Payments INNER JOIN Members ON Payments.Member_Id = Members.ID ORDER BY Members.Last_Name">
            </asp:SqlDataSource>
        </p>
    
    </div>
    </form>
</body>
</html>

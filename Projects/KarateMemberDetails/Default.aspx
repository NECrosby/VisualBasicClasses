<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Members Table Details</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>
            Members Table Details</h2>
        <p>
            <asp:DetailsView ID="dvwAddMember" runat="server" AutoGenerateRows="False" 
                BorderWidth="0px" DataKeyNames="ID" DataSourceID="MembersDataSource" 
                GridLines="None" Width="300px">
                <Fields>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                        SortExpression="ID" />
                    <asp:BoundField DataField="First_Name" HeaderText="First_Name" 
                        SortExpression="First_Name" />
                    <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" 
                        SortExpression="Last_Name" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Date_Joined" DataFormatString="{0:d}" 
                        HeaderText="Date_Joined" SortExpression="Date_Joined" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                        ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="MembersDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:KarateMembersDataSourceConnectionString %>" 
                DeleteCommand="DELETE FROM [Members] WHERE [ID] = @ID" 
                InsertCommand="INSERT INTO [Members] ([ID], [Last_Name], [First_Name], [Phone], [Date_Joined]) VALUES (@ID, @Last_Name, @First_Name, @Phone, @Date_Joined)" 
                SelectCommand="SELECT [ID], [Last_Name], [First_Name], [Phone], [Date_Joined] FROM [Members] ORDER BY [Last_Name]" 
                UpdateCommand="UPDATE [Members] SET [Last_Name] = @Last_Name, [First_Name] = @First_Name, [Phone] = @Phone, [Date_Joined] = @Date_Joined WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int16" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ID" Type="Int16" />
                    <asp:Parameter Name="Last_Name" Type="String" />
                    <asp:Parameter Name="First_Name" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                    <asp:Parameter Name="Date_Joined" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Last_Name" Type="String" />
                    <asp:Parameter Name="First_Name" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                    <asp:Parameter Name="Date_Joined" Type="DateTime" />
                    <asp:Parameter Name="ID" Type="Int16" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </p>
    
    </div>
    </form>
</body>
</html>

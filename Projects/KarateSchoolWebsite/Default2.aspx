<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 style="font-family: Arial, Helvetica, sans-serif">
            Karate Schedule Details</h2>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                ForeColor="#333399" NavigateUrl="~/Default.aspx" 
                meta:resourcekey="HyperLink1Resource1">Payments</asp:HyperLink>
&nbsp; |&nbsp; Schedule</p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" 
                CellPadding="3" DataKeyNames="ID" DataSourceID="KarateScheduleDataSource" 
                Font-Names="Arial,Helvetica,sans serif" Height="50px" Width="369px" 
                meta:resourcekey="DetailsView1Resource1">
                <AlternatingRowStyle BackColor="White" />
                <Fields>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                        ReadOnly="True" SortExpression="ID" meta:resourcekey="BoundFieldResource1">
                    <ControlStyle Width="100px" />
                    <HeaderStyle BackColor="Silver" Font-Bold="True" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" 
                        meta:resourcekey="BoundFieldResource2">
                    <HeaderStyle BackColor="Silver" Font-Bold="True" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Time" DataFormatString="{0:t}" HeaderText="Time" 
                        SortExpression="Time" meta:resourcekey="BoundFieldResource3">
                    <HeaderStyle BackColor="Silver" Font-Bold="True" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Instructor_Id" HeaderText="Instructor Id" 
                        SortExpression="Instructor_Id" meta:resourcekey="BoundFieldResource4">
                    <ControlStyle Width="200px" />
                    <HeaderStyle BackColor="Silver" Font-Bold="True" />
                    </asp:BoundField>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                        ShowInsertButton="True" meta:resourcekey="CommandFieldResource1">
                    <ControlStyle Font-Bold="True" />
                    <HeaderStyle BackColor="#999999" Font-Bold="True" />
                    <ItemStyle BackColor="#999999" />
                    </asp:CommandField>
                </Fields>
                <HeaderStyle Width="100px" />
            </asp:DetailsView>
        </p>
        <p style="font-family: Arial, Helvetica, sans-serif">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                CellPadding="3" DataKeyNames="ID" DataSourceID="KarateScheduleDataSource" 
                Font-Names="Arial,Helvetica,sans serif" ForeColor="Black" Width="640px" 
                meta:resourcekey="GridView1Resource1">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                        ReadOnly="True" SortExpression="ID" meta:resourcekey="BoundFieldResource5">
                    <ControlStyle Width="25px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" 
                        meta:resourcekey="BoundFieldResource6">
                    <ControlStyle Width="25px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Time" DataFormatString="{0:t}" HeaderText="Time" 
                        SortExpression="Time" meta:resourcekey="BoundFieldResource7">
                    <ControlStyle Width="50px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Instructor_Id" HeaderText="Instructor Id" 
                        SortExpression="Instructor_Id" meta:resourcekey="BoundFieldResource8">
                    <ControlStyle Width="60px" />
                    </asp:BoundField>
                </Columns>
                <HeaderStyle BackColor="#333399" ForeColor="White" />
                <RowStyle HorizontalAlign="Center" />
            </asp:GridView>
            <asp:SqlDataSource ID="KarateScheduleDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:KaratePaymentsConnectionString %>" 
                DeleteCommand="DELETE FROM [Schedule] WHERE [ID] = @ID" 
                InsertCommand="INSERT INTO [Schedule] ([Day], [Time], [Instructor_Id]) VALUES (@Day, @Time, @Instructor_Id)" 
                SelectCommand="SELECT [ID], [Day], [Time], [Instructor_Id] FROM [Schedule]" 
                
                UpdateCommand="UPDATE [Schedule] SET [Day] = @Day, [Time] = @Time, [Instructor_Id] = @Instructor_Id WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Day" Type="Int16" />
                    <asp:Parameter Name="Time" Type="DateTime" />
                    <asp:Parameter Name="Instructor_Id" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Day" Type="Int16" />
                    <asp:Parameter Name="Time" Type="DateTime" />
                    <asp:Parameter Name="Instructor_Id" Type="Int32" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </p>
    
    </div>
    </form>
</body>
</html>

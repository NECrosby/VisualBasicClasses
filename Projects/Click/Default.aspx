<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Click Application</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            My Click Application</h1>
        <p>
            <asp:Button ID="btnClick" runat="server" Text="Click Here" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Picnic Sign-Up</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>
            Computer Department Student Picnic<br />
        </h2>
        <p>
            First Name
            <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name
            <asp:TextBox ID="txtLAst" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkVegetarian" runat="server" Text="I am a Vegetarian." />
        </p>
        <p>
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>

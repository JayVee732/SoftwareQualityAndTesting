<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="Test.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Software Quanity and Testing</title>
    <meta charset="utf-8" />
    <link rel="StyleSheet" href="Style.css" />
</head>
<body>
    <h1>Software Quanity and Testing Web Interface</h1>
    <form id="form" runat="server">
        <div>
            <asp:Label runat="server" ID="lblGender" AssociatedControlID="txtGender">Gender</asp:Label>
            <asp:TextBox runat="server" ID="txtGender"></asp:TextBox>

            <asp:Label runat="server" ID="lblAge" AssociatedControlID="txtAge">Age</asp:Label>
            <asp:TextBox runat="server" ID="txtAge"></asp:TextBox>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>

        <div id="Results">
            <h1>Results</h1>
            <div>
                <asp:Label runat="server" ID="DisplayGender">Gender: </asp:Label>
            </div>
            <div>
                <asp:Label runat="server" ID="DisplayAge">Age: </asp:Label>
            </div>
            <div>
                <asp:Label runat="server" ID="DisplayPremium">Total Premium: </asp:Label>
            </div>
        </div>
    </form>
</body>
</html>

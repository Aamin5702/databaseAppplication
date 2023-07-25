<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="databaseAppplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Author&#39;s Details<br />
            <br />
            Name:
            <asp:TextBox ID="txtName" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Phone No:
            <asp:TextBox ID="txtPhone" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            ID:
            <asp:TextBox ID="txtID" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Addresss(City):
            <asp:TextBox ID="txtAdd" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert Query" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete Query" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnView" runat="server" Text="View Record" OnClick="btnView_Click1"/>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>

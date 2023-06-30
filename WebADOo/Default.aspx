<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebADOo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 194px">
    
    <form id="form1" runat="server">
        Use the bar below to search the table<br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Search" BackColor="#009933" ForeColor="Black" OnClick="Button1_Click" Width="69px"/>
        <br />
        <br />
        Enter the index of the row you wish to delete or update<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="50px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        <br />
        <br />
        Enter details to insert or update<br />
        <asp:Label ID="Label1" runat="server" AssociatedControlID="TextBox3" Text="Value"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" AssociatedControlID="TextBox4" Text="Suit"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:CheckBox ID="Update" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Send" />
        <br />
        <br />

        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

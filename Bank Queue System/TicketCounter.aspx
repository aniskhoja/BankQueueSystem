<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketCounter.aspx.cs" Inherits="Bank_Queue_System.TicketCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="455px" Width="648px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                &nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Counter1" Width="165px" />
                &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Counter2" Width="165px" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Counter3" Width="167px" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="106px" Width="223px"></asp:ListBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Print Ticket" Width="223px" />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>

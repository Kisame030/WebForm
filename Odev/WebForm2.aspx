<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Odev.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Ders Adi:"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>Fizik</asp:ListItem>
            <asp:ListItem>Kimya</asp:ListItem>
            <asp:ListItem>Biyoloji</asp:ListItem>
            <asp:ListItem>Matematik</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Ogretmen:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="16px">
            <asp:ListItem>Ahmet</asp:ListItem>
            <asp:ListItem>Mehmet</asp:ListItem>
            <asp:ListItem>Ece</asp:ListItem>
            <asp:ListItem>Defne</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Gun:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Pazartesi</asp:ListItem>
            <asp:ListItem>Sali</asp:ListItem>
            <asp:ListItem>Carsamba</asp:ListItem>
            <asp:ListItem>Persembe</asp:ListItem>
            <asp:ListItem>Cuma</asp:ListItem>
            <asp:ListItem>Cumartesi</asp:ListItem>
            <asp:ListItem>Pazar</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Saat:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>9.30</asp:ListItem>
            <asp:ListItem>10.30</asp:ListItem>
            <asp:ListItem>11.30</asp:ListItem>
            <asp:ListItem>12.30</asp:ListItem>
            <asp:ListItem>13.30</asp:ListItem>
            <asp:ListItem>14.30</asp:ListItem>
            <asp:ListItem>15.30</asp:ListItem>
            <asp:ListItem>16.30</asp:ListItem>
            <asp:ListItem>17.30</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Dersler:"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="100px" Width="186px"></asp:ListBox>
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Goster" />
    </form>
</body>
</html>

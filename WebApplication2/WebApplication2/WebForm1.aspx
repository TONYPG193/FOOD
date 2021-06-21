<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><div><h2>簡易線上點餐系統</h2></div>
            <asp:DropDownList ID="ddl_Species" runat="server" AutoPostBack="True" OnSelectedIndexChanged = "ddl_Species_SelectedIndexChanged" Width="100px">
                <asp:ListItem>飯類</asp:ListItem>
                <asp:ListItem>麵類</asp:ListItem>
                <asp:ListItem>飲料</asp:ListItem>
            </asp:DropDownList><br />
            <asp:DropDownList ID="ddl_Food" runat="server"   Width="100px">
                <asp:ListItem>炒飯</asp:ListItem>
                <asp:ListItem>滷肉飯</asp:ListItem>
                <asp:ListItem>白飯</asp:ListItem>
                <asp:ListItem>蛋包飯</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="ddl_Num" runat="server" Width="100px">
                <asp:ListItem>1碗</asp:ListItem>
                <asp:ListItem>2碗</asp:ListItem>
                <asp:ListItem>3碗</asp:ListItem>
                <asp:ListItem>4碗</asp:ListItem>
                <asp:ListItem>5碗</asp:ListItem>
                <asp:ListItem>6碗</asp:ListItem>
                <asp:ListItem>7碗</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="桌號"></asp:Label>
            <asp:TextBox ID="tb_Name" runat="server" Width="79px"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="備註"></asp:Label><br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="aaa" Text="否" AutoPostBack="True" Checked="True" OnCheckedChanged ="RadioButton1_CheckedChanged" /><br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="aaa" Text="是" AutoPostBack="True" OnCheckedChanged ="RadioButton2_CheckedChanged" /><br />
            <asp:TextBox ID="tb_Des" runat="server" Visible="False" Width="400px"></asp:TextBox><br />
            <asp:Button ID="btn_Sub" runat="server" Text="送出" Height="21px" OnClick="btn_Sub_Click" Width="40px" /><br />
            <asp:Label ID="Foodlist" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>

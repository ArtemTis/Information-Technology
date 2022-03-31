<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FirstLab.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="task2" runat="server">
        <div>
            <asp:TextBox ID="Input" runat="server"></asp:TextBox>
            <br />
            <asp:ListBox ID="InputList" runat="server">
                <asp:ListItem>Рис</asp:ListItem>
                <asp:ListItem>Молоко</asp:ListItem>
                <asp:ListItem>Сахар</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:DropDownList ID="DropDownList" runat="server" >
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Audi</asp:ListItem>
                <asp:ListItem>Volkswagen</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RadioButton ID="Processor" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Процессор" />
            <br />
            <asp:RadioButton ID="GraficCard" runat="server" Text="Видеокарта" />
            <br />
            <asp:RadioButton ID="MotherBoard" runat="server" Text="Материнская плата" />
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Button1_Click" Text="Отправить" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

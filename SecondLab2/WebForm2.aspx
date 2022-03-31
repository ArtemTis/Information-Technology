<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SecondLab2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Логин:<br />
            <asp:TextBox ID="Login" runat="server"></asp:TextBox>
            <br />
            Пароль:<br />
            <asp:TextBox ID="Password" runat="server" OnTextChanged="InputPassword_TextChanged" ></asp:TextBox>
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Отправить" />
            <br />
        </div>
    </form>
</body>
</html>

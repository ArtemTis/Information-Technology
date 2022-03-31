<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstLab.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="task1" runat="server">
        <div>
            Логин:</div>
        <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
        <asp:Label ID="Validity" runat="server"></asp:Label>
        <br />
        Пароль:<br />
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="SubmitForm" runat="server" OnClick="SubmitForm_Click" Text="Отправить" />
    </form>
</body>
</html>

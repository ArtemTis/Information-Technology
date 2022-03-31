<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SecondLab2.WebForm1" %>

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
            <asp:TextBox ID="InputLogin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="Имя не должно быть пустым" ControlToValidate="InputLogin" runat="server" Display ="Static" />
            <br />
            Пароль:<br />
            <asp:TextBox ID="InputPassword" runat="server" ></asp:TextBox>
            <asp:RegularExpressionValidator ErrorMessage="Пароль должен состоять от 8 символов" ControlToValidate="InputPassword" runat="server" ValidationExpression =".{8}.*" ID="ValuePassword"/>
            <br />
            Подтверждение пароля:<br />
            <asp:TextBox ID="ConfirmationPassword" runat="server"></asp:TextBox>
            <asp:CompareValidator ErrorMessage="Пароли должны совпадать" ControlToValidate="InputPassword" runat="server" ControlToCompare="ConfirmationPassword" Type="String" Operator="Equal" Display ="Static"/>
            <br />
            Почта:<br />
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ErrorMessage="Неправильный Email" ControlToValidate="Email" runat="server" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" />
            <br />
            Возраст:<br />
            <asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <asp:RangeValidator ErrorMessage="Число должно быть от 18 до 65" ControlToValidate="Age" runat="server" Type="Integer" MinimumValue="18" MaximumValue="65"/>
        </div>
    </form>
</body>
</html>

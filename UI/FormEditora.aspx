<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormEditora.aspx.cs" Inherits="LivrariaASP.UI.FormEditora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CSS/global.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500&display=swap" rel="stylesheet" />
    <title>Formulário Editora</title>
</head>
<body>
    <div class="container">
        <h1>Formulário Editora</h1>
        <div class="error">
            <asp:Label ID="messageError" runat="server" Visible="false" />
        </div>
        <div class="success">
            <asp:Label ID="messageSuccess" runat="server" Visible="false" />
        </div>
        <form id="form1" runat="server">
            <div class="input-group">
                <asp:Label runat="server" Text="Nome" />
                <asp:TextBox ID="txtNome" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Endereço" />
                <asp:TextBox ID="txtEndereco" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="UF" />
                <asp:TextBox ID="txtUF" runat="server" MaxLength="2" />
            </div>
            <div class="input-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </form>
    </div>
</body>
</html>

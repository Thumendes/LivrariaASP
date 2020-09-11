<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormLibrary.aspx.cs" Inherits="LivrariaASP.UI.FormLibrary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CSS/global.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500&display=swap" rel="stylesheet" />
    <title>Formulário livraria</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <h1>Formulário Livraria</h1>
            <div class="input-group">
                <asp:Label runat="server" Text="Nome" />
                <asp:TextBox ID="txtNome" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Endereço" />
                <asp:TextBox ID="txtEndereco" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Estado"/>
                <asp:TextBox ID="txtEstado" runat="server" MaxLength="2"/>
            </div>
            <div class="input-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
            </div>\
        </form>
    </div>
</body>
</html>

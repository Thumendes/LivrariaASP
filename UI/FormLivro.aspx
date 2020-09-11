<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormLivro.aspx.cs" Inherits="LivrariaASP.UI.FormLivro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CSS/global.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500&display=swap" rel="stylesheet" />
    <title>Formulário Livro</title>
</head>
<body>
    <div class="container">
        <h1>Formulário Livro</h1>
        <div class="error">
            <asp:Label ID="messageError" runat="server" Visible="false" />
        </div>
        <div class="success">
            <asp:Label ID="messageSuccess" runat="server" Visible="false" />
        </div>
        <form id="form1" runat="server">
            <div class="input-group">
                <asp:Label runat="server" Text="Título" />
                <asp:TextBox ID="txtTitulo" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Autor" />
                <asp:DropDownList runat="server" ID="drpAutor" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Editora" />
                <asp:DropDownList runat="server" ID="drpEditora" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Data de Cadastro" />
                <asp:TextBox ID="txtDataCadastro" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Número de páginas" />
                <asp:TextBox ID="txtNumPaginas" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Valor" />
                <asp:TextBox ID="txtValor" runat="server" />
            </div>
            <div class="input-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
            <asp:GridView ID="GridLivro" CssClass="table" runat="server" OnRowDeleting="GridLivro_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridLivro_RowCancelingEdit" OnRowEditing="GridLivro_RowEditing" OnRowUpdating="GridLivro_RowUpdating">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>

            </asp:GridView>
        </form>
    </div>

</body>
</html>

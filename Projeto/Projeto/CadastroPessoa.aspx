<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="Projeto.CadastroPessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Pessoas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Cadastro de Pessoas </h1>
        <div>
            <asp:Label Text="Nome:" runat="server" AssociatedControlID="txtNome"/>
            <asp:TextBox ID="txtNome" runat="server" />
        </div>
        <div>
            <asp:Label Text="Sexo:" runat="server" AssociatedControlID="ddlSexo"/>
            <asp:DropDownList ID="ddlSexo" runat="server">
                <asp:ListItem Text="Feminino" Value="F"/>
                <asp:ListItem Text="Masculino" Value="M"/>
            </asp:DropDownList>
        </div>
         <div>
            <asp:Label Text="Data de Nascimento:" runat="server" AssociatedControlID="txtDtNascimento"/>
            <asp:TextBox ID="txtDtNascimento" runat="server" />
        </div>
        <div>
            <asp:Label Text="Salário:" runat="server" AssociatedControlID="txtSalario"/>
            <asp:TextBox ID="txtSalario" runat="server" />
        </div>
        <div>
            <asp:Button runat="server" OnClick ="Salvar_Click" Text ="Salvar"/>
        </div> 
    </div>

    </form>
</body>
</html>

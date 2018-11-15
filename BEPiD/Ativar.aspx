<%@ Page Title="Ativar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ativar.aspx.cs" Inherits="BEPiD.Ativar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div class="row">
    <div class="col-md-6">
        <h3>Ativar Aluno(a)</h3>
        <br />
        <p>
            <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
            <br /><br />
            Clique no link acima chamado <b>Log in</b> e digite o seu e-mail e senha para entrar no sistema.
            É necessário aceitar alguns os contratos, imprimir e assinar.
        </p>
    </div>
    <div class="col-md-6">
        <h3>Informações</h3>
        <p>
            É necessário que seu cadastro seja ativado. Em caso de erro ou qualquer outra dúvida, entre em contato
            conosco pelo link Contato do site.
        </p>
    </div>
</div>

</asp:Content>

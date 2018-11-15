<%@ Page Title="" Language="C#" MasterPageFile="~/SiteNovo.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="admin.bepiducb.com.br.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron">
        <h1>BEPiD UCB</h1>
        <p class="lead">Brazilian Education Program for iOS Development</p>
        <p>Universidade Católica de Brasília - UCB</p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Login no sistema</h2>
            <p>
                <br />
                <asp:TextBox runat="server" Width="320" id="txtUsuario" placeholder="Digite o usuário"  CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="Digite o usuário." Display="Dynamic" ForeColor="Red" ControlToValidate="txtUsuario" runat="server" ValidationGroup="login" />
                
                <asp:TextBox runat="server" Width="300" id="txtPass" placeholder="Digite a senha." TextMode="Password" CssClass="form-control" />
                <asp:LinkButton Text="Esqueceu a senha?" Font-Size="Small" ID="lnkEsqueceuASenha" OnClick="lnkEsqueceuASenha_Click" runat="server" ValidationGroup="esqueceu" />
                <asp:RequiredFieldValidator ErrorMessage="Digite a senha" Display="Dynamic" ForeColor="Red" ControlToValidate="txtPass" ValidationGroup="login" runat="server" />
                <br />
                <asp:Button OnClick="cmdLogar_Click" Text="Entrar no sistema" ID="cmdLogar" CssClass="btn btn-default" ValidationGroup="login" runat="server" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="login" Visible="false" />
            </p>
            <p>
                
            </p>
        </div>
        <div class="col-md-6">
            <h2>Dúvidas</h2>
            <p>
                Sistema de administração de alunos do BEPiD. <br />
                Só professores autorizados podem entrar.
                Entre em contato com o administrador.
                <asp:Label id="lblResultado" ForeColor="Red" runat="server" />
            </p>
            <p>
                <a class="btn btn-default" href="http://www.bepiducb.com.br/about">Entre em contato &raquo;</a>
            </p>
        </div>
        
    </div>


</asp:Content>

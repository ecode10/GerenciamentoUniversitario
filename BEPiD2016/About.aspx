<%@ Page Title="Entre em contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BEPiD2016.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Preencha o formulário abaixo e clique no botão "enviar".</h3>
    <p>
        <asp:Label ID="lblResultado" ForeColor="Red" Visible="false" runat="server" />

        <asp:TextBox runat="server" CssClass="form-control" id="txtNome" placeholder="Digite o nome completo." Width="420" ValidationGroup="formulario" />
        <asp:RequiredFieldValidator ErrorMessage="Digite o nome." Display="Dynamic" ForeColor="Red" ControlToValidate="txtNome" runat="server" ValidationGroup="formulario" />
        <br />
        <asp:TextBox runat="server" id="txtEmail" CssClass="form-control" placeholder="Digite o email." Width="420" ValidationGroup="formulario" />
        <asp:RequiredFieldValidator ErrorMessage="Digite o e-mail." Display="Dynamic" ForeColor="Red" ControlToValidate="txtEmail" runat="server" ValidationGroup="formulario" />
        <br />
        <asp:TextBox runat="server" id="txtDescricao" CssClass="form-control"  TextMode="MultiLine" Width="420" ValidationGroup="formulario" placeholder="Digite a descrição." />
        <asp:RequiredFieldValidator ErrorMessage="Digite uma descrição." Display="Dynamic" ForeColor="Red" ControlToValidate="txtDescricao" runat="server" ValidationGroup="formulario" />
        <br />
        <asp:Button Text="Enviar" ID="txtEnviar" runat="server" class="btn btn-primary btn-large" OnClick="txtEnviar_Click" ValidationGroup="formulario" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="formulario" Visible="false" />
        <p>
    </p>
</asp:Content>

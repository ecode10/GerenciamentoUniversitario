<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Erro.aspx.cs" Inherits="admin.bepiducb.com.br.Erro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Erro no sistema BEPiD UCB.</h2>
    <p>
        Aconteceu um erro.
        <asp:Label id="lblError" runat="server" />
    </p>
</asp:Content>

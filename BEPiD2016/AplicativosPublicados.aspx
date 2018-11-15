<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AplicativosPublicados.aspx.cs" Inherits="BEPiD2016.AplicativosPublicados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Aplicativos Publicados</h2>
    <br />No programa BEPiD (Programa Educacional Brasileiro de Desenvolvimento para iOS) - Universidade Católica de Brasília (UCB).<br />
    O BEPiD não se responsabiliza sobre os aplicativos publicados pelos alunos, alguns aplicativos publicados podem sair da loja de acordo com a escolha do aluno.
    <br />
    Clique Ctrl/Command + F e digite o nome do aplicativo para pesquisar pelo nome.
    <div class="">
        <br />
        <asp:DropDownList runat="server" placeholder="Categorias" ID="cmbCategorias" AutoPostBack="true" CssClass="btn btn-default" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged">
        </asp:DropDownList>
        
        <asp:Label id="lblQuantidadeApps" runat="server" />
        <br /><br />
        <asp:GridView runat="server" ID="gridAplicativos" GridLines="None" AutoGenerateColumns="false" Width="100%" CellPadding="10" CellSpacing="10">
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <HeaderStyle BackColor="#cccccc" Height="30px" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo") %>" style="border-radius:20px;" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="NomeCategoria" HeaderText="Categoria" />
                <asp:BoundField DataField="NomeAplicativo" HeaderText="Nome do aplicativo" ControlStyle-Width="400px" />
                <asp:HyperLinkField DataTextField="LinkAplicativo" HeaderText="Link" ControlStyle-Width="500px" DataNavigateUrlFields="LinkAplicativo" />
                <asp:BoundField DataField="NomeGrupoAplicativo" HeaderText="Nome do Grupo / Aluno" />
            </Columns>
        </asp:GridView>

        
    </div>


</asp:Content>

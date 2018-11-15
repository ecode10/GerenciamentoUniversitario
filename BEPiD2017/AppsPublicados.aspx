<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppsPublicados.aspx.cs" Inherits="BEPiD2017.AppsPublicados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="w3-container" style="padding:128px 16px" id="about">
        <h2>Aplicativos Publicados</h2>
        <br />No programa BEPiD (Programa Educacional Brasileiro de Desenvolvimento para iOS) - Universidade Católica de Brasília (UCB).<br />
        O BEPiD não se responsabiliza sobre os aplicativos publicados pelos alunos, alguns aplicativos publicados podem sair da loja de acordo com a escolha do aluno.
        <br />
        Clique Ctrl/Command + F e digite o nome do aplicativo para pesquisar pelo nome.
        <div class="">
            <br />
            <asp:DropDownList runat="server" placeholder="Categorias" ID="cmbCategorias" AutoPostBack="true" CssClass="btn btn-default" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged">
            </asp:DropDownList>
            &nbsp;
            <asp:TextBox runat="server" placeholder="Digite o nome do app" ID="txtNome" /> <asp:Button Text="Buscar pelo nome" ID="cmdBuscar" OnClick="cmdBuscar_Click" runat="server" />
        
            <asp:Label id="lblQuantidadeApps" runat="server" />
            <br /><br />
            <asp:DataList runat="server" RepeatColumns="6" CellPadding="10" CellSpacing="10" Width="100%" RepeatDirection="Horizontal" ID="gridAppsList">
                <ItemTemplate>
                    <a href="/AppsPublicadosDetalhes?id=<%# Eval("IdAplicativo") %>"><img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo") %>" style="border-radius:20px; border:0px;" /><br /><%# Eval("NomeAplicativo") %></a>
                </ItemTemplate>
            </asp:DataList>

            <br /><br />
            <asp:GridView Visible="false" runat="server" ID="gridAplicativos" GridLines="None" AutoGenerateColumns="false" Width="100%" CellPadding="10" CellSpacing="10">
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
    </div>
</asp:Content>

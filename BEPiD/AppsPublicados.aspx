<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppsPublicados.aspx.cs" Inherits="BEPiD.AppsPublicados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Aplicativos Publicados</h2>
    No programa BEPiD (Programa Educacional Brasileiro de Desenvolvimento para iOS) - Universidade Católica de Brasília (UCB).

    <div class="">
        <br />
        Categorias: 
        <asp:DropDownList runat="server" ID="cmbCategorias" AutoPostBack="true" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label id="lblQuantidadeApps" runat="server" />
        <br /><br />
        <asp:GridView runat="server" ID="gridAplicativos" GridLines="None" AutoGenerateColumns="false" Width="100%" CellPadding="10" CellSpacing="6">
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <HeaderStyle BackColor="#cccccc" />
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

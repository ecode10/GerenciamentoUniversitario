<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppsPublicadosByIcone.aspx.cs" Inherits="BEPiD.AppsPublicadosByIcone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Aplicativos Publicados</h2>
    No programa BEPiD (Programa Educacional Brasileiro de Desenvolvimento para iOS) - Universidade Católica de Brasília (UCB).

    <div class="">
        <br />
        <asp:DataList Visible="true" Width="100%" runat="server" ID="dtAplicativos" ToolTip="Aplicativos publicados" RepeatColumns="8" CellPadding="0" CellSpacing="20">
            <ItemTemplate>
                <%#Eval("NomeCategoria") %><br />
                <a href="<%#Eval("LinkAplicativo") %>" style="text-decoration: none;" target="_blank">&nbsp;&nbsp;<img src='http://s3.amazonaws.com/BEPiD/<%#Eval("ImagemAplicativo") %>' width="120" style='border-radius:30px; border:0;' title="<%#Eval("NomeAplicativo") %>"/><p style="text-align:center;"><%#Eval("NomeAplicativo") %></p></a>
                <%--<p style="text-align:center;"><%#Eval("NomeGrupoAplicativo") %></p>--%>
            </ItemTemplate>
        </asp:DataList>

</asp:Content>

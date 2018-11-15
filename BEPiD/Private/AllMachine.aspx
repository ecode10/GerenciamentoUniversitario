<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="AllMachine.aspx.cs" Inherits="BEPiD.Private.AllMachine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div class="row">
        <h2>Área de administração</h2>
        <div class="col-md-8">
            <h3>Todas as máquinas</h3>
            <p>
                <asp:GridView runat="server" Width="100%" ID="grdMaquinas" 
                    GridLines="None" CellPadding="2" CellSpacing="2" 
                    AutoGenerateColumns="false">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="DescricaoTipo" HeaderText="Máquina" />
                        <asp:BoundField DataField="ModeloMaquina" HeaderText="Modelo" />
                        <asp:BoundField DataField="NrSerieMaquina" HeaderText="Nr Série" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Numero" HeaderText="Nr Kit" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <br /><br />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </p>
        </div>
        <div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>
    </div>

</asp:Content>

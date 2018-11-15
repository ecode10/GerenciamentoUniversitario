<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="Professores.aspx.cs" Inherits="BEPiD.Private.Professores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
 <div class="row">
        <h2>Professores</h2>
        <br />

        <div class="col-md-12">
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" 
                    DataKeyNames="IdProfessor">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:BoundField DataField="NomeProfessor" HeaderText="Nome" />
                        <asp:BoundField DataField="EmailProfessor" HeaderText="E-mail" />
                    </Columns>
                </asp:GridView>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>

</asp:Content>

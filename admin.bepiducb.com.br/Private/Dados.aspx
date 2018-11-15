<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="Dados.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Dados" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <script src="../Scripts/funcoes.js"></script>
    <div class="row">
        <div class="col-md-12">
            
            <h3><asp:Label ID="lblTitulo" runat="server"></asp:Label></h3>
            <p>
                
               
            </p>
        </div>

        <div class="col-md-4">
            
        </div>


        <%--<asp:Panel ID="pnlAdministrativo" runat="server" Visible="false">
            <div class="col-md-4">
                <h3>Administrativo</h3>
                <p>
                    - <a href="AllUser.aspx">Todos os alunos</a><br />
                    - <a href="AllMachine.aspx">Máquinas vinculadas</a>
                </p>
            </div>
        </asp:Panel>--%>
    </div>

</asp:Content>

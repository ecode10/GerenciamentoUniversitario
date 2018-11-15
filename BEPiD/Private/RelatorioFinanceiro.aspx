<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="RelatorioFinanceiro.aspx.cs" Inherits="BEPiD.Private.RelatorioFinanceiro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <br />
    <div class="row">
        <h2>Relatório Financeiro - Alunos</h2>
        <br />
        <table style="width:70%;">
            <tr>
                <td style="width: 323px">
                    Nome: <asp:TextBox ID="txtNome" CssClass="form-control"  runat="server" MaxLength="30" Width="265px"></asp:TextBox>
                </td>
                <td style="width: 225px">
                    Situação: 
                    <asp:DropDownList ID="cmbSituacao" CssClass="form-control"  runat="server" Width="171px">
                        <asp:ListItem Text=" Selecione " Value="" />
                        <asp:ListItem Text="Ativo" Value="A" Selected="True"  />
                        <asp:ListItem Text="Inativo" Value="I" />
                    </asp:DropDownList>
                </td>
                <td style="width: 164px">
                    Ano: <asp:TextBox runat="server" id="txtAno" CssClass="form-control" MaxLength="4" Width="100"></asp:TextBox>
                </td>
                <td>
                    <asp:Button Text="Buscar" ID="cmdBuscar" CssClass="btn btn-primary btn-large" OnClick="cmdBuscar_Click" runat="server" />
                </td>
            </tr>
        </table>
        <hr size="1" />


        <div class="col-md-12">
            <asp:Label ID="lblAlunos" runat="server" ForeColor="Red" />
            <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" 
                DataKeyNames="IdAluno">
                <AlternatingRowStyle BackColor="#f1f1f1" />
                <Columns>
                    <asp:BoundField DataField="Numero" HeaderText="Aluno" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="CPF" HeaderText="CPF" />
                    <asp:BoundField DataField="BancoNome" HeaderText="Banco" />
                    <asp:BoundField DataField="BancoNr" HeaderText="Nr. Banco" />
                    <asp:BoundField DataField="Agencia" HeaderText="Agência" />
                    <asp:BoundField DataField="Conta" HeaderText="Conta"/>
                    <asp:BoundField DataField="Ano" HeaderText="Ano" />
                    <asp:BoundField DataField="Situacao" HeaderText="Situação" />
                </Columns>
            </asp:GridView>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>

</asp:Content>

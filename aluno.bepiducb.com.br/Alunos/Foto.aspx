<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="Foto.aspx.cs" Inherits="aluno.bepiducb.com.br.Alunos.Foto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView runat="server" ID="grdDadosAluno" AutoGenerateColumns="false" CellPadding="2" CellSpacing="2"
        GridLines="None">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    Nome: <%# Eval("Nome") %> <br />
                    E-mail: <%# Eval("Email") %> <br />
                    Celular: <%# Eval("Celular") %> <br />
                    CPF: <%# Eval("CPF") %> <br />
                    Situação: <%# Eval("Situacao") %> <br />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <br /><br />
    <h3>Adicionar Imagem</h3>
    Número do Kit: <br />
    <asp:TextBox ID="txtNumero" runat="server" Width="200px" MaxLength="3" CssClass="form-control" placeholder="Exemplo: 107" onKeyPress="f_bSoNumero(event.keyCode)"></asp:TextBox>
    <br /><br />
    Imagem: (Tipo: .png ou .jpg, fundo branco, sem óculos, no máximo 500 de largura e 500 de altura)<br />
    <asp:FileUpload id="flUploadImagem" runat="server" /><br />
    <asp:Button Text="Enviar Imagem" class="btn btn-primary btn-large" ID="cmdEnviarImagem" runat="server" OnClick="cmdEnviarImagem_Click" />
    <br /><br />
    <asp:Label ID="lblImagem" runat="server" ForeColor="Red"></asp:Label>



</asp:Content>

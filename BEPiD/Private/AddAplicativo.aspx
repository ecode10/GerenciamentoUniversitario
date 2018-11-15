<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="AddAplicativo.aspx.cs" Inherits="BEPiD.Private.AddAplicativo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Adicionar Aplicativos</h1>
    <br />
     <table style="width:50%;" border="0">
        <tr>
            <td>
                <asp:DropDownList runat="server" ID="cmbCategoria" Height="30px" Width="254px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ErrorMessage="Escolha a categoria" Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="cmbCategoria" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtNome" MaxLength="100" Width="522px" placeholder="Nome do aplicativo"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite o nome do aplicativo" ControlToValidate="txtNome" Display="Dynamic" ForeColor="Red" ValidationGroup="app" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtLink" MaxLength="3000" Width="621px" placeholder="Link do aplicativo" TextMode="MultiLine" Height="86px"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite o link"  Display="Dynamic" ForeColor="Red" ControlToValidate="txtLink" runat="server" ValidationGroup="app" />
            </td>
        </tr>
         <tr>
            <td>
                <asp:TextBox runat="server" id="txtGrupo" MaxLength="3000" Width="618px" placeholder="Nome dos integrantes separado por vírgula"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 Imagem: (120x120):<br />
                 <asp:FileUpload ID="flImagem" runat="server" />
                 <asp:RequiredFieldValidator ErrorMessage="Escolha o ícone de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem" runat="server" />
             </td>
         </tr>
        <tr>
            <td align="center">
                <br /><br />
                <asp:Button Text="Cadastrar" ID="cmdCadastrar" CssClass="btn btn-primary btn-large" OnClick="cmdCadastrar_Click" runat="server" ValidationGroup="app" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Visible="false" ValidationGroup="app" />
                <br /><br />
                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    <br /><br /><br />

    <asp:GridView runat="server" ID="gridAplicativos" DataKeyNames="IdAplicativo" AutoGenerateColumns="false" GridLines="None" CellPadding="10" CellSpacing="10" OnRowCommand="gridAplicativos_RowCommand">
        <AlternatingRowStyle BackColor="#f1f1f1" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo") %>" style="border-radius:20px;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="NomeAplicativo" HeaderText="Nome do aplicativo" />
            <asp:BoundField DataField="LinkAplicativo" HeaderText="Link do aplicativo" />
            <asp:ButtonField HeaderText="Deletar" ButtonType="Button" Text="Deletar" CommandName="Deletar" />
        </Columns>
    </asp:GridView>


</asp:Content>

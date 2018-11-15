<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="AddAplicativo.aspx.cs" Inherits="aluno.bepiducb.com.br.Alunos.AddAplicativo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Adicionar Aplicativos Publicados</h1>
    
    <table style="width:50%;" border="0">
        <tr>
            <td>
                <asp:DropDownList runat="server" ID="cmbCategoria" CssClass="form-control">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ErrorMessage="Escolha a categoria" Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="cmbCategoria" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtNome" CssClass="form-control" MaxLength="100" Width="522px" placeholder="Nome do aplicativo"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite o nome do aplicativo" ControlToValidate="txtNome" Display="Dynamic" ForeColor="Red" ValidationGroup="app" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtDescricao" CssClass="form-control" MaxLength="3000" Width="621px" TextMode="MultiLine" placeholder="Descrição do aplicativo"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite a descrição do aplicativo" ControlToValidate="txtDescricao" Display="Dynamic" ForeColor="Red" ValidationGroup="app" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtDataPublicacao" CssClass="form-control" TextMode="Date" Width="222px" placeholder="Data de publicação dd/MM/yyyy"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite a data do aplicativo" ControlToValidate="txtDataPublicacao" Display="Dynamic" ForeColor="Red" ValidationGroup="app" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox runat="server" id="txtLink" CssClass="form-control" MaxLength="3000" Width="621px" placeholder="Link do aplicativo" TextMode="MultiLine" Height="86px"></asp:TextBox>
                <asp:RequiredFieldValidator ErrorMessage="Digite o link"  Display="Dynamic" ForeColor="Red" ControlToValidate="txtLink" runat="server" ValidationGroup="app" />
            </td>
        </tr>
         <tr>
            <td>
                <asp:TextBox runat="server" id="txtGrupo" CssClass="form-control" MaxLength="3000" Width="618px" placeholder="Nome dos integrantes separado por vírgula"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 Imagem ícone: (120x120):<br />
                 <asp:FileUpload ID="flImagem" runat="server" />
                 <asp:RequiredFieldValidator ErrorMessage="Escolha o ícone de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem" runat="server" />
             </td>
         </tr>
        <tr>
             <td>
                 <br /><br />
                 Imagem: (Escolha a imagem e depois de salvar a imagem é enviada - 392 x 696 ou 512 x 384)<br />
                 <asp:FileUpload ID="flImagem1" runat="server" />
                 <asp:RequiredFieldValidator ErrorMessage="Escolha a imagem de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem1" runat="server" />
                 <br /><br />
                 <asp:FileUpload ID="flImagem2" runat="server" />     
                 <asp:RequiredFieldValidator ErrorMessage="Escolha a imagem de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem2" runat="server" />            
                 <br /><br />
                 <asp:FileUpload ID="flImagem3" runat="server" />                 
                 <asp:RequiredFieldValidator ErrorMessage="Escolha a imagem de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem3" runat="server" />            
             </td>
         </tr>
        <tr>
             <td>
                 Ano:<br />
                 <asp:TextBox runat="server" id="txtAno" CssClass="form-control" MaxLength="4" placeholder="Exemplo: 2016" />
                 <asp:RequiredFieldValidator ErrorMessage="Digite o ano." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="txtAno" runat="server" />
             </td>
         </tr>
        <tr>
             <td>
                 Challenge:<br />
                 <asp:DropDownList runat="server" ID="cmbChallenge" CssClass="form-control">
                     <asp:ListItem Text="< Selecione >" Value="" />
                     <asp:ListItem Text="Nano challenge" Value="N" />
                     <asp:ListItem Text="1 mini-challenge" Value="1" />
                     <asp:ListItem Text="2 mini-challenge" Value="2" />
                     <asp:ListItem Text="3 mini-challenge" Value="3" />
                     <asp:ListItem Text="Final challenge" Value="F" />
                 </asp:DropDownList>
                 <asp:RequiredFieldValidator ErrorMessage="Selecione o challenge" Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="cmbChallenge" runat="server" />
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
    <br />
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
            <asp:BoundField DataField="DescricaoAplicativo" HeaderText="Descrição" />
            <asp:BoundField DataField="NomeGrupoAplicativo" HeaderText="Grupo dev." />
            <asp:BoundField DataField="DataPublicacaoAplicativo" HeaderText="Data" />
            <asp:ButtonField HeaderText="Deletar" ButtonType="Button" Text="Deletar" CommandName="Deletar" />
        </Columns>
    </asp:GridView>


    


</asp:Content>

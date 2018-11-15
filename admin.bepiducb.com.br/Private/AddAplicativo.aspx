<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="AddAplicativo.aspx.cs" Inherits="admin.bepiducb.com.br.Private.AddAplicativo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Adicionar Aplicativos</h1>
    <br />
    Utilize os botões para adicionar ou buscar os aplicativos<br /><br />
    <asp:Button Text="Adicionar" ID="cmdAdicionar" CssClass="btn btn-primary btn-large" OnClick="cmdAdicionar_Click" runat="server" />
    <asp:Button Text="Buscar" ID="cmdBuscar" CssClass="btn btn-primary btn-large" OnClick="cmdBuscar_Click" runat="server" />

    <asp:Panel runat="server" ID="pnlAdicionar" Visible="false">
         <table style="width:50%;" border="0">
            <tr>
                <td>
                    <asp:DropDownList runat="server" ID="cmbCategoria" Height="30px" Width="254px" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ErrorMessage="Escolha a categoria" Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="cmbCategoria" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox runat="server" id="txtNome" MaxLength="100" Width="522px" CssClass="form-control" placeholder="Nome do aplicativo"></asp:TextBox>
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
                    <asp:TextBox runat="server" id="txtLink" MaxLength="3000" Width="621px" CssClass="form-control" placeholder="Link do aplicativo" TextMode="MultiLine" Height="86px"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="Digite o link"  Display="Dynamic" ForeColor="Red" ControlToValidate="txtLink" runat="server" ValidationGroup="app" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:TextBox runat="server" id="txtGrupo" MaxLength="3000" Width="618px" CssClass="form-control" placeholder="Nome dos integrantes separado por vírgula"></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td>
                     Imagem: (120x120):<br />
                     <asp:FileUpload ID="flImagem" runat="server" CssClass="form-control" />
                     <asp:RequiredFieldValidator ErrorMessage="Escolha o ícone de seu aplicativo." Display="Dynamic" ForeColor="Red" ValidationGroup="app" ControlToValidate="flImagem" runat="server" />
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
    </asp:Panel>

    <br /><br />
    
    <asp:Panel runat="server" ID="pnlBuscar" Visible="false">
        <asp:Label ID="lblContador" runat="server" ForeColor="Red" /><br /><br />

        <asp:DropDownList runat="server" ID="cmbAno">
            <asp:ListItem Text="2015" Value="2015" />
            <asp:ListItem Text="2016" Value="2016" />
            <asp:ListItem Text="2017" Value="2017" />
        </asp:DropDownList>

        <asp:Button Text="Buscar" ID="cmdBuscarApps" CssClass="btn btn-primary btn-large" OnClick="cmdBuscarApps_Click" runat="server" />

        <asp:GridView runat="server" ID="gridAplicativos" DataKeyNames="IdAplicativo" AutoGenerateColumns="false" GridLines="None" CellPadding="10" CellSpacing="10" OnRowCommand="gridAplicativos_RowCommand">
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo") %>" style="border-radius:20px;" />&nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="NomeAplicativo" HeaderText="Nome do aplicativo" />
                <asp:BoundField DataField="LinkAplicativo" HeaderText="Link do aplicativo" />
                <asp:BoundField DataField="DataPublicacaoAplicativo" HeaderText="Data" />
                <asp:BoundField DataField="Ano" HeaderText="Ano" />
                <%--<asp:BoundField DataField="DescricaoAplicativo" HeaderText="Descrição" />--%>
                <asp:BoundField DataField="NomeGrupoAplicativo" HeaderText="Grupo dev." />
                <asp:ButtonField HeaderText="Deletar" ButtonType="Button" Text="Deletar" CommandName="Deletar" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

</asp:Content>

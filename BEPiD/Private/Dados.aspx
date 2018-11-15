<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="Dados.aspx.cs" Inherits="BEPiD.Private.Dados" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <script src="../Scripts/funcoes.js"></script>
    <div class="row">
        <div class="col-md-4">
            
            <h3><asp:Label ID="lblTitulo" runat="server"></asp:Label></h3>
            <p>
                
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

                <asp:Panel ID="pnlFoto" runat="server" Visible="true">
                    <br /><br />
                    <h3>Adicionar Imagem</h3>
                    Número do Kit: <br />
                    <asp:TextBox ID="txtNumero" runat="server" MaxLength="3" onKeyPress="f_bSoNumero(event.keyCode)"></asp:TextBox> Exemplo: 170
                    <br /><br />
                    Imagem: (Tipo: .png ou .jpg, fundo branco, sem óculos, no máximo 500 de largura e 500 de altura)<br />
                    <asp:FileUpload id="flUploadImagem" runat="server" /><br />
                    <asp:Button Text="Enviar Imagem" class="btn btn-primary btn-large" ID="cmdEnviarImagem" runat="server" OnClick="cmdEnviarImagem_Click" />
                    <br /><br />
                    <asp:Label ID="lblImagem" runat="server" ForeColor="Red"></asp:Label>
                </asp:Panel>
            </p>
        </div>

        <div class="col-md-4">
            <asp:Panel ID="pnlInformacao" runat="server" Visible="true">
            <h3><asp:Label ID="lblInformacao" runat="server"></asp:Label></h3>
            <p>
                Acesse o menu acima para navegação do site. <br />
                <div style="color:#ff0000">1- Atualize seus dados primeiro no menu "Atualizar dados". <br /><br />
                     2- Acesse o menu documentos, leia, imprima 3 vias de cada e assine.<br /><br />
                     3- Envie sua foto de fundo branco, sem óculos, sem boné e legível. Respeitando as dimensões que o sistema irá lhe informar.
                </div>
            </p>
            </asp:Panel>
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

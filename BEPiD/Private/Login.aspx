<%@ Page Title="Entrar em área restrita" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BEPiD.Private.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta http-equiv="pragma" content="no-cache" /> 
    <meta http-equiv="cache-control" content="no-cache" /> 
    <meta http-equiv="expires" content = "-1" />

    <br />
    <asp:HiddenField ID="hdProfessor" runat="server" />
     <div class="row">
        <div class="col-md-8">
            <h3><asp:Label ID="lblTitulo" runat="server"></asp:Label></h3>
            <br />
            <p>
                <table>
                    <tr>
                        <td>
                            E-mail:
                        </td>
                        <td>
                            <asp:TextBox runat="server" id="txtEmail" ValidationGroup="login" CssClass="form-control" Width="246px"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="login" ErrorMessage="*" ForeColor="Red" Display="Dynamic" ControlToValidate="txtEmail" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Senha:
                        </td>
                        <td>
                            <asp:TextBox runat="server" id="txtPassword" TextMode="Password" CssClass="form-control" Width="192px" ValidationGroup="login"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtPassword" ForeColor="Red" Display="Dynamic" ValidationGroup="login" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <br />
                            <asp:button class="btn btn-primary btn-large" text="Login" ValidationGroup="login" ID="cmdLogin" runat="server" OnClick="cmdLogin_Click" />
                            <asp:Button Text="Esqueceu a senha ?" runat="server" class="btn btn-primary btn-large" id="cmdEsqueceu" OnClick="cmdEsqueceu_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2"><br /><asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label></td>
                    </tr>
                </table>
            </p>
        </div>
         <div class="col-md-4">
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" Visible="false" ValidationGroup="login" />
            <h3>Informações importantes</h3>
             <p>
                 <br />
                 Digite o e-mail, senha e clique no botão Login ao lado para entrar na área restrita do aluno.
                 <br /><br />Em caso de dúvidas, entrar em contato conosco pelo menu Contato.
             </p>
         </div>
     </div>

</asp:Content>

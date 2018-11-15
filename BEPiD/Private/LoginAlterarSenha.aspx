<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginAlterarSenha.aspx.cs" Inherits="BEPiD.Private.LoginAlterarSenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:HiddenField ID="hdProfessor" runat="server" />
     <div class="row">
        <div class="col-md-8">
            <h3>Alterar a Senha</h3>
            <br />
            <p>
                <table border="0" style="width:60%;" cellpadding="3" cellspacing="3">
                    <tr>
                        <td>
                            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" id="txtPassword" TextMode="Password" CssClass="form-control" Width="230px" ValidationGroup="login"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtPassword" ForeColor="Red" Display="Dynamic" ValidationGroup="login" runat="server" />
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="A repetição não é igual." ForeColor="Red" Display="Dynamic" ControlToValidate="txtPassword" ValidationGroup="login" ControlToCompare="txtPasswordRepetido"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRepetirSenha" runat="server" Text="Repetir a senha:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" id="txtPasswordRepetido" TextMode="Password" CssClass="form-control" Width="230px" ValidationGroup="login"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtPasswordRepetido" ForeColor="Red" Display="Dynamic" ValidationGroup="login" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <br />
                            <asp:button class="btn btn-primary btn-large" text="Alterar Senha" ValidationGroup="login" ID="cmdLogin" runat="server" OnClick="cmdLogin_Click" />
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
                 Digite a nova senha no formulário ao lado, repita a mesma senha e clique no botão alterar senha.
                 <br /><br />Em caso de dúvidas, entrar em contato conosco pelo menu Contato.
             </p>
         </div>
     </div>


</asp:Content>

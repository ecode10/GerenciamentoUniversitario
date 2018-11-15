<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerificaInscricao.aspx.cs" Inherits="BEPiD2017.VerificaInscricao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<script src="/TemplateBEPiD_files/funcoes.js"></script>
    
    
    <div class="w3-container" style="padding:128px 16px" id="about">
            <p style="text-align:left;">
                <h3 style="text-align:left;">Verificar Inscrição</h3>
                
                    <div style="text-align:left;">
                        Campo obrigatório: *
                        <br />
                        <asp:TextBox CssClass="form-control" Width="300px" onpaste="return false" placeholder="Digite seu CPF" onKeyPress="f_sMascaraCPF(event.keyCode,null);" onKeyUp="f_sMascaraCPF(null,this);" ID="txtCPF" MaxLength="14" runat="server" />
                        <asp:RequiredFieldValidator ErrorMessage="Digite o CPF." ValidationGroup="cpfgroup" ControlToValidate="txtCPF" runat="server" />
                        
                        <asp:Button ID="cmdVerificar" runat="server" Text="Verificar" CssClass="btn btn-primary btn-large" OnClick="cmdVerificar_Click" ValidationGroup="cpfgroup" />
                        <asp:ValidationSummary ID="ValidationSummary1" Visible="false" ValidationGroup="cpfgroup" runat="server" />
                        <br />
                        <asp:Label ID="lblResultado" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                    </div>
            </p>
        </div>

</asp:Content>

<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BEPiD2017.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="w3-row-padding" style="margin-top:64px">
        <div class="w3-half">
            <div class="w3-container" style="padding:128px 16px" id="about">
                <h1>Contato</h1>
                <h3>Preencha o formulário abaixo e clique no botão "enviar".</h3>
                <p>
                    <asp:Label ID="lblResultado" ForeColor="Red" Visible="false" runat="server" />

                    <asp:TextBox runat="server" id="txtNome" placeholder="Digite o nome completo." Width="420" ValidationGroup="formulario" />
                    <asp:RequiredFieldValidator ErrorMessage="Digite o nome." Display="Dynamic" ForeColor="Red" ControlToValidate="txtNome" runat="server" ValidationGroup="formulario" />
                    <br /><br />
                    <asp:TextBox runat="server" id="txtEmail" placeholder="Digite o email." Width="420" ValidationGroup="formulario" />
                    <asp:RequiredFieldValidator ErrorMessage="Digite o e-mail." Display="Dynamic" ForeColor="Red" ControlToValidate="txtEmail" runat="server" ValidationGroup="formulario" />
                    <br /><br />
                    <asp:TextBox runat="server" id="txtDescricao" TextMode="MultiLine" Width="420" ValidationGroup="formulario" placeholder="Digite a descrição." />
                    <asp:RequiredFieldValidator ErrorMessage="Digite uma descrição." Display="Dynamic" ForeColor="Red" ControlToValidate="txtDescricao" runat="server" ValidationGroup="formulario" />
                    <br /><br />
                    <asp:Button Text="Enviar" ID="txtEnviar" runat="server" class="btn btn-primary btn-large" OnClick="txtEnviar_Click" ValidationGroup="formulario" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="formulario" Visible="false" />
                 </p>   
            </div>
        </div>
        <div class="w3-half">
            <div class="w3-container" style="padding:128px 16px" id="">
                <Br /><br /><Br />Entraremos em contato contigo assim que possível. Não mais de 3 horas para responder qualquer dúvida.
                Respondemos por e-mail mesmo.
            </div>
        </div>
    </div>

</asp:Content>

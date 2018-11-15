<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="Documentos.aspx.cs" Inherits="BEPiD.Private.Documentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%
        //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"];
    %>

  <div class="row">
        <h3>Documentos</h3>
        <div class="col-md-6">
            <p>
                <b style="color:red;">Atenção: ao clicar no link, o sistema transformará seus dados atualizados em arquivo word e automaticamente fará download para sua máquina.</b>
                <br /><br /><br />
                - Declaração de não-vínculo empregatício - <a href="Nao-Vinculo" target="_blank">link</a> <br /><br />
                - Termo de outorga e aceitação de apoio financeiro - <a href="Termo-Outorga?id=<%=Session["I"].ToString() %>" target="_self">link</a><br /><br />
                - Termo de autorização individual de uso de imagem e voz - <a href="Uso-de-Imagem" target="_blank">link</a><br /><br />
                - Instrumento particular de cessão de equipamentos - <a href="Instrumento-Particular?id=<%=Session["I"].ToString() %>" target="_blank">link</a><br /><br />
                - Termo de autorização individual de uso de imagem e voz (ELDORADO) - <a href="Contrato-Eldorado" target="_blank">link</a><br /><br />
                - Termo de uso do laboratório (BEPiD) - <a href="Contrato-NovoBEPiD" target="_blank">link</a><br /><br />
                - Aditivo de contrato BEPiD UCB - <a href="Contrato-Aditivo?id=<%=Session["I"].ToString() %>" target="_self">link</a><br /><br />
                <%--- Autorização para utilização de equipamentos fora das dependências da Universidade Católica de Brasília - UCB (Masculino) - <a href="Contrato-Autorizacao" target="_blank">link masculino</a><br /><br />--%>
                <%--- <b>Autorização para utilização de equipamentos fora das dependências da Universidade Católica de Brasília - UCB (Feminino) - <a href="Contrato-Autorizacao-Feminino" target="_blank">link feminino</a>--%>
                <br /><br />

            </p>
        </div>
      <div class="col-md-6">
            <p>
                <h3>Informações</h3>
                Clique no <b>link</b> ao lado de cada documento, confira os dados e clique no botão para imprimir.
                Traga o documento assinado para a UCB - Universidade Católica de Brasília.
            </p>
        </div>
    </div>

</asp:Content>

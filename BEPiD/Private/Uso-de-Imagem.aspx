<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uso-de-Imagem.aspx.cs" Inherits="BEPiD.Private.Uso_de_Imagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TERMO DE AUTORIZAÇÃO INDIVIDUAL DE USO DE IMAGEM e VOZ - BEPiD UCB</title>
</head>
<body>
    <form id="form1" runat="server">
        <% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>
    <div>

<pre style="width:65%; font-family:'Arial Unicode MS'; text-align:justify;">
    <p align="center"><img src="http://www.bepiducb.com.br/Imagem/logoUCB.png" width="300" /></p>

    <p align="center"><b>TERMO DE AUTORIZAÇÃO INDIVIDUAL DE USO DE IMAGEM e VOZ</b></p>
    Eu, <%= Session["N"].ToString() %>, portador da Cédula de Identidade RG nº. <%=Session["Identidade"].ToString() %>, órgão expedidor <%=Session["Orgao"].ToString() %> inscrito no CPF/MF sob o 
nº. <%= Session["C"].ToString() %>, residente e domiciliado na <%=Session["Endereco"].ToString() %>, na cidade de <%=Session["Cidade"].ToString() %>, estado de <%=Session["Estado"].ToString() %>, 
CEP <%=Session["CEP"].ToString() %>, autorizo, em razão de minha participação no BEPiD – Programa Brasileiro para Desenvolvimento em iOS, 
UNIÃO BRASILIENSE DE EDUCAÇÃO E CULTURA – UBEC, associação civil, inscrita no CNPJ/MF sob o nº 00.331.801/0001-30, 
com sede na Avenida Dom Bosco, nº 2139, Silvânia/GO e Escritório Administrativo localizado no SMPW, Quadra 05, 
Conjunto 13, Lote 08 – Núcleo Bandeirante/DF, por intermédio de sua Instituição de Ensino Superior mantida, 
UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB, situada na QS 07, Lote 01 – EPCT, Taguatinga/DF, inscrita no CNPJ/MF 
sob o no 00.331.801/0004-82, a utilizar a minha imagem e voz de acordo com as condições abaixo:

    1.  Esta autorização é feita por mim à UBEC/UCB, a título perpétuo, universal, individual, gratuito, definitivo, 
irrevogável e irretratável. A UBEC/UCB poderá, ainda, ceder os direitos contidos nesta autorização a terceiros.

    2.  A UBEC/UCB e/ou terceiros poderão fazer uso de minha imagem e/ou voz em conjunto ou separadamente, em todo 
território nacional e internacional.

    3.  A UBEC/UCB e/ou terceiros poderão fazer uso de minha imagem e/ou voz em todas as ferramentas, tecnologias 
e mídias existentes e que venham a existir.

    4.  Esta autorização é concedida em razão de minha participação no BEPiD – Programa Brasileiro para Desenvolvimento 
em iOS. Qualquer outra razão para utilização e/ou reprodução da minha imagem e/ou voz deverá ser previamente autorizada 
por mim. 

Ciente e de acordo com as disposições estabelecidas, assino o presente Termo de Autorização Individual de Uso de 
Imagem e Voz em 2 (duas) vias de igual teor, na presença de 2 (duas) testemunhas, para que se produzam os devidos 
efeitos legais.

 
<p align="right">Brasília, 02 de Fevereiro de 2015.</p>


<p style="text-align:center;">
<%= Session["N"].ToString() %>
RG nº. <%=Session["Identidade"].ToString() %> e órgão expedidor <%= Session["Orgao"].ToString() %>
CPF/MF nº. <%= Session["C"].ToString() %>
</p>

Testemunhas:


Nome: Prof. Dr. Eduardo Amadeu Dutra Moresi                         Nome: Prof. MSc. Jair Alves Barbosa
CPF/MF: 320.246.816-20                                                               CPF/MF: 551.244.618-53



<p align="center">
    <asp:button text="Li e aceito - Imprimir" OnClick="cmdImprimir_Click" OnClientClick="javascript:window.print();" ID="cmdImprimir" runat="server" />
    <asp:Button Text="Gerar Word" runat="server" ID="cmdGerarWord" OnClick="cmdGerarWord_Click" />
</p>

</pre>
    </div>
    </form>
</body>
</html>

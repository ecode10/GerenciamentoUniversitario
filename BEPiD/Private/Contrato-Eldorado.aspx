<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato-Eldorado.aspx.cs" Inherits="BEPiD.Private.Contrato_Eldorado" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contrato Eldorado</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>


        <br /><br />
<div style="text-align:center; font-family: 'Arial Unicode MS'"><b>TERMO DE AUTORIZAÇÃO INDIVIDUAL DE USO DE IMAGEM e VOZ</b></div>


<pre style="width:55%; font-family: 'Arial Unicode MS'">



Eu, <%= Session["N"].ToString() %>, portador da Cédula de Identidade RG nº. <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %>, inscrito no CPF/MF sob o nº. <%= Session["C"].ToString() %>, residente e domiciliado 
na <%= Session["Endereco"].ToString() %>, na cidade de <%= Session["Cidade"].ToString() %>, estado de <%=Session["Estado"].ToString() %>, CEP <%=Session["CEP"].ToString() %>, autorizo, em razão de minha participação no 
BEPiD – Programa Brasileiro para Desenvolvimento em iOS, o INSTITUTO DE PESQUISAS ELDORADO (“ELDORADO”), pessoa jurídica de direito 
privado com fins não econômicos, com a sua matriz no Setor Comercial Norte, Quadra 02, Bloco A, Ed. Corporate Financial Center, Sala 901, Asa Norte, 
Brasília – DF, CEP 70712-900, inscrita no CNPJ/MF sob o nº. 02.437.460/0001-07, com filial na Avenida Alan Turing, nº 275, Cidade Universitária, 
Campinas – SP, CEP 13083-898, inscrita no CNPJ/MF sob o nº. 02.437.460/0003-79 e com filial na Avenida Ipiranga, nº. 6681 – sala nº 1101 A, 
Prédio Portal TECNOPUC, nº. 99 A, Parque Científico e Tecnológico da PUCRS, Bairro Partenon, Porto Alegre/RS - CEP 90610-001, inscrita no CNPJ/MF sob o 
nº. 02.437.460/0004-50, a utilizar a minha imagem e voz de acordo com as condições abaixo:

Esta autorização é feita por mim ao ELDORADO, a título perpétuo, universal, individual, gratuito, definitivo, irrevogável e irretratável.
O ELDORADO poderá, ainda, ceder os direitos contidos nesta autorização a terceiros.O ELDORADO e/ou terceiros poderão fazer uso de minha 
imagem e/ou voz em conjunto ou separadamente, em todo território nacional e internacional. 
    
O ELDORADO e/ou terceiros poderão fazer uso de minha imagem e/ou voz em todas as ferramentas, tecnologias e mídias existentes e que 
venham a existir. Esta autorização é concedida em razão de minha participação no BEPiD – Programa Brasileiro para Desenvolvimento em iOS.
Qualquer outra razão para utilização e/ou reprodução da minha imagem e/ou voz deverá ser previamente autorizada por mim. 

Ciente e de acordo com as disposições estabelecidas, assino o presente Termo de Autorização Individual de Uso de Imagem e Voz 
em 2 (duas) vias de igual teor, na presença de 2 (duas) testemunhas, para que se produzam os devidos efeitos legais.



<p align="right">Brasília, 02  de Fevereiro de 2015.</p>

<div align="center">

____________________________________________________________
Nome: <%= Session["N"].ToString() %>
RG: <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %>
CPF:  <%= Session["C"].ToString() %>

 </div>



Testemunhas:


1)________________________________________
Nome: Prof. Dr. Eduardo Amadeu Dutra Moresi
CPF: 320.246.816-20


2)_________________________________________
Nome: Prof. MSc. Jair Alves Barbosa
CPF: 551.244.618-53








<p align="center">
    <asp:button text="Li e aceito - Imprimir" OnClientClick="javascript:window.print();" ID="cmdImprimir" runat="server" />
    <asp:button text="Gerar Word" ID="cmdGerarWord" OnClick="cmdGerarWord_Click" runat="server" />
</p>
</pre>    
        
    </div>
    </form>
</body>
</html>

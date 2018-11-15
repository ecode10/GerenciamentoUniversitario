<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instrumento-Particular.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Instrumento_Particular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title><%= Session["N"].ToString() %></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

<div style="width:100%; font-family:'Arial Unicode MS'; text-align:justify;">
<table style="width:100%;">
    <tr>
        <td>
            <img src="http://www9.eldorado.org.br/wp-content/themes/eldorado/images/instituto-eldorado.png" />
        </td>
        <td>
            <fieldset>
            INSTITUTO DE PESQUISAS ELDORADO <br />
            UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB
            </fieldset>
        </td>
    </tr>
</table>

<div style="width:100%; font-family:'Arial Unicode MS'; text-align:justify;">

<p align="center"><b>INSTRUMENTO PARTICULAR DE CESSÃO DE EQUIPAMENTOS</b></p>

INSTITUTO DE PESQUISAS ELDORADO, pessoa jurídica de direito privado, inscrita no Cadastro Nacional de Pessoa Jurídica 
do Ministério da Fazenda (CNPJ/MF) sob o nº 02.437.460/0001-07, na cidade de Brasília/DF, Setor Comercial Norte, n.º 190, 
Bloco A, 9o.andar, sala 901, Ed. Corporate Financial Center, Asa Norte, CEP 70712-900 neste ato representada na forma de 
seu Estatuto Social, doravante denominada “CEDENTE” e; Sr.(a) <%= Session["N"].ToString() %>, portador da cédula de identidade RG nº <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %> e do CPF/MF nº <%= Session["C"].ToString() %>, 
residente e domiciliado na cidade de <%= Session["Cidade"].ToString() %>, na <%= Session["Endereco"].ToString() %>, CEP: <%=Session["CEP"].ToString() %>,  doravante denominado CESSIONÁRIO.
<br /><br />

<b>CONSIDERANDO:</b>
<br />
I- o CEDENTE promoverá o BEPiD – Programa Brasileiro para desenvolvimento em iOS (BEPiD);
<br />
II- para participar do referido programa, o CESSIONÁRIO necessitará de equipamentos específicos;
<br />
III- o CEDENTE detém a posse de tais equipamentos, por conta de Contrato de Locação firmado com a proprietária de tais 
bens móveis.
<br />
Pelo presente Instrumento Particular de Cessão, as partes acima melhor qualificadas têm entre si pactuada a assinatura 
do presente documento, ato jurídico perfeito e solene, tendente à regularização de suas pretensões, convergentes nas 
cláusulas e condições abaixo estipuladas:
<br /><br />

<b>CLÁUSULA 1 - DO OBJETO:</b>
<br />
O CEDENTE promoverá ao CESSIONÁRIO a cessão gratuita e temporária dos equipamentos abaixo arrolados:<br />
MacBook Pro 13 inch – Serial Number : <%=Session["NRSerie0"].ToString() %><br />
<%--iPad Air – Serial Number : <%=Session["NRSerie1"].ToString() %>--%>
iPhone 6 – Serial Number <%=Session["NRSerie1"].ToString() %><br /><br />


<b>CLÁUSULA 2 - DA FINALIDADE:</b>
<br />
Os equipamentos ora cedidos deverão ser utilizados, exclusivamente, para as finalidades relacionadas ao treinamento 
acima mencionado, comprometendo-se o CESSIONÁRIO a não dar-lhes destinação diversa, sob pena de imediata rescisão da 
presente cessão, sem prejuízo da obrigação de ressarcir os danos causados ao CEDENTE.
<br /><br />

<b>CLÁUSULA 3 - DOS DIREITOS E OBRIGAÇÕES DO CEDENTE:</b>
<br />
(i) O CEDENTE promoverá a entrega dos equipamentos arrolados na Cláusula 1, no ato da assinatura do presente Instrumento.
<br />
(ii) O CEDENTE garante que os equipamentos se encontram em perfeito estado de funcionamento e conservação, conforme 
constatado pelo CESSIONÁRIO no ato da entrega.
<br />
(iii) O CEDENTE poderá inspecionar os bens cedidos, a qualquer tempo.
<br /><br />

<b>CLÁUSULA 4 - DOS DIREITOS E OBRIGAÇÕES DO CESSIONÁRIO:</b>
<br />
(i) O CESSIONÁRIO compromete-se a utilizar os equipamentos, exclusivamente, para os fins a que se destinam – BEPiD – 
Programa Brasileiro para desenvolvimento em iOS (BEPiD)-, respeitando as características e instruções constantes dos 
respectivos manuais técnicos, bem como aquelas constantes em suas embalagens.
<br />
(ii) O CESSIONÁRIO deverá manter e guardar os equipamentos recebidos, assim como as respectivas embalagens e manuais, 
como se seus fossem, desde o recebimento até a efetiva devolução ao CEDENTE, ficando responsável pela conservação e 
obrigando-se a devolvê-lo tão logo seja notificado para tanto.
<br />
(iii) O CESSIONÁRIO compromete-se a restituir os equipamentos ao CEDENTE, em perfeito estado, limpos e nas mesmas 
condições de uso que os encontrou quando do recebimento.
<br />
(iv) Considerando que os equipamentos cedidos se encontram devidamente segurados, em âmbito nacional, contra danos 
acidentais, exceto para a hipótese de derramamento de líquidos de qualquer natureza, e contra furto qualificado, o 
CESSIONÁRIO obriga-se, em caso de dano ou perda do equipamento por razões cobertas pelo seguro e desde que tenha dado 
causa ao evento danoso ou dele participado, a restituir ao CEDENTE os valores por ele despendidos, até o limite da 
franquia devida à Seguradora. 
<br />
(v) Na hipótese de danos ou da perda do equipamento por razões não cobertas pelo seguro contratado e desde que tenha 
o CESSIONÁRIO dado causa ao evento danoso ou dele participado, o CESSIONÁRIO obriga-se a restituir ao CEDENTE os valores 
despendidos para a recuperação do equipamento ou, não sendo esta possível, para a sua reposição.
<br /><br />

<b>CLAUSULA 5 – DA RASTREABILIDADE DOS EQUIPAMENTOS</b>
<br />
O CESSIONÁRIO declara estar ciente de que os equipamentos ora cedidos são rastreáveis eletronicamente, bem como se obriga 
a não promover qualquer alteração de software ou hardware que possa comprometer ou inabilitar o sistema de rastreamento 
instalado. 
<br /><br />

<b>CLÁUSULA 6 – DAS CONDIÇÕES GERAIS:</b>
<br />
O presente instrumento é firmado sob a égide dos artigos 421 e 422 do Código Civil, sendo reflexo da vontade das partes 
e inequívoca boa-fé.Fica eleito o Foro da Comarca de Campinas – SP para dirimir qualquer dúvida oriunda do presente contrato, com renúncia 
expressa a qualquer outro, por mais privilegiado que seja.
<br />
Estando assim justos e acordados, CEDENTE e CESSIONÁRIO firmam o presente documento em 02 (duas) vias de igual teor e forma, 
na presença de 02 (duas) testemunhas, para que se produzam os seus devidos efeitos legais.
<br />

<div style="text-align:right;">
Brasília, <%=DateTime.Now.Day %> de <%= new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.GetMonthName(DateTime.Now.Month).ToUpper() %> de <%=DateTime.Now.Year %>.
</div>
<table style="width:100%;">
    <tr>
        <td style="width:50%;">
            CEDENTE
        </td>
        <td style="width:50%;">
            P/ESTUDANTE/BENEFICIÁRIO
        </td>
    </tr>
    <tr>
        <td>
            __________________________________________<br />	
            INSTITUTO DE PESQUISAS ELDORADO
        </td>
        <td>
            <br />__________________________________________<br />
            <%= Session["N"].ToString() %><br />
            CPF:  <%= Session["C"].ToString() %><br />
        </td>
    </tr>
    <tr>
        <td colspan="2">Testemunhas:</td>
    </tr>
    <tr>
        <td>
            1)________________________________________<br />
            Prof. Dr. Eduardo Amadeu Dutra Moresi<br />
            CPF: 320.246.816-20<br />
        </td>
        <td>
            2)_________________________________________<br />
            Prof. MSc. Jair Alves Barbosa<br />
            CPF: 551.244.618-53<br />
        </td>
    </tr>
</table>
</div>

    </div>
    </form>
</body>
</html>

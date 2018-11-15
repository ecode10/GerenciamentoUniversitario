<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato-Aditivo.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Contrato_Aditivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADITIVO AO TERMO DE OUTORGA E ACEITAÇÃO DE APOIO FINANCEIRO PARA CAPACITAÇÃO/PESQUISA</title>
</head>
<body>
    <form id="form1" runat="server">
    
<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

<div style="width:80%; font-family:'Arial Unicode MS'; text-align:justify;">

<table style="width:100%;">
    <tr>
        <td>
            <img src="http://www.bepiducb.com.br/Imagem/logoUCB.png" width="200" />
        </td>
        <td>
            <fieldset>
            UNIÃO BRASILIENSE DE EDUCAÇÃO E CULTURA – UBEC
            UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB
            </fieldset>
        </td>
    </tr>
</table>

    <b>ADITIVO AO TERMO DE OUTORGA E ACEITAÇÃO DE APOIO <Br />FINANCEIRO PARA CAPACITAÇÃO/PESQUISA</b>



<div style="width:65%; font-family: 'Arial Unicode MS'; text-align:justify;">

A <b>UNIÃO BRASILIENSE DE EDUCAÇÃO E CULTURA – UBEC</b>, associação civil, confessional de direito 
privado e de caráter assistencial, educacional, filantrópico e sem fins econômicos, inscrita no 
CNPJ/MF n° 00.331.801/0001-30, com Escritório Executivo localizado no SMPW Quadra 5 Conjunto 13, 
Lote 8, Núcleo Bandeirante/DF, por intermédio de sua Instituição de Ensino Superior mantida, 
<b>UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB</b>, reconhecida pela Portaria n.º 1.827, de 28 de dezembro 
de 1994, publicada no DOU em 30 de dezembro de 1994, Seção 1, Página 21.241, inscrita no 
CNPJ/MF nº 00.331.801/0004-82, com sede na QS 7, Lote 1– EPCT, Águas Claras/DF, CEP 71.966-700, 
doravante denominada UCB, neste ato representada por seu Reitor, Prof. Dr. Gilberto Gonçalves Garcia, 
brasileiro, solteiro, professor, RG n.º 9.328.624-3 SSP/PR, CPF n.º 152.520.431-91, residente e 
domiciliado em Brasília-DF, e <%= Session["N"].ToString() %>, nacionalidade <%=Session["Nacionalidade"].ToString() %>, estado civil 
<%=Session["EstadoCivil"].ToString() %>, residente de domiciliado na <%= Session["Endereco"].ToString() %> <%= Session["Cidade"].ToString() %>, 
portador da Carteira de Identidade RG nº <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %> e CPF/MF nº <%= Session["CPF"].ToString() %>, 
doravante denominado "ESTUDANTE/BENEFICIÁRIO";&nbsp;<br /><br />

Resolvem aditivar o Termo de Outorga e Aceitação de Apoio Financeiro Para Capacitação/Pesquisa, 
mediante as seguintes condições:&nbsp;<br /><br />

1.	Estender a concessão de Bolsa de Pesquisa no valor de R$ 1.000,00 (um mil reais) para o período 
de 1º de fevereiro de 2015 a 31 de março de 2015.&nbsp;<br />

2.	O <b>ESTUDANTE/BENEFICIÁRIO</b> está ciente de que o presente Termo, em virtude da natureza das atividades, 
não decorre vínculo empregatício com a UBEC/UCB.&nbsp;<br />

3.	O <b>ESTUDANTE/BENEFICIÁRIO</b> está ciente de que os aplicativos iOS desenvolvidos no período de vigência 
do presente Termo, a contar de 19 de março de 2014, serão de sua propriedade, mas deverão ter no início da descrição
do aplicativo publicado na Apple Store a inscrição: "App desenvolvida no Projeto BEPiD da Universidade Católica de Brasília."&nbsp;<br />

E por se acharem acertadas, as partes assinam o presente Instrumento, em 02 (duas) vias, de igual teor e 
para um só efeito na presença das testemunhas abaixo.&nbsp;<br />

<div style="text-align:right;">Brasília, 02 de Fevereiro de 2015.</div>
<br /><br />
<table style="width:100%;">
    <tr>
        <td style="width:50%;">
            P/UCB
        </td>
        <td style="width:50%;">
            P/ESTUDANTE/BENEFICIÁRIO
        </td>
    </tr>
    <tr>
        <td>
            __________________________________________<br />	
            Prof. Dr. Gilberto Gonçalves Garcia<br />
            Reitor da UCB<br />
            CPF: 152.520.431-91 – RG: 9.328.624-3 SSP/PR
        </td>
        <td>
            __________________________________________<br />
            Nome: <%= Session["N"].ToString() %><br />
            CPF:  <%= Session["CPF"].ToString() %><br /><br />
        </td>
    </tr>
    <tr>
        <td colspan="2">Testemunhas:</td>
    </tr>
    <tr>
        <td>
            1)________________________________________<br />
            Nome: Prof. Dr. Eduardo Amadeu Dutra Moresi<br />
            CPF: 320.246.816-20<br /><br />
        </td>
        <td>
            2)_________________________________________<br />
            Nome: Prof. MSc. Jair Alves Barbosa<br />
            CPF: 551.244.618-53<br /><br />
        </td>
    </tr>
</table>

</div>    

<%--<p align="center" style="display:none;">
    <asp:button text="Li e aceito - Imprimir" Visible="false" OnClientClick="javascript:window.print();" ID="cmdImprimir" runat="server" />
    <asp:button text="Gerar Word" id="cmdGerarWord" Visible="false" OnClick="cmdGerarWord_Click" runat="server" />
</p>
--%>
        
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Termo-Outorga.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Termo_Outorga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Termo de Concessão de Apoio Financeiro para Capacitação e Pesquisa</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

<div style="width:100%; font-family:'Arial Unicode MS'; text-align:justify;">
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

<%--<p align="right">Brasília, <%= DateTime.Now.Day %> do <%= DateTime.Now.Month %> de <%= DateTime.Now.Year %>.</p>--%>

<p align="center"><b>TERMO DE CONCESSÃO DE APOIO FINANCEIRO PARA CAPACITAÇÃO E PESQUISA</b></p>


A <b>UNIÃO BRASILIENSE DE EDUCAÇÃO E CULTURA – UBEC</b>, associação civil, confessional de direito privado 
e de caráter assistencial, educacional, filantrópico e sem fins econômicos, inscrita no CNPJ/MF n° 00.331.801/0001-30, 
com Escritório Executivo localizado no SMPW Quadra 5 Conjunto 13, Lote 8, Núcleo Bandeirante/DF, por intermédio de sua 
Instituição de Ensino Superior mantida, UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB, reconhecida pela Portaria n.º 1.827, 
de 28 de dezembro de 1994, publicada no DOU em 30 de dezembro de 1994, Seção 1, Página 21.241, inscrita no CNPJ/MF nº 
00.331.801/0004-82, com sede na QS 7, Lote 1– EPCT, Águas Claras - Brasília/DF, CEP 71.966-700, doravante denominada UCB, neste 
ato representada por seu Reitor, <B>Prof. Dr. Gilberto Gonçalves Garcia</B>, brasileiro, solteiro, professor, RG nº 9.328.624-3 SSP/PR 
e CPF nº 152.520.431-91, residente e domiciliado em Brasília-DF e <%= Session["N"].ToString() %>, nacionalidade <%=Session["Nacionalidade"].ToString() %>, 
estado civil <%=Session["EstadoCivil"].ToString() %>, residente de domiciliado na <%= Session["Endereco"].ToString() %> 
<%= Session["Cidade"].ToString() %>, portador da Carteira de Identidade RG nº <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %> 
e CPF/MF nº <%= Session["C"].ToString() %>, doravante denominado "ESTUDANTE/BENEFICIÁRIO";&nbsp;<br /><br />

<b>Considerando que</b> a UBEC/UCB firmou Convênio de Cooperação Científica e Tecnológica com a <i>Apple Computer</i> Brasil Ltda., 
e recebeu os recursos financeiros à sua conta, para destinar parte à Bolsas de Capacitação/Pesquisa;&nbsp;<br /><br />

<b>Considerando que</b> o processo de seleção dos pesquisadores, para o desenvolvimento das atividades de pesquisa, atendeu 
ao pré-requisito da impessoalidade, pela publicação do Edital de Bolsa de Pesquisa nº 01/2014, sob a responsabilidade da 
Coordenação do Projeto BEPiD/UCB, contendo regras claras, objetivas e impessoais, tendo o Edital sido amplamente divulgado,
no qual tomou conhecimento prévio o <b>"ESTUDANTE/BENEFICIÁRIO"</b>, regularmente matriculado no curso <%= Session["Curso"].ToString() %>
do(a) <%=Session["NomeUniversidade"].ToString() %>;&nbsp;<br /><br />

<b>Considerando que</b> o resultado da pesquisa não se constitui em benefício para o Órgão Fornecedor (<i>Apple Computer Brasil</i> Ltda), 
pois o Convênio tem por escopo estabelecer um amplo programa de cooperação e intercâmbio científico e tecnológico para atividades de pesquisa e 
desenvolvimento, qualificação e treinamento de recursos humanos, e recebimento e transferência de tecnologia;&nbsp;<br /><br />

<b>Resolvem</b> celebrar o presente Termo de Outorga e Aceitação de Apoio Financeiro Para Capacitação/Pesquisa, mediante as seguintes 
condições:&nbsp;<br /><br />

1. A <b>UCB</b> concede, por repasse, parte dos citados recursos financeiros ao <b>ESTUDANTE/BENEFICIÁRIO</b>, que os aceita nas condições 
em que os mesmos estão sendo ofertados, expressamente no presente TERMO.&nbsp;<br /><br />

2. O repasse financeiro feito ao aluno está ancorado no <i>Convênio</i> supramencionado, também de cumprimento obrigatório, pelo 
<b>ESTUDANTE/BENEFICIÁRIO</b>, integrante do presente TERMO, que sugere, dentre outras, as seguintes atividades: designe de interfaces para aplicativos 
móveis e desenvolvimento de conteúdos.&nbsp;<br /><br />

3. As Bolsas de Pesquisa serão concedidas no período de <b>1º de fevereiro de 2015</b> a <b>31 de dezembro de 2015</b>.&nbsp;<br /><br />

4. O valor mensal da Bolsa de Pesquisa será de <b>R$ 1.000,00 (um mil reais)</b>, que será efetuado até o último dia útil de cada mês. &nbsp;<br /><br />

5. No mês de fevereiro de 2015, haverá o acréscimo de <b>R$ 250,00 (duzentos e cinquenta reais)</b>, para cobrir parcialmente o 
custo de adesão ao Programa de Desenvolvedor iOS da Apple.&nbsp;<br /><br />

6. O <b>ESTUDANTE/BENEFICIÁRIO</b> declara não ser servidor ativo da Administração Pública Federal, Estadual, do Distrito Federal 
ou Municipal, direta ou indireta, em atenção às disposições do Decreto nº 5.151, de 22/07/04.&nbsp;<br /><br />

7. O <b>ESTUDANTE/BENEFICIÁRIO</b> declara estar de acordo com as condições estabelecidas no presente TERMO, e se compromete a 
cumprir 20 horas/semanais em turno vespertino no Bloco N do Campus I da UCB.&nbsp;<br /><br />

8. O <b>ESTUDANTE/BENEFICIÁRIO</b> está ciente de que, do presente Termo, em virtude da natureza das atividades, não decorre 
vínculo empregatício com a UBEC/UCB nem com a <i>Apple Computer Brasil</i> Ltda.&nbsp;<br /><br />

9. O <b>ESTUDANTE/BENEFICIÁRIO</b> está ciente de que os aplicativos iOS desenvolvidos no período de vigência do presente Termo 
serão de sua propriedade, mas deverão ter no início da descrição do aplicativo publicado na Apple Store a inscrição: "App desenvolvida no Projeto 
BEPiD da Universidade Católica de Brasília."&nbsp;<br /><br />

10. Para as questões decorrentes deste TERMO, elegem as partes, com expressa renúncia a outro qualquer, por mais privilegiado 
que seja, o Foro da Circunscrição Judiciária de Taguatinga do Distrito Federal.&nbsp;<br /><br />

E por se acharem acertadas, as partes assinam o presente Instrumento, em 03 (duas) vias, de igual teor e para um só efeito na 
presença das testemunhas abaixo.&nbsp;<br /><br />
<div style="text-align:right;">
Brasília, 02 de Fevereiro de 2015.
</div>
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
            CPF:  <%= Session["C"].ToString() %><br /><br />
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

<%--<p align="center" style="display:none;">
    <asp:button text="Li e aceito - Imprimir" OnClick="cmdImprimir_Click" Visible="false" OnClientClick="javascript:window.print();" ID="cmdImprimir" runat="server" />
    <asp:button text="Gerar Word" id="cmdGerarWord" OnClick="cmdGerarWord_Click" runat="server" Visible="false" />
</p>--%>

</div>
    
    </div>
    </form>
</body>
</html>

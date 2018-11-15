<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato-Autorizacao-Feminino.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Contrato_Autorizacao_Feminino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contrato de autorização para utilização de equipamentos fora das dependências da Universidade Católica de Brasília - UCB</title>
    <script lang="javascript">
        function imprimir() {
            document.getElementById("cmdImprimir").style.display = "none";
            window.print();
            document.getElementById("cmdImprimir").style.display = "";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

<div style="text-align:center; font-family: 'Arial Unicode MS'"><b>AUTORIZAÇÃO PARA UTILIZAÇÃO DE EQUIPAMENTOS FORA <br />
DAS DEPENDÊNCIAS DA UNIVERSIDADE CATÓLICA DE BRASÍLIA - UCB</b></div>
<br /><br />

<pre style="width:55%; font-family: 'Arial Unicode MS'; text-align:justify;">
<b>INSTITUTO DE PESQUISAS ELDORADO</b>, pessoa jurídica de direito privado, inscrita no Cadastro Nacional de Pessoa Jurídica do Ministério da 
Fazenda (CNPJ/MF) sob o nº 02.437.460/0001-07, localizado no Setor Comercial Norte, Quadra 02, Bloco A, Edifício Corporate Financial Center, 
Sala 901, Asa Norte, Brasília (DF), CEP 70712-900, neste ato representada na forma de seu Estatuto Social, doravante denominada “ELDORADO”, 
AUTORIZA a Sra. <%= Session["N"].ToString() %>, portador da cédula de identidade RG nº <%= Session["Identidade"].ToString() %>, <%= Session["Orgao"].ToString() %> e do CPF/MF nº <%= Session["C"].ToString() %>, 
residente e domiciliado na <%= Session["Endereco"].ToString() %>, <%= Session["Cidade"].ToString() %>/<%= Session["Estado"].ToString() %>, CEP <%=Session["CEP"].ToString() %>, a utilizar 
os equipamentos <b>(“Equipamentos”)</b> abaixo relacionados fora das dependências do Programa Brasileiro para desenvolvimento em iOS (“BEPiD”), 
realizado no Campus I da <b>UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB</b> (CNPJ/MF sob o nº 00.331.801/0001-30), localizada na QS 07, Lote 01, 
EPCT, Águas Claras, Taguatinga/DF - CEP: 71966-700, doravante denominada <b>ANUENTE</b>, visando, única e exclusivamente, a realização de 
desenvolvimento e testes de usabilidade:

  .  MacBook Pro 13 – Serial Number:       <%= Session["Macbook"].ToString() %>
  .  iPad Air Wi-Fi 64 GB – Serial Number: <%= Session["iPad"].ToString() %>
  .  iPhone 5C 32 GB – Serial Number:   <%= Session["iPhone"].ToString() %>

A autorização ora concedida está subordinada ao <b>INSTRUMENTO PARTICULAR DE CESSÃO DE EQUIPAMENTOS</b> celebrado entre a 
<b>Sra. <%= Session["N"].ToString() %></b> e o <b>ELDORADO</b>, em 24 de Março de 2014.
Desta maneira, reitera-se que:

    (i) A <b>Sra. <%= Session["N"].ToString() %></b> compromete-se a utilizar os <b>Equipamentos</b>, exclusivamente, para os fins a que se destina o Programa Brasileiro 
        para desenvolvimento em iOS (“<b>BEPiD</b>”), nos limites da autorização ora concedida, respeitando as características e instruções constantes dos 
        respectivos manuais técnicos, bem como aquelas constantes em suas embalagens.

    (ii) A <b>Sra. <%= Session["N"].ToString() %></b> deverá manter e guardar os <b>Equipamentos</b> recebidos, assim como as respectivas embalagens e manuais, como se 
         seus fossem, desde o recebimento até a efetiva devolução ao <b>ELDORADO</b>, ficando responsável pela conservação e obrigando-se a devolvê-los tão 
         logo seja notificado para tanto.

    (iii) A <b>Sra. <%= Session["N"].ToString() %></b> compromete-se a restituir os <b>Equipamentos</b> ao <b>ELDORADO</b>, em perfeito estado, limpos e nas mesmas 
          condições de uso que os encontrou quando do recebimento.

    (iv) Considerando que os <b>Equipamentos</b> se encontram devidamente segurados, em âmbito nacional, contra furto qualificado e contra danos acidentais, 
         exceto para a hipótese de derramamento de líquidos de qualquer natureza, a <b>Sra. <%= Session["N"].ToString() %></b> obriga-se: 

      a) em caso de dano ou perda dos Equipamentos por razões cobertas pelo seguro e desde que tenha dado causa ao evento danoso ou dele participado, 
         a restituir ao ELDORADO os valores por ele despendidos, até o limite da franquia devida à Seguradora;
      b) na hipótese de danos ou da perda dos Equipamentos por razões não cobertas pelo seguro contratado e desde que tenha dado causa ao evento 
         danoso ou dele participado, a restituir ao ELDORADO os valores despendidos para a recuperação dos Equipamentos ou, não sendo esta possível, 
         para a sua reposição.

    (v) A <b>Sra. <%= Session["N"].ToString() %></b> declara estar ciente de que os Equipamentos são rastreáveis eletronicamente, bem como se obriga a não promover 
        qualquer alteração de software ou hardware que possa comprometer ou inabilitar o sistema de rastreamento instalado. 
<p align="left">Brasília/DF, <%=DateTime.Now.Day %> de <%= new System.Globalization.CultureInfo("pt-BR").DateTimeFormat.GetMonthName(DateTime.Now.Month).ToUpper() %> de <%=DateTime.Now.Year %>.</p></pre><pre style="width:95%; font-family: 'Arial Unicode MS'">
<div align="center">
___________________________________________________________
<b>INSTITUTO DE PESQUISAS ELDORADO</b>
Jaylton Moura Ferreira          Arthur João Catto, Ph.D.
                Superintendente                    Executivo de Pesquisa e Inovação


______________________________________________
<b>Sr. <%= Session["N"].ToString() %></b>

<b>ANUENTE:</b>

______________________________________________
<b>UNIVERSIDADE CATÓLICA DE BRASÍLIA – UCB</b>
Eduardo Amadeu Dutra Moresi
Prof. Dr. Coordenador do Projeto BEPiD-UCB
</div>
<div style="font-size:xx-small;">
Rogério Peres - OAB/SP 263.150
Instituto de Pesquisas Eldorado
Assistência Jurídica
</div>
</pre>     
    </div>
    </form>
</body>
</html>

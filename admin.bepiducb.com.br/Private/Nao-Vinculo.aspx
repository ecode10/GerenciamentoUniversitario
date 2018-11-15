<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nao-Vinculo.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Nao_Vinculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Documentos</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
<pre style="width:55%; font-family: 'Arial Unicode MS'">
<p align="center"><img src="http://www.bepiducb.com.br/Imagem/logoUCB.png" width="300" /></p>
<p align="right">Brasília, 02 de Fevereiro de 2015.</p>

À
Universidade Católica de Brasília - UCB


Prezados Senhores,



		Declaro para os devidos fins junto à UCB, para fins de participação no projeto BEPiD, 
que não mantenho vínculo empregatício com: o serviço público federal, estadual ou municipal; 
e com a União Brasiliense de Educação e Cultura - UBEC ou quaisquer de suas mantidas; ou bolsas 
de iniciação científica ou extensão se aluno da UCB; que impeça a assinatura do TERMO DE OUTORGA 
E ACEITAÇÃO DE APOIO FINANCEIRO PARA CAPACITAÇÃO/PESQUISA.


<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

____________________________________________
Nome: <%= Session["N"].ToString() %>
CPF:  <%= Session["C"].ToString() %>





<p align="center">
    <asp:button text="Li e aceito - Imprimir" OnClick="cmdImprimir_Click" OnClientClick="javascript:window.print();" ID="cmdImprimir" runat="server" />
    <asp:button text="Gerar Word" ID="cmdGerarWord" OnClick="cmdGerarWord_Click" runat="server" />
</p>
</pre>    
        
    </div>
    </form>
</body>
</html>

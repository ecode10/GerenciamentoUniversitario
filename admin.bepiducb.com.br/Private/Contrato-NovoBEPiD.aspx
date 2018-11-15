<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrato-NovoBEPiD.aspx.cs" Inherits="admin.bepiducb.com.br.Private.Contrato_NovoBEPiD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Normas de Uso do Laboratório</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<% //HttpCookie Session = Request.Cookies["BEPiDUCB.Site"]; %>

<pre style="width:70%; font-family:'Arial Unicode MS'; text-align:justify;">

<p align="center"><img src="http://www.bepiducb.com.br/Imagem/logoUCB.png" width="300"/>
    <u>Universidade Católica de Brasília - UCB</u>
    <br />
    <b>Normas de Uso do Laboratório  – BEPiD-UCB</b>

</p></div>


<pre style="width:55%; font-family: 'Arial Unicode MS'">

1. Não é permitido tirar fotos ou vídeos do espaço físico do BEPiD.

2. Não é permitida a divulgação de qualquer tipo de informação sobre o projeto BEPiD-UCB.

3. Não é permitido comer e/ou beber nas dependências do boardroom, main classroom, 
    laboratórios e learning space.

4. Os laboratórios funcionam de 09:00 as 12:00 e de 14:00 as 18:00 de Segunda a Sexta-feira 
    caso seja necessária a permanência de alunos fora dos horários estipulados, devem tratar 
    diretamente com os Professores. 

5. Não é permitido trazer pessoas não autorizadas ao espaço físico do BEPiD.

6. Não é permitido a utilização de notebooks, Tablets que não sejam Apple. 

7. Não existem lugares reservados ou demarcados. Qualquer aluno pode utilizar qualquer uma das bancadas, 
    pufes e cadeiras; com exceção das bancadas dos professores.

8. Antes de ocupar uma mesa nos laboratórios o aluno deverá verificar a escala do dia.

9. O uso da main classroom e do boardroom só poderá ser realizado com a autorização dos professores 
    Coordenadores ( Prof. Eduardo Moresi, Prof. Jair Barbosa e Prof. Mário Braga)

10. Provisoriamente, os equipamentos serão guardados nas mochilas e estas serão guardadas no boardroom.  
    O acesso será controlado pelos professores. 

11. Todo aluno tem a responsabilidade de manter o espaço BEPiD limpo e bem cuidado.

12. Pelo fato dos laboratórios seguirem o conceito paperless não existem lixeiras (com exceção dos banheiros). 
    Qualquer lixo deverá ser guardado pelo aluno que irá despejá-lo em lixeira fora dos laboratórios. 
    As lixeiras dos banheiros não poderão ser usadas para este fim.

13. Os Thunderbolts display possuem um conector MagSafe que carrega e transfere energia para os MacBooks. 
    Os cabos thunderbolts possuem um adaptador na ponta que em hipótese nenhuma deverá ser retirado. 

14. O sistema automatizado (iPads) dos laboratórios é de responsabilidade e uso exclusivo dos professores.



<p align="right">Brasília, 02 de Fevereiro de 2015.</p>


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
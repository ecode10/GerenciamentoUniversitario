<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina.aspx.cs" Inherits="BEPiD.Pagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div style="text-align:right;"><iframe src="//www.facebook.com/plugins/like.php?href=http%3A%2F%2Fwww.bepiducb.com.br&amp;width&amp;layout=standard&amp;action=like&amp;show_faces=true&amp;share=true&amp;height=80" scrolling="no" frameborder="0" style="border:none; overflow:hidden; height:20px;" allowTransparency="true"></iframe></div>

     <!-- Scripts -->
	<script src="/Scripts/1.5.1.jquery.min.js"></script>
	<script src="/Scripts/carousel/js/slides.min.jquery.js"></script>
	<script>
	    $(function () {
	        // Set starting slide to 1
	        var startSlide = 1;
	        // Get slide number if it exists
	        if (window.location.hash) {
	            startSlide = window.location.hash.replace('#', '');
	        }
	        // Initialize Slides
	        $('#slides').slides({
	            preload: true,
	            preloadImage: '/Scripts/carousel/img/loading.gif',
	            generatePagination: true,
	            play: 5000,
	            pause: 2500,
	            hoverPause: true,
	            // Get the starting slide
	            start: startSlide,
	            animationComplete: function (current) {
	                // Set the slide number as a hash
	                //window.location.hash = '#' + current;
	            }
	        });
	    });
	</script>  
    
    <!-- CAROUSEL BEGIN	 -->			
		    <div id="section">
			    <div id="example">
				    <div id="slides">
					    <div class="slides_container">
                            <div class="slide" style="text-align:center;">
                                <a href="/AppsPublicados.aspx"><img width="" src="/Imagem/bit_journey.jpg" alt="Bit Journey" border="0" /></a>
                            </div>
                            <div class="slide" style="text-align:center;">
                                <a href="/AppsPublicados.aspx"><img width="" src="/Imagem/mac_xcode.jpg" alt="Xcode" border="0" /></a>
                            </div>
                            <div class="slide" style="text-align:center;">
                                <a href="/AppsPublicados.aspx"><img width="" src="/Imagem/apple_watch.png" alt="Developer Apple Watch" border="0" /></a>
                            </div>
                            <div class="slide" style="text-align:center;">
                                <a href="/AppsPublicados.aspx"><img width="" src="/Imagem/app_rec_tag.jpg" alt="RecTag" border="0" /></a>
                            </div>
                            <div class="slide" style="text-align:center;">
                                <a href="/ProcessoSeletivo"><img width="" src="/Imagem/imagem-inscricoes-Mulher.png" alt="faça a sua inscrição no programa" border="0" /></a>						    </div>
						    <div class="slide" style="text-align:center;">
                                &nbsp;<a href="/ProcessoSeletivo"><img width="" src="/Imagem/imagem-inscricoes-Principal.png" alt="faça a sua inscrição no programa" border="0" /></a>
                                <br /><br /><br /><br /><br /><br /><br /><br />
						    </div>
						    <%--<div class="slide" style="text-align:center;">
							    <a href="/ProcessoSeletivo"><img src="/Imagem/imagem-inscricoes-Principal.png" alt="faça a sua inscrição no programa" border="0" /></a>
                                <br /><br /><br /><br /><br /><br /><br /><br />
						    </div>--%>
				        </div>
					    <%--<a href="#" class="prev"><img src="/Scripts/carousel/img/arrow-prev.png" width="24" height="43" alt="Arrow Prev"></a>
					    <a href="#" class="next"><img src="/Scripts/carousel/img/arrow-next.png" width="24" height="43" alt="Arrow Next"></a>--%>
				    </div>
					<%--<img src="/Scripts/carousel/img/example-frame.png" width="739" height="341" alt="Example Frame" id="frame">--%>
			    </div>
		    </div>

        
    <!-- CAROUSEL END -->

    
    
    <%--<div class="jumbotron">
        <h1>BEPiD UCB</h1>
        <p class="lead">Universidade Católica de Brasília - UCB - Participe do processo seletivo 2015/1.
        </p>
        <p>
            <a href="/About" target="_self" class="btn btn-primary btn-large">Saiba mais sobre o projeto &raquo;</a>
            <%--<a href="/ProcessoSeletivo" class="btn btn-primary btn-large">Segunda etapa &raquo;</a>--%>
     <%--   </p>
    </div>--%>
    
    <div class="row">
        <div class="col-md-4">
            <h2>Alunos</h2>
            <p>
                
                Este site é elaborado para os alunos e professores do programa BEPiD Universidade Católica de Brasília.
                <br /><br />
                O Instituto Eldorado e a Universidade Católica de Brasília - UCB, em parceria com a Apple, estão equipando salas de aulas e 
                laboratórios com o que existe de mais moderno, para que você se torne um desenvolvedor apto a publicar na loja de aplicativos (Apple Store)
                e se torne um futuro empreendedor.
            </p>
            <%--<p>
                <a class="btn btn-default" href="/Aluno">Veja mais &raquo;</a>
            </p>--%>
        </div>
        <div class="col-md-4">
            <h2>Processo seletivo:</h2>
            <p>
                Lista de aprovados<br />
                <a class="btn btn-default" href="/ProcessoSeletivo">Aprovados</a>
            </p><br />
            <h3>Dúvidas frequentes</h3>
            <p>
                Perguntas e respostas disponíveis <a href="DuvidasFrequentes" class="btn btn-default">aqui</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contato</h2>
            <p>
                Em caso de dúvidas, entre em contato conosco pelo site <a href="Contact"> pelo link contato</a>.
                <br /><Br />Se você é aluno do curso, faça seu login e veja mais informações.
            </p>
            <p>
                <a class="btn btn-default" href="/Contact">Veja mais &raquo;</a>
            </p>
        </div>
    </div>
    <br /><br />
    
</asp:Content>

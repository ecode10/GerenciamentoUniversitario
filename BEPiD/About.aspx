<%@ Page Title="Sobre o Programa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="BEPiD.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
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
							    <a href="/ProcessoSeletivo"><img src="/Imagem/imagem-inscricoes-Mulher.png" alt="faça a sua inscrição no programa" border="0" /></a>
						    </div>
						    <div class="slide" style="text-align:center;">
							    <a href="/ProcessoSeletivo"><img src="/Imagem/imagem-inscricoes-Principal.png" alt="faça a sua inscrição no programa" border="0" /></a>
						    </div>
				        </div>
					    <%--<a href="#" class="prev"><img src="/Scripts/carousel/img/arrow-prev.png" width="24" height="43" alt="Arrow Prev"></a>
					    <a href="#" class="next"><img src="/Scripts/carousel/img/arrow-next.png" width="24" height="43" alt="Arrow Next"></a>--%>
				    </div>
					<%--<img src="/Scripts/carousel/img/example-frame.png" width="739" height="341" alt="Example Frame" id="frame">--%>
			    </div>
		    </div>
    <!-- CAROUSEL END -->


    <h2><%: Title %></h2>
    <p> 
        BEPiD - Programa Educacional Brasileiro de Desenvolvimento para iOS - Universidade Católica de Brasília - UCB.<br /><br />
        Se você é criativo, motivado a aprender e quer ser um desenvolvedor especialista em iOS, inscreva-se para participar de um programa inovador no Brasil. 
        O Instituto Eldorado e a Universidade Católica de Brasília - UCB, em colaboração com a Apple, estão equipando salas de aulas e laboratórios com o que existe de mais moderno, para que você se torne um desenvolvedor apto a publicar na AppStore e seja um futuro empreendedor.
    </p>

    <br />
    <div class="row">
        <div class="col-md-4">
            <h3>O programa conta com:</h3>
            <p>
                * Infraestrutura de última geração;<br />
                * Laboratório inovadores;<br />
                * Professores especialistas em iOS; <br />
                * Material didático digital em português;<br />
                * Auxílio Financeiro para o aluno;<br />
                * Perfil empreendedor e criativo;<br />
                * Alta motivação;<br />
                * Conhecimento em desenvolvimento;<br />
                * 100 vagas.
            </p>
            <%--<p>
                <a class="btn btn-default" href="/Aluno">Veja mais &raquo;</a>
            </p>--%>
        </div>
        <div class="col-md-4">
            <h3>Carga horária:</h3>
            <p>
                * 20 horas por semana; <br />
                * Período vespertino; <br />
                * Local: Universidade Católica de Brasília.
            </p>
            <br />
        </div>
        <div class="col-md-4">
            <h3>Dúvidas:</h3>
            <p>
                Aqui você pode esclarecer suas dúvidas referentes ao projeto.
                <Br /><Br />Perguntas e respostas disponíveis <a href="DuvidasFrequentes" class="btn btn-default">aqui</a>
            </p>
            </p>
        </div>
    </div>
</asp:Content>

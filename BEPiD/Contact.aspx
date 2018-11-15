<%@ Page Title="Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BEPiD.Contact" %>

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

    <div class="row">
        <div class="col-md-6">
            <h3>Projeto BEPiD UCB</h3>
            <br />
            <p>
                <table>
                    <tr>
                        <td>
                            Nome:
                        </td>
                        <td>
                            <asp:TextBox runat="server" CssClass="form-control" id="txtNome" Width="228px"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtNome" Display="Dynamic" ValidationGroup="limpar" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            E-mail:
                        </td>
                        <td>
                            <asp:TextBox runat="server" CssClass="form-control" id="txtEmail" Width="252px"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtEmail" Display="Dynamic" ValidationGroup="limpar" runat="server" />
                            <asp:RegularExpressionValidator ValidationGroup="limpar" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Digite um e-mail válido." ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Descrição:
                        </td>
                        <td>
                            <asp:TextBox runat="server" id="txtDescricao" CssClass="form-control" TextMode="MultiLine" Height="131px" Width="261px"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ControlToValidate="txtDescricao" Display="Dynamic" ValidationGroup="limpar" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <br />
                            <asp:Button Text="Enviar" ID="cmdEnviar" class="btn btn-primary btn-large" runat="server" OnClick="cmdEnviar_Click" ValidationGroup="limpar" />
                            <asp:Button Text="Limpar" ID="cmdLimpar" CssClass="btn btn-primary btn-large" runat="server" OnClick="cmdLimpar_Click" />
                        </td>
                    </tr>
                    <tr><td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Visible="false" ValidationGroup="limpar" />
                        <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label></td></tr>
                </table>
            </p>
        </div>
        <div class="col-md-6">
            <h3>Dúvidas</h3>
            <p>
                <p>Em caso de dúvidas, mande e-mail para nós ou preencha o formulário ao lado e clique enviar.</p>
                <br />
                <address>
                    Endereço: <br />
                    Campus I - QS 07 Lote 01 EPCT, Águas Claras - CEP: 71966-700 - Taguatinga/DF - Telefone: (61) 3356-9000
                </address>

                <%--<address>
                    <strong>Suporte:</strong> bepiducb at gmail.com<br />
                </address>--%>
            </p>
            <br />
            <h3>Dúvidas frequentes</h3>
            <p>
                Perguntas e respostas disponíveis <a href="DuvidasFrequentes" class="btn btn-default">aqui</a>
            </p>
        </div>
    </div>
</asp:Content>

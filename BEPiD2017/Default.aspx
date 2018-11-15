<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BEPiD2017.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /><br />
<!-- Promo Section "Statistics" -->
<div class="w3-container w3-row w3-center w3-dark-grey w3-padding-64" id="processoseletivo">
    <h2>Processo seletivo</h2>
    O próximo processo seletivo será realizado no segundo semestre do ano de 2018.<br />
    Em caso dúvidas, favor entrar em contato pelo link <a href="Contact.aspx">contato</a>.
</div>    


<!-- About Section -->
<div class="w3-container" style="padding:128px 16px" id="about">
  <h3 class="w3-center">SOBRE BEPiD UCB</h3>
  <p class="w3-center w3-large">Brazilian Education Program for iOS Development <br /> Localizado na <a href="http://www.ucb.br" target="_blank">Universidade Católica de Brasília (campos 1)</a></p>
  <div class="w3-row-padding w3-center" style="margin-top:64px">
    <div class="w3-quarter">
        <img src="Images/luminaria.png" width="120" />
      <p class="w3-large">Desenvolvendo</p>
      <p>O BEPiD UCB é um lugar que você pode dar vida para suas ideias e aprender na prática a como estar preparado para o mercado de trabalho. </p>
    </div>
    <div class="w3-quarter">
      <img src="Images/mente.png" width="100" />
      <p class="w3-large">Aprendizado</p>
      <p>Um projeto composto por estudantes e professores que visa o aprendizado técnico, mas principalmente trazer experiência para o desenvolvedor e designer como profissionais.</p>
    </div>
    <div class="w3-quarter">
      <img src="Images/cavalo.png" width="100" />
      <p class="w3-large">Compartilhamento</p>
      <p>Um lugar onde todos compartilham o que mais gostam de fazer e assim, crescem juntos a cada dia. O espaço que você pode sair da sua zona de conforto e se preparar ainda mais para o futuro.</p>
    </div>
    <div class="w3-quarter">
        <br />
        <img src="Images/porco.png" width="120" /><br />
        <p class="w3-large">Negócios</p>
        <p>Lugar onde você pode criar a sua Startup e gerar negócios com a sua ideia. Além de ter capacitações técnicas, terá sobre empreendedorismo.</p>
    </div>
  </div>
</div>

<%--<!-- Promo Section - "We know design" -->
<div class="w3-container w3-light-grey" style="padding:128px 16px">
  <div class="w3-row-padding">
    <div class="w3-col m6">
      <h3>We know design.</h3>
      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod<br>tempor incididunt ut labore et dolore.</p>
      <p><a href="https://www.w3schools.com/w3css/tryw3css_templates_startup.htm#work" class="w3-button w3-black"><i class="fa fa-th">&nbsp;</i> View Our Works</a></p>
    </div>
    <div class="w3-col m6">
      <img class="w3-image w3-round-large" src="/TemplateBEPiD_files/phone_buildings.jpg" alt="Buildings" width="700" height="394">
    </div>
  </div>
</div>--%>

<!-- Equipe de técnico -->
<div class="w3-container" style="padding:128px 16px" id="team">
  <h3 class="w3-center">Equipe</h3>
  <p class="w3-center w3-large">Tutores Mestres e Especialistas responsáveis pela capacitação técnica</p>
  <div class="w3-row-padding w3-grayscale" style="margin-top:64px">
    
      <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Jane" style="width:200px;"></div>
        <div class="w3-container">
          <h3>Felipe Carvalho</h3>
          <p class="w3-opacity">Professor de Design</p>
          <p>Professor especialista em Design <Br /> <br /></p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>
      
      <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Júlio" style="width:200px;"></div>
        <div class="w3-container">
          <h3>Júlio Cezar</h3>
          <p class="w3-opacity">Professor de Programação</p>
          <p>Professor do curso de Ciência da Computação e Tutor BEPiD</p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>
    <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Marcos" style="width:200px; align-content:center;"></div>
        <div class="w3-container">
          <h3>Marcos Morais</h3>
          <p class="w3-opacity">Professor de Programação</p>
          <p>Instrutor e Tutor BEPiD<br /><br /></p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>
    <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Mauricio" style="width:200px;"></div>
        <div class="w3-container">
          <h3>Mauricio Junior</h3>
          <p class="w3-opacity">Professor de Programação</p>
          <p>Professor do curso de Ciência da Computação e Tutor BEPiD</p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>
    <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Michel" style="width:200px;"></div>
        <div class="w3-container">
          <h3>Michel Lopes</h3>
          <p class="w3-opacity">Professor de Programação</p>
          <p>Professor do curso de Ciência da Computação e Tutor BEPiD</p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>

    <div class="w3-col l3 m6 w3-margin-bottom">
      <div class="w3-card-2">
        <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Osmala" style="width:200px;"></div>
        <div class="w3-container">
          <h3>Waldemar Osmala</h3>
          <p class="w3-opacity">Professor de Design</p>
          <p>Instrutor e Tutor BEPiD </p>
          <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
        </div>
      </div>
    </div>

      <div class="w3-col l3 m6 w3-margin-bottom">
          <div class="w3-card-2">
            <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Jane" style="width:200px;"></div>
            <div class="w3-container">
              <h3>Braga</h3>
              <p class="w3-opacity">Professor Mestre</p>
              <p>Infraestrutura do projeto BEPiD</p>
              <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
            </div>
          </div>
        </div>

        <div class="w3-col l3 m6 w3-margin-bottom">
          <div class="w3-card-2">
            <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Jane" style="width:200px;"></div>
            <div class="w3-container">
              <h3>Jair</h3>
              <p class="w3-opacity">Professor Mestre</p>
              <p>Pedagógico do projeto BEPiD</p>
              <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
            </div>
          </div>
        </div>

        <div class="w3-col l3 m6 w3-margin-bottom">
          <div class="w3-card-2">
            <div style="text-align:center;"><img src="/TemplateBEPiD_files/Icone-Amigo_Homem-390x390.png" alt="Jane" style="width:200px;"></div>
            <div class="w3-container">
              <h3>Moresi</h3>
              <p class="w3-opacity">Professor Doutor</p>
              <p>Gerente Geral do projeto BEPiD </p>
              <%--<p><button class="w3-button w3-light-grey w3-block">Contato</button></p>--%>
            </div>
          </div>
        </div>

  </div>
</div>


<!-- Promo Section "Statistics" -->
<div class="w3-container w3-row w3-center w3-dark-grey w3-padding-64" id="categoria">
    <h2>Aplicativos publicados de acordo com as categorias</h2>
    <asp:ListView runat="server" ID="dtListViewQuantidadeApps">
        <ItemTemplate>
            <div class="w3-quarter">
                <span class="w3-xxlarge"><%# Eval("contador") %></span>
                <br><%# Eval("NomeCategoria") %>
            </div>
        </ItemTemplate>
    </asp:ListView>
    <div style="text-align:right;"><a href="AppsPublicados"><h3>+ Aplicativos</h3></a></div>
</div>

<!-- Work Section -->



<%--<div class="w3-container" style="padding:128px 16px" id="work">
  <h3 class="w3-center">OUR WORK</h3>
  <p class="w3-center w3-large">What we've done for people</p>

  <div class="w3-row-padding" style="margin-top:64px">
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_mic.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A microphone">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_phone.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A phone">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_drone.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A drone">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_sound.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="Soundbox">
    </div>
  </div>

  <div class="w3-row-padding w3-section">
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_tablet.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A tablet">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_camera.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A camera">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_typewriter.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A typewriter">
    </div>
    <div class="w3-col l3 m6">
      <img src="/TemplateBEPiD_files/tech_tableturner.jpg" style="width:100%" onclick="onClick(this)" class="w3-hover-opacity" alt="A tableturner">
    </div>
  </div>
</div>--%>

<!-- Modal for full size images on click-->
<div id="modal01" class="w3-modal w3-black" onclick="this.style.display=&#39;none&#39;">
  <span class="w3-button w3-xxlarge w3-black w3-padding-large w3-display-topright" title="Close Modal Image">×</span>
  <div class="w3-modal-content w3-animate-zoom w3-center w3-transparent w3-padding-64">
    <img id="img01" class="w3-image">
    <p id="caption" class="w3-opacity w3-large"></p>
  </div>
</div>

<!-- Skills Section -->
<div class="w3-container w3-light-grey w3-padding-64">
  <div class="w3-row-padding">
    <div class="w3-col m6">
      <h1>Desenvolvedores</h1>
      <p>
          O desenvolvedor é aquele que usando técnicas de programação procura sempre a melhor forma para criar um novo produto. Participando desde o inicio do processo de criação, esse profissional precisa entender a linguagem de software para que possa colocar em prática as suas ideias e trazer algo que facilite o dia de quem irá utilizar o aplicativo.
      </p>
    </div>
    <div class="w3-col m6">
        <h1>Designers</h1>
        <p>
            A principal tarefa do designer de aplicativo e jogos é transformar o que foi criado pelo desenvolvedor para algo que facilite o dia a dia de quem utiliza o software. Sempre pensando na interface para que seja atraente, criativa e inovadora, os profissionais dessa área precisam ter experiência com o pacote adobe, Photoshop e Illustrator, ser estudioso e principalmente ligado nas tendências.
        </p>
    </div>
  </div>
</div>

<!-- Pricing Section -->
<%--<div class="w3-container w3-center w3-dark-grey" style="padding:128px 16px" id="pricing">
  <h3>PRICING</h3>
  <p class="w3-large">Choose a pricing plan that fits your needs.</p>
  <div class="w3-row-padding" style="margin-top:64px">
    <div class="w3-third w3-section">
      <ul class="w3-ul w3-white w3-hover-shadow">
        <li class="w3-black w3-xlarge w3-padding-32">Basic</li>
        <li class="w3-padding-16"><b>10GB</b> Storage</li>
        <li class="w3-padding-16"><b>10</b> Emails</li>
        <li class="w3-padding-16"><b>10</b> Domains</li>
        <li class="w3-padding-16"><b>Endless</b> Support</li>
        <li class="w3-padding-16">
          <h2 class="w3-wide">$ 10</h2>
          <span class="w3-opacity">per month</span>
        </li>
        <li class="w3-light-grey w3-padding-24">
          <button class="w3-button w3-black w3-padding-large">Sign Up</button>
        </li>
      </ul>
    </div>
    <div class="w3-third">
      <ul class="w3-ul w3-white w3-hover-shadow">
        <li class="w3-red w3-xlarge w3-padding-48">Pro</li>
        <li class="w3-padding-16"><b>25GB</b> Storage</li>
        <li class="w3-padding-16"><b>25</b> Emails</li>
        <li class="w3-padding-16"><b>25</b> Domains</li>
        <li class="w3-padding-16"><b>Endless</b> Support</li>
        <li class="w3-padding-16">
          <h2 class="w3-wide">$ 25</h2>
          <span class="w3-opacity">per month</span>
        </li>
        <li class="w3-light-grey w3-padding-24">
          <button class="w3-button w3-black w3-padding-large">Sign Up</button>
        </li>
      </ul>
    </div>
    <div class="w3-third w3-section">
      <ul class="w3-ul w3-white w3-hover-shadow">
        <li class="w3-black w3-xlarge w3-padding-32">Premium</li>
        <li class="w3-padding-16"><b>50GB</b> Storage</li>
        <li class="w3-padding-16"><b>50</b> Emails</li>
        <li class="w3-padding-16"><b>50</b> Domains</li>
        <li class="w3-padding-16"><b>Endless</b> Support</li>
        <li class="w3-padding-16">
          <h2 class="w3-wide">$ 50</h2>
          <span class="w3-opacity">per month</span>
        </li>
        <li class="w3-light-grey w3-padding-24">
          <button class="w3-button w3-black w3-padding-large">Sign Up</button>
        </li>
      </ul>
    </div>
  </div>
</div>--%>

<!-- Contact Section -->
<%--<div class="w3-container w3-light-grey" style="padding:128px 16px" id="contact">
  <h3 class="w3-center">CONTACT</h3>
  <p class="w3-center w3-large">Lets get in touch. Send us a message:</p>
  <div class="w3-row-padding" style="margin-top:64px">
    <div class="w3-half">
      <p><i class="fa fa-map-marker fa-fw w3-xxlarge w3-margin-right"></i> Chicago, US</p>
      <p><i class="fa fa-phone fa-fw w3-xxlarge w3-margin-right"></i> Phone: +00 151515</p>
      <p><i class="fa fa-envelope fa-fw w3-xxlarge w3-margin-right"> </i> Email: mail@mail.com</p>
      <br>
      <form action="https://www.w3schools.com/action_page.php" target="_blank">
        <p><input class="w3-input w3-border" type="text" placeholder="Name" required="" name="Name"></p>
        <p><input class="w3-input w3-border" type="text" placeholder="Email" required="" name="Email"></p>
        <p><input class="w3-input w3-border" type="text" placeholder="Subject" required="" name="Subject"></p>
        <p><input class="w3-input w3-border" type="text" placeholder="Message" required="" name="Message"></p>
        <p>
          <button class="w3-button w3-black" type="submit">
            <i class="fa fa-paper-plane"></i> SEND MESSAGE
          </button>
        </p>
      </form>
    </div>
    <div class="w3-half">
      <!-- Add Google Maps -->
      <div id="googleMap" class="w3-greyscale-max" style="width: 100%; height: 510px; position: relative; overflow: hidden;"><div style="height: 100%; width: 100%; position: absolute; top: 0px; left: 0px; background-color: rgb(229, 227, 223);"><div class="gm-style" style="position: absolute; z-index: 0; left: 0px; top: 0px; height: 100%; width: 100%; padding: 0px; border-width: 0px; margin: 0px;"><div tabindex="0" style="position: absolute; z-index: 0; left: 0px; top: 0px; height: 100%; width: 100%; padding: 0px; border-width: 0px; margin: 0px;"><div style="z-index: 1; position: absolute; top: 0px; left: 0px; width: 100%; transform-origin: 0px 0px 0px; transform: matrix(1, 0, 0, 1, 0, 0);"><div style="position: absolute; left: 0px; top: 0px; z-index: 100; width: 100%;"><div style="position: absolute; left: 0px; top: 0px; z-index: 0;"><div aria-hidden="true" style="position: absolute; left: 0px; top: 0px; z-index: 1; visibility: inherit;"><div style="width: 256px; height: 256px; position: absolute; left: 147px; top: 160px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 403px; top: 160px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 403px; top: -96px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 147px; top: -96px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 147px; top: 416px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 403px; top: 416px;"></div><div style="width: 256px; height: 256px; position: absolute; left: -109px; top: 160px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 659px; top: 160px;"></div><div style="width: 256px; height: 256px; position: absolute; left: -109px; top: 416px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 659px; top: -96px;"></div><div style="width: 256px; height: 256px; position: absolute; left: -109px; top: -96px;"></div><div style="width: 256px; height: 256px; position: absolute; left: 659px; top: 416px;"></div></div></div></div><div style="position: absolute; left: 0px; top: 0px; z-index: 101; width: 100%;"></div><div style="position: absolute; left: 0px; top: 0px; z-index: 102; width: 100%;"></div><div style="position: absolute; left: 0px; top: 0px; z-index: 103; width: 100%;"><div style="position: absolute; left: 0px; top: 0px; z-index: -1;"><div aria-hidden="true" style="position: absolute; left: 0px; top: 0px; z-index: 1; visibility: inherit;"><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 147px; top: 160px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 403px; top: 160px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 403px; top: -96px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 147px; top: -96px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 147px; top: 416px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 403px; top: 416px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: -109px; top: 160px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 659px; top: 160px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: -109px; top: 416px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 659px; top: -96px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: -109px; top: -96px;"></div><div style="width: 256px; height: 256px; overflow: hidden; position: absolute; left: 659px; top: 416px;"></div></div></div></div><div style="position: absolute; left: 0px; top: 0px; z-index: 0;"><div aria-hidden="true" style="position: absolute; left: 0px; top: 0px; z-index: 1; visibility: inherit;"></div></div></div><div class="gm-style-pbc" style="z-index: 2; position: absolute; height: 100%; width: 100%; padding: 0px; border-width: 0px; margin: 0px; left: 0px; top: 0px; opacity: 0;"><p class="gm-style-pbt"></p></div><div style="z-index: 3; position: absolute; height: 100%; width: 100%; padding: 0px; border-width: 0px; margin: 0px; left: 0px; top: 0px;"><div style="z-index: 1; position: absolute; height: 100%; width: 100%; padding: 0px; border-width: 0px; margin: 0px; left: 0px; top: 0px;"></div></div><div style="z-index: 4; position: absolute; top: 0px; left: 0px; width: 100%; transform-origin: 0px 0px 0px; transform: matrix(1, 0, 0, 1, 0, 0);"><div style="position: absolute; left: 0px; top: 0px; z-index: 104; width: 100%;"></div><div style="position: absolute; left: 0px; top: 0px; z-index: 105; width: 100%;"></div><div style="position: absolute; left: 0px; top: 0px; z-index: 106; width: 100%;"></div><div style="position: absolute; left: 0px; top: 0px; z-index: 107; width: 100%;"></div></div></div></div></div></div>
    </div>
  </div>
</div>--%>

</asp:Content>

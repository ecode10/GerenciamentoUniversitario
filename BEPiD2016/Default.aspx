<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BEPiD2016._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    

   <!-- Header -->
    <header>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <img class="img-responsive" src="/img/proc_seletivo.png" alt="">
                </div>
            </div>
        </div>
    </header>

    <!-- BEPID UCB Grid Section -->
    <section id="bepiducb">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>BEPiD UCB</h2>
                    <hr class="star-primary">
                </div>
                <div class="col-sm-12">
                     <p>O BEPiD UCB é um lugar que você pode dar vida para suas ideias e aprender na prática a como estar preparado para o mercado de trabalho. Um projeto composto por estudantes e professores que visa o aprendizado técnico, mas principalmente trazer experiência para o desenvolvedor e designer como profissionais. Um lugar onde todos compartilham o que mais gostam de fazer e assim, crescem juntos a cada dia. O espaço que você pode sair da sua zona de conforto e se preparar ainda mais para o futuro.
                        </p>
                    <!-- <a href="#portfolioModal6" class="portfolio-link" data-toggle="modal">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-search-plus fa-3x"></i>
                            </div>
                        </div>
                    </a> -->
                </div>
            </div>
        </div>
    </section>

    <!-- About Section -->
    <section class="success" id="about">
        <div class="container bg_candidatos">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>CANDIDATOS</h2>
                    <hr class="star-primary">
                </div>
                <div class="col-lg-4 col-lg-offset-2 ">
                    <div class="retangulo_candidatos"><h4>Desenvolvedores</h4>
                    </div>
                    <p>O desenvolvedor é aquele que usando técnicas de programação procura sempre a melhor forma para criar um novo produto. Participando desde o inicio do processo de criação, esse profissional precisa entender a linguagem de software para que possa colocar em prática as suas ideias e trazer algo que facilite o dia de quem irá utilizar o aplicativo</p>
                 </div>
                <div class="col-lg-4">
                    <div class="retangulo_candidatos"><h4>Designers</h4>
                    </div>
                    <p>A principal tarefa do designer de aplicativo e jogos é transformar o que foi criado pelo desenvolvedor para algo que facilite o dia a dia de quem utiliza o software. Sempre pensando na interface para que seja atraente, criativa e inovadora, os profissionais dessa área precisam ter experiência com o pacote adobe, Photoshop e Illustrator, ser estudioso e principalmente ligado nas tendências.</p>
                </div>
            </div>
        </div>
    </section>

    <!-- Portfolio Grid Section -->
    <section id="videos">
        <div class="container">
            <div class="row">
               <div class="col-lg-12 text-center">
                    <h2>VÍDEOS</h2>
                    <hr class="star-primary">
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4 videos-item">
                    <a href="#portfolioModal1" class="portfolio-link" data-toggle="modal" onClick="toggleVideo();">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-youtube-play fa-3x"><h3>BEPiD 2016</h3></i>
                            </div>
                        </div>
                        <img src="/img/portfolio/teaser.png" class="img-responsive" alt="Teaser">
                    </a>
                </div>
                <div class="col-sm-4 videos-item">
                    <a href="#portfolioModal2" class="portfolio-link" data-toggle="modal" onClick="toggleVideo2();">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-youtube-play fa-3x"><h3>DESIGNERS</h3></i>
                            </div>
                        </div>
                        <img src="/img/portfolio/designer.png" class="img-responsive" alt="Designers">
                    </a>
                </div>
                <div class="col-sm-4 videos-item">
                    <a href="#portfolioModal3" class="portfolio-link" data-toggle="modal" onClick="toggleVideo();">
                        <div class="caption">
                            <div class="caption-content">
                                <i class="fa fa-youtube-play fa-3x"><h3>DEVELOPERS</h3></i>
                            </div>
                        </div>
                        <img src="/img/portfolio/developer.png" class="img-responsive" alt="Developers">
                    </a>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

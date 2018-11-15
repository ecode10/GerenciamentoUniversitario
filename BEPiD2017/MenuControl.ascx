<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.ascx.cs" Inherits="BEPiD2017.MenuControl" %>

<!-- Navbar (sit on top) -->
<div class="w3-top">
  <div class="w3-bar w3-white w3-card-2" id="myNavbar">
    <a href="/default" class="w3-bar-item w3-button w3-wide">
    <img src="Images/bepiducb_logo.png" width="150" /></a>
    <!-- Right-sided navbar links -->
    <div class="w3-right w3-hide-small">
      <a href="/#processoseletivo" class="w3-bar-item w3-button">Sobre</a>
        <a href="/AppsPublicados" class="w3-bar-item w3-button">Apps</a>
      <a href="/#team" class="w3-bar-item w3-button">Equipe</a>
      <%--<a href="/#manager" class="w3-bar-item w3-button"> Gestores</a>--%>
        <a href="/processoseletivo" class="w3-bar-item w3-button"> Processo Seletivo</a>
      <a href="http://aluno.bepiducb.com.br" target="_blank" class="w3-bar-item w3-button">Ambiente do Aluno</a>
      <a href="http://admin.bepiducb.com.br" target="_blank" class="w3-bar-item w3-button">Ambiente da Equipe</a>
        <a href="/contact" class="w3-bar-item w3-button">Fale Conosco</a>
    </div>
    <!-- Hide right-floated links on small screens and replace them with a menu icon -->

    <a href="javascript:void(0)" class="w3-bar-item w3-button w3-right w3-hide-large w3-hide-medium" onclick="w3_open()">
      <i class="fa fa-bars"></i>
    </a>
  </div>
</div>

<!-- Sidebar on small screens when clicking the menu icon -->
<nav class="w3-sidebar w3-bar-block w3-black w3-card-2 w3-animate-left w3-hide-medium w3-hide-large" style="display:none" id="mySidebar">
  <a href="javascript:void(0)" onclick="w3_close()" class="w3-bar-item w3-button w3-large w3-padding-16">Fechar ×</a>
  <a href="/#about" onclick="w3_close()" class="w3-bar-item w3-button">Sobre</a>
  <a href="/AppsPublicados" class="w3-bar-item w3-button">Apps</a>
  <a href="/#team" onclick="w3_close()" class="w3-bar-item w3-button">Equipe</a>
  <%--<a href="/#manager" onclick="w3_close()" class="w3-bar-item w3-button">Gestores</a>--%>
  <a href="/processoseletivo" onclick="w3_close()" class="w3-bar-item w3-button">Processo Seletivo</a>
  <a href="http://aluno.bepiducb.com.br" target="_blank" onclick="w3_close()" class="w3-bar-item w3-button">Ambiente do Aluno</a>
  <a href="http://admin.bepiducb.com.br" target="_blank" onclick="w3_close()" class="w3-bar-item w3-button">Ambiente do Tutor</a>
  <a href="/contact" onclick="w3_close()" class="w3-bar-item w3-button">Fale Conosco</a>
</nav>
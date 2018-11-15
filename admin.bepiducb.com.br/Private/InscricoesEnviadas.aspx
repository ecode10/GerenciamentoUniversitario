<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="InscricoesEnviadas.aspx.cs" Inherits="admin.bepiducb.com.br.Private.InscricoesEnviadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br />
    <div class="row">
        <h2>Inscrições</h2>
        <br />
        <table style="width:100%;" border="0" id="tablePrincipal" runat="server">
            <tr>
                <td>
                    Nome: <asp:TextBox ID="txtNome" CssClass="form-control"  runat="server" MaxLength="30" Width="265px"></asp:TextBox>
                </td>
                <td >
                    Situação: 
                    <asp:DropDownList ID="cmbSituacao" CssClass="form-control"  runat="server" Width="171px">
                        <asp:ListItem Text="Processo Seletivo" Value="P" Selected="True"  />
                        <asp:ListItem Text="Ativos" Value="A"  />
                        <asp:ListItem Text="Inativos" Value="I"  />
                        <asp:ListItem Text="Inscrições Antigas" Value="O" />
                    </asp:DropDownList>
                </td>
                <td>
                    Universidades:
                    <asp:dropdownlist runat="server" ID="cmbInstituicao" CssClass="form-control">
                                    <asp:ListItem Text="Selecione" Value="" />
                                    <asp:listitem text="ESCS" Value="ESCS" />
                                    <asp:listitem text="IFB" Value="IFB" />
                                    <asp:listitem text="IFG" Value="IFG" />
                                    <asp:listitem text="IESPLAN" Value="IESPLAN" />
                                    <asp:listitem text="IESB" Value="IESB" />
                                    <asp:listitem text="UCB" Value="UCB" />
                                    <asp:listitem text="Faculdade Projeção" Value="Faculdade Projeção" />
                                    <asp:listitem text="SENAC"  Value="SENAC"/>
                                    <asp:listitem text="FADM" Value="Faculdade de Artes Dulcina de Moraes" />
                                    <asp:listitem text="FATE" Value="FATE" />
                                    <asp:listitem text="FTB" Value="FTB" />
                                    <asp:listitem text="FACITEC" Value="FACITEC" />
                                    <asp:listitem text="FACIPLAC" Value="FACIPLAC" />
                                    <asp:listitem text="Faculdade Anhanguera" Value="Faculdade Anhanguera" />
                                    <asp:ListItem Text="Faculdade UNICESUMAR" Value="UNICESUMAR" />
                                    <asp:listitem text="UNIPLAN" Value="UNIPLAN" />
                                    <asp:listitem text="UNIDESC" Value="UNIDESC" />
                                    <asp:listitem text="UNIDF" Value="UNIDF" />
                                    <asp:listitem text="UNOPAR" Value="UNOPAR" />
                                    <asp:listitem text="UNICESP" Value="UNICESP" />
                                    <asp:listitem text="UNIEURO" Value="UNIEURO" />
                                    <asp:listitem text="UNB"  Value="UNB"/>
                                    <asp:listitem text="UNIP" Value="UNIP" />
                                    <asp:listitem text="UPIS" Value="UPIS" />
                                    <asp:listitem text="UNICEUB"  Value="UNICEUB"/>
                                </asp:dropdownlist>
                </td>
                <td>
                    Sexo:
                    <asp:dropdownlist runat="server" ID="cmbSexo" CssClass="form-control" Width="200px">
                                <asp:ListItem Text="Selecione" Value="" />
                                <asp:listitem text="Masculino" Value="M" />
                                <asp:listitem text="Feminino"  Value="F"/>
                    </asp:dropdownlist>
                </td>
                <td style="">
                    &nbsp;Ano: <asp:TextBox runat="server" id="txtAno" CssClass="form-control" MaxLength="4" Width="100"></asp:TextBox>
                </td>
                <td>
                    Tipo:
                    <asp:dropdownlist runat="server" ID="cmbTipoAluno" CssClass="form-control">
                                <asp:ListItem Text="Selecione" Value="" />
                                <asp:listitem text="Designer" Value="1" />
                                <asp:listitem text="Developer"  Value="2"/>
                            </asp:dropdownlist>
                </td>
            </tr>
            <tr><td>&nbsp;</td></tr>
            <tr>
                <td colspan="6" align="center">
                    <asp:Button Text="Buscar" ID="cmdBuscar" CssClass="btn btn-primary btn-large" OnClick="cmdBuscar_Click" runat="server" />
                    &nbsp;
                    
                    <a href="InscricoesExcel.aspx" target="_blank" visible="false" class="btn btn-default" id="cmdGerarExcel" runat="server">Gerar Excel</a>
                    <br />
                    <div style="font-size:x-small;">Por favor, utilize o máximo de filtro possível.</div>
                </td>
            </tr>
        </table>
        <hr size="1" />


        <div class="col-md-20">
            
                <asp:Label ID="lblAlunos" runat="server" ForeColor="Red" />
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="4" AutoGenerateColumns="False" PageSize="50" 
                    DataKeyNames="IdAluno" OnRowCommand="grdAluno_RowCommand" AllowPaging="True" 
                    OnPageIndexChanging="grdAluno_PageIndexChanging">
                    <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="Primeira" LastPageText="Última" />
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <HeaderStyle BackColor="#d1d1d1" />
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome" ItemStyle-Wrap="false" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="NomeUniversidade" HeaderText="Universidade" />
                        <asp:BoundField DataField="Curso" HeaderText="Curso"/>
                        <%--<asp:BoundField DataField="Semestre" HeaderText="Semestre"/>--%>
                        <asp:BoundField DataField="Formatura" HeaderText="Formatura"/>
                        <asp:BoundField DataField="CPF" HeaderText="CPF"/>
                        <asp:BoundField DataField="DataNascimento" HeaderText="Dt Nasc." DataFormatString="{0:d}"/>
                        <%--<asp:BoundField DataField="Identidade" HeaderText="Identidade"/>--%>
                        <%--<asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Ocupacao" HeaderText="Ocupação" />--%>
                        <asp:HyperLinkField DataTextField="linkPortifolio" HeaderText="link" Target="_blank" DataNavigateUrlFields="linkPortifolio" />
                        <asp:ButtonField ButtonType="Button" Text="I" CommandName="Inativar" HeaderText="" />
                        <asp:ButtonField ButtonType="Button" Text="A" CommandName="Ativar" HeaderText="" />
                    </Columns>
                </asp:GridView>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>



</asp:Content>

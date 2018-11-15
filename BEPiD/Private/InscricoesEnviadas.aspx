<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="InscricoesEnviadas.aspx.cs" Inherits="BEPiD.Private.InscricoesEnviadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br />
    <div class="row">
        <h2>Inscrições enviadas</h2>
        <br />
        <table style="width:100%;">
            <tr>
                <td>
                    Nome: <asp:TextBox ID="txtNome" CssClass="form-control"  runat="server" MaxLength="30" Width="265px"></asp:TextBox>
                </td>
                <td >
                    Situação: 
                    <asp:DropDownList ID="cmbSituacao" CssClass="form-control"  runat="server" Width="171px">
                        <asp:ListItem Text="Processo Seletivo" Value="P" Selected="True"  />
                    </asp:DropDownList>
                </td>
                <td>
                    Universidades:
                    <asp:dropdownlist runat="server" ID="cmbInstituicao" CssClass="form-control">
                                <asp:ListItem Text="Selecione" Value="" />
                                <asp:listitem text="UCB" Value="UCB" />
                                <asp:listitem text="UNB"  Value="UNB"/>
                                <asp:listitem text="UPIS" Value="UPIS" />
                                <asp:listitem text="UNICEUB"  Value="UNICEUB"/>
                                <asp:listitem text="Faculdade Projeção" Value="Faculdade Projeção" />
                                <asp:listitem text="UNIP" Value="UNIP" />
                                <asp:listitem text="FACITEC" Value="FACITEC" />
                                <asp:listitem text="FACIPLAC" Value="FACIPLAC" />
                                <asp:listitem text="IESB" Value="IESB" />
                                <asp:listitem text="Faculdade Anhanguera" Value="Faculdade Anhanguera" />
                                <asp:listitem text="IESPLAN" Value="IESPLAN" />
                                <asp:listitem text="UNIPLAN" Value="UNIPLAN" />
                                <asp:listitem text="FATE" Value="FATE" />
                                <asp:listitem text="FTB" Value="FTB" />
                                <asp:listitem text="UNIDESC" Value="UNIDESC" />
                                <asp:listitem text="UNIDF" Value="UNIDF" />
                                <asp:listitem text="UNOPAR" Value="UNOPAR" />
                                <asp:listitem text="UNICESP" Value="UNICESP" />
                                <asp:listitem text="IFB" Value="IFB" />
                                <asp:listitem text="ESCS" Value="ESCS" />
                                <asp:listitem text="IFG" Value="IFG" />
                            </asp:dropdownlist>
                </td>
                <td>
                    Sexo:
                    <asp:dropdownlist runat="server" ID="cmbSexo" CssClass="form-control">
                                <asp:ListItem Text="Selecione" Value="" />
                                <asp:listitem text="Masculino" Value="M" />
                                <asp:listitem text="Feminino"  Value="F"/>
                            </asp:dropdownlist>
                </td>
                
                <td style="width: 164px">
                    Ano: <asp:TextBox runat="server" id="txtAno" CssClass="form-control" MaxLength="4" Width="100"></asp:TextBox>
                </td>
                <td>
                    <asp:Button Text="Buscar" ID="cmdBuscar" CssClass="btn btn-primary btn-large" OnClick="cmdBuscar_Click" runat="server" />
                </td>
                <td>
                    <a href="InscricoesExcel"><img src="../Imagem/excel.png" title="Clique aqui e faça download das inscrições em excel." border="0"/></a>
                </td>
            </tr>
        </table>
        <hr size="1" />


        <div class="col-md-12">
            <h3>Todos os alunos</h3>
                <asp:Label ID="lblAlunos" runat="server" ForeColor="Red" />
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="2" AutoGenerateColumns="False" 
                    DataKeyNames="IdAluno" OnRowCommand="grdAluno_RowCommand" AllowPaging="True" OnPageIndexChanging="grdAluno_PageIndexChanging">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="NomeUniversidade" HeaderText="Universidade" />
                        <asp:BoundField DataField="Curso" HeaderText="Curso"/>
                        <asp:BoundField DataField="Semestre" HeaderText="Semestre"/>
                        <asp:BoundField DataField="Formatura" HeaderText="Formatura"/>
                        <asp:BoundField DataField="CPF" HeaderText="CPF"/>
                        <asp:BoundField DataField="Identidade" HeaderText="Identidade"/>
                        <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Ocupacao" HeaderText="Ocupação" />
                        <asp:ButtonField ButtonType="Button" Text=" I " CommandName="Inativar" HeaderText="Inativar" Visible="false" />
                        <asp:ButtonField ButtonType="Button" Text=" A " CommandName="Ativar" HeaderText="Ativar" Visible="false" />
                    </Columns>
                </asp:GridView>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>



</asp:Content>

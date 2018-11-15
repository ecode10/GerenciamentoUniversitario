<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="AllUser.aspx.cs" Inherits="BEPiD.Private.AllUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <h2>Área de administração</h2>
        <br />
        <table style="width:70%;">
            <tr>
                <td style="width: 323px">
                    Nome: <asp:TextBox ID="txtNome" CssClass="form-control"  runat="server" MaxLength="30" Width="265px"></asp:TextBox>
                </td>
                <td style="width: 225px">
                    Situação: 
                    <asp:DropDownList ID="cmbSituacao" CssClass="form-control"  runat="server" Width="171px">
                        <asp:ListItem Text=" Selecione " Value="" />
                        <asp:ListItem Text="Ativo" Value="A" Selected="True"  />
                        <asp:ListItem Text="Inativo" Value="I" />
                    </asp:DropDownList>
                </td>
                <td style="width: 164px">
                    Ano: <asp:TextBox runat="server" id="txtAno" CssClass="form-control" MaxLength="4" Width="100"></asp:TextBox>
                </td>
                <td>
                    <asp:Button Text="Buscar" ID="cmdBuscar" CssClass="btn btn-primary btn-large" OnClick="cmdBuscar_Click" runat="server" />
                </td>
            </tr>
        </table>
        <hr size="1" />


        <div class="col-md-12">
            <h3>Todos os alunos</h3>
                <asp:Label ID="lblAlunos" runat="server" ForeColor="Red" />
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" 
                    DataKeyNames="IdAluno" OnRowCommand="grdAluno_RowCommand">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:BoundField DataField="Numero" HeaderText="Kit" />
                        <asp:ButtonField ButtonType="Link" DataTextField="Nome" CommandName="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="NomeUniversidade" HeaderText="Universidade" />
                        <asp:BoundField DataField="CPF" HeaderText="CPF"/>
                        <asp:BoundField DataField="Situacao" HeaderText="Sit." />
                        <asp:ButtonField ButtonType="Button" Text=" I " CommandName="Inativar" HeaderText="Ina" />
                        <asp:ButtonField ButtonType="Button" Text=" A " CommandName="Ativar" HeaderText="Ativ" />
                        <asp:TemplateField HeaderText="Vinc">
                            <ItemTemplate>
                                <a href="AllVinculo?id=<%#Eval("IdAluno") %>" title="Vincular máquinas">Vinc</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Aditivo">
                            <ItemTemplate>
                                <a href="Contrato-Aditivo?id=<%#Eval("IdAluno") %>" title="Contrato aditivo">Adit</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Outoga">
                            <ItemTemplate>
                                <a href="Termo-Outorga?id=<%#Eval("IdAluno") %>" title="Termo de outorga">Out.</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Equip">
                            <ItemTemplate>
                                <a target="_blank" href="Instrumento-Particular?id=<%#Eval("IdAluno") %>" title="Instrumento Particular">Equip.</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>


</asp:Content>

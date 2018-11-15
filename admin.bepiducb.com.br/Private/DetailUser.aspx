<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="DetailUser.aspx.cs" Inherits="admin.bepiducb.com.br.Private.DetailUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        
        <div class="col-md-12">
            <h3>Detalhe do aluno</h3>
                
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" 
                    DataKeyNames="IdAluno">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                Nome: <%# Eval("Nome") %><br />
                                Endereço: <%# Eval("Endereco") %><br />
                                Cidade: <%#Eval("Cidade") %> - Estado: <%# Eval("Estado") %><br />
                                CEP: <%#Eval("CEP") %><br /><br />

                                Telefone: <%# Eval("Telefone") %><br />
                                Celular: <%# Eval("Celular") %><br />
                                Email: <%#Eval("Email") %><br />
                                Universidade: <%#Eval("NomeUniversidade") %><br /><br />

                                CPF: <%#Eval("CPF") %><br />
                                Identidade: <%#Eval("Identidade") %> - órgão: <%#Eval("Orgao") %><br />
                                Data Expedição: <%#Eval("DataExpedicaoIdentidade").ToString().Substring(0,10) %><br />
                                Data de nascimento: <%#Eval("DataNascimento").ToString().Substring(0,10) %><br />
                                Estado Civil: <%#Eval("EstadoCivil") %><br /><br />

                                Banco: <%#Eval("BancoNome") %><br />
                                Agência: <%#Eval("Agencia") %><br />
                                Conta: <%#Eval("Conta") %><br />

                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <img src='http://s3.amazonaws.com/BEPiD/<%# Eval("Foto") %>' style='border-radius:20px; width:200px;'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            <br /><p align="center">
                    <asp:Button Text="Voltar" runat="server" class="btn btn-primary btn-large" id="cmdVoltar" OnClientClick="javascript:history.back();"/>
                 </p>
        </div>
        <%--<div class="col-md-4">
            <h3>Acesso</h3>
            <p>Acesse todos os alunos cadastros estão do lado na grid ao lado. Qualquer outra informação, favor entrar em contato com o administrador do sistema.</p>
        </div>--%>
    </div>

</asp:Content>

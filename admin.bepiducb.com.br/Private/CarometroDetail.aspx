<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="CarometroDetail.aspx.cs" Inherits="admin.bepiducb.com.br.Private.CarometroDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Carômetro</h2>
    <br />
    <asp:HiddenField ID="hdIdAluno" runat="server" />
    <asp:HiddenField ID="hdIdProfessor" runat="server" />

    <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
        CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" 
        DataKeyNames="IdAluno">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <table style="width:60%">
                        <tr>
                            <td>
                                <img src='http://s3.amazonaws.com/BEPiD/<%# Eval("Foto") %>' style='border-radius:20px; width:200px;'/>
                            </td>
                            <td>
                                <b>Número do Kit:</b> <%#Eval("Numero") %><br /><br /><b>Nome:</b> <%#Eval("Nome") %><br /><br /><b>Instituição:</b> <%#Eval("NomeUniversidade") %><br />
                            </td>
                        </tr>
                    </table>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br /><hr size="1" />
    <fieldset>
        <h3>Avaliação:</h3>
        <asp:GridView runat="server" Width="100%" ID="gridAvaliacaoContador" GridLines="None" 
            CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" AllowPaging="false">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table style="width:70%">
                            <tr>
                                <td>
                                    <%#Eval("tipoAvaliacao").ToString() %>: <%#Eval("contador") %>
                                </td>
                            </tr>
                        </table>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
           
            </Columns>
        </asp:GridView>
    </fieldset>
    <br /><hr size="1" />
    <fieldset>
        <h3>Área de observação</h3>
        <asp:GridView runat="server" Width="100%" ID="gridAvaliacao" GridLines="None" 
            CellPadding="2" CellSpacing="2" AutoGenerateColumns="false" AllowPaging="true"
            DataKeyNames="IdAluno" OnPageIndexChanging="gridAvaliacao_PageIndexChanging" PageSize="1">
            <PagerSettings FirstPageText=" << " LastPageText =" >>" NextPageText=" > " PreviousPageText=" < " />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table style="width:70%">
                            <tr>
                                <td>
                                    Data: <%#Eval("DataAvaliacao").ToString().Substring(0,10) %>
                                </td>
                                <td>
                                    Professor: <%#Eval("NomeProfessor") %>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Assunto: <%#Eval("AssuntoAvaliacao") %>
                                </td>
                                <td>
                                    Tipo: <%#Eval("TipoAvaliacao") %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    Mensagem: <%#Eval("MensagemAvaliacao") %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"><br /><br /></td>
                            </tr>
                        </table>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
           
            </Columns>
        </asp:GridView>
    </fieldset>

    <br /><hr size="1" />
    <br />
    <fieldset>
        <table style="width:100%">
            <tr>
                <td>Data: </td>
                <td>
                    <asp:TextBox ID="txtDataAvaliacao" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" MaxLength="10" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Assunto:</td>
                <td>
                    <asp:DropDownList runat="server" CssClass="form-control"  ID="cmbAssunto">
                        <asp:ListItem Text=" << Selecione >>" Value="" />
                        <asp:ListItem Text="Comportamento / Interesse" Value="Comportamento" />
                        <asp:ListItem Text="Aprendizado / Progresso" Value="Aprendizado" />
                        <asp:ListItem Text="Presença / Pontualidade" Value="Pontualidade" />
                        <asp:ListItem Text="Outros" Value="Outros" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Tipo:</td>
                <td>
                    <asp:DropDownList runat="server" CssClass="form-control"  ID="cmbTipo">
                        <asp:ListItem Text=" << Selecione >>" Value="" />
                        <asp:ListItem Text="Positivo" Value="Positivo" />
                        <asp:ListItem Text="Negativo" Value="Negativo" />
                        <asp:ListItem Text="Neutro" Value="Neutro" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Mensagem:</td>
                <td>
                    <asp:TextBox ID="txtMensagem" CssClass="form-control"  runat="server" TextMode="MultiLine" Height="105px" Width="305px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center" style="text-align:center">
                    <asp:Button ID="cmdEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary btn-large" OnClick="cmdEnviar_Click" />
                    &nbsp;
                    <asp:Button Text="Voltar" ID="cmdVoltar" CssClass="btn btn-primary btn-large" OnClick="cmdVoltar_Click" runat="server" />
                    <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </fieldset>


</asp:Content>

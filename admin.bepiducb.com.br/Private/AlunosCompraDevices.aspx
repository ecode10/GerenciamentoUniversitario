<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="AlunosCompraDevices.aspx.cs" Inherits="admin.bepiducb.com.br.Private.AlunosCompraDevices" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="row">
        <h3>Informação dos alunos e devices</h3>
        <br />
        <table style="width:70%;">
            <tr>
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


        <div class="col-md-20">
            
                <asp:Label ID="lblAlunos" runat="server" ForeColor="Red" />
                <asp:GridView runat="server" Width="100%" ID="grdAluno" GridLines="None" 
                    CellPadding="2" CellSpacing="2" AutoGenerateColumns="false">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <HeaderStyle BackColor="Yellow" />
                    <Columns>
                        <asp:BoundField DataField="Numero" HeaderText="Kit" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <%--<asp:BoundField DataField="DataNascimento" HeaderText="Dt.N." DataFormatString="{0:M-dd-yyyy}" />--%>
                        <%--<asp:BoundField DataField="Endereco" HeaderText="Endereco" />--%>
                        <%--<asp:BoundField DataField="CEP" HeaderText="CEP" />--%>
                        <%--<asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                        <asp:BoundField DataField="Celular" HeaderText="Celular" />
                        <asp:BoundField DataField="CPF" HeaderText="CPF" />--%>
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Identidade" HeaderText="Identidade" />
                        <%--<asp:BoundField DataField="orgao" HeaderText="Órgão" />
                        <asp:BoundField DataField="dataexpedicaoidentidade" HeaderText="Dt Ex." DataFormatString="{0:M-dd-yyyy}" />--%>
                        <asp:BoundField DataField="NrSerie" HeaderText="NrSerie" />
                        <%--<asp:TemplateField HeaderText="Vinc">
                            <ItemTemplate>
                                <a href="AllVinculo?id=<%#Eval("IdAluno") %>" title="Vincular máquinas">Vinc</a>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:TemplateField HeaderText="Devices">
                            <ItemTemplate>
                                <a href="Maquinas?id=<%#Eval("IdAluno") %>" title="Maquinas">Verificar</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </div>
    </div>

</asp:Content>

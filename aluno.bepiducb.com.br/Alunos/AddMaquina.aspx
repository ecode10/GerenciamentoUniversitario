<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="AddMaquina.aspx.cs" Inherits="aluno.bepiducb.com.br.Alunos.AddMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h1>Vincular máquina</h1>
          <div class="col-md-8">
                <p>
                    Vincule suas máquinas ao sistema utilizando o formulário abaixo:
                    <table style="width:100%;">
                        <tr>
                            <td>Tipo:</td>
                            <td>
                                <asp:DropDownList CssClass="form-control"  ID="cmbTipo" runat="server">

                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ErrorMessage="*" Display="Dynamic" ForeColor="Red" ControlToValidate="cmbTipo" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Modelo:</td>
                            <td>
                                <asp:TextBox CssClass="form-control" placeholder="Exemplo: 16 GB ou 13 polegadas 512 SSD" runat="server" id="txtModelo"></asp:TextBox>
                                <asp:RequiredFieldValidator ErrorMessage="*" Display="Dynamic" ForeColor="Red" ControlToValidate="txtModelo" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Número de Série: </td>
                            <td>
                                <asp:TextBox CssClass="form-control" placeholder="Exemplo: XXX909X00X" runat="server" id="txtNrSerie"></asp:TextBox>
                                <asp:RequiredFieldValidator ErrorMessage="*" ForeColor="Red" ControlToValidate="txtNrSerie" Display="Dynamic" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>IMEI: </td>
                            <td>
                                <asp:TextBox CssClass="form-control" runat="server"  placeholder="Exemplo:0923082A9290982" id="txtIMEI"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <br />  
                                <asp:Button Text="Gravar" class="btn btn-primary btn-large" ID="cmdGravar" runat="server" OnClick="cmdGravar_Click" />
                                &nbsp;<asp:Button Text="Limpar" class="btn btn-primary btn-large" ID="cmdLimpar" ValidationGroup="limpar" runat="server" OnClick="cmdLimpar_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </p>
            </div>  

            <div class="col-md-12">
                <p>
                    <asp:GridView runat="server" DataKeyNames="IdMaquina" ID="grdMaquinas" AutoGenerateColumns="false" CellPadding="2" CellSpacing="2"
                        GridLines="None" Width="100%" OnRowCommand="grdMaquinas_RowCommand">
                        <AlternatingRowStyle BackColor="#f1f1f1" />
                        <HeaderStyle BackColor="#c1c1c1" Height="30" />
                        <Columns>
                            <asp:BoundField DataField="DescricaoTipo" HeaderText="Descrição" />
                            <asp:BoundField DataField="ModeloMaquina" HeaderText="Modelo" />
                            <asp:BoundField DataField="NrSerieMaquina" HeaderText="Nr Série" />
                            <asp:BoundField DataField="IMEI" HeaderText="Nr IMEI" />
                            <%--<asp:BoundField DataField="IdMaquina" HeaderText="Id" />--%>
                            <asp:ButtonField HeaderText="Deletar" ButtonType="Button" Text="Deletar" CommandName="Deletar" />
                        </Columns>
                    </asp:GridView>
                </p>
            </div>
    </div>



</asp:Content>

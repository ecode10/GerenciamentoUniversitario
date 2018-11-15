<%@ Page Title="" Language="C#" MasterPageFile="~/Logado.Master" AutoEventWireup="true" CodeBehind="Maquinas.aspx.cs" Inherits="BEPiD.Private.Maquinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
  <div class="row">
        <h3>Máquinas vinculadas</h3>
        <div class="col-md-6">
            <p>
                <asp:GridView runat="server" ID="grdMaquinas" AutoGenerateColumns="false" CellPadding="2" CellSpacing="2"
                    GridLines="None" Width="80%">
                    <AlternatingRowStyle BackColor="#f1f1f1" />
                    <Columns>
                        <asp:BoundField DataField="DescricaoTipo" HeaderText="Descrição" />
                        <asp:BoundField DataField="ModeloMaquina" HeaderText="Modelo" />
                        <asp:BoundField DataField="NrSerieMaquina" HeaderText="Nr Série" />
                        <asp:BoundField DataField="IdMaquina" HeaderText="Id" />
                    </Columns>
                </asp:GridView>
            </p>
        </div>
      <div class="col-md-6">
            <p>
                <h3>Vincular</h3>
                <table>
                    <tr>
                        <td>Tipo:</td>
                        <td>
                            <asp:DropDownList CssClass="form-control"  ID="cmbTipo" runat="server">

                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>Modelo:</td>
                        <td>
                            <asp:TextBox CssClass="form-control"  runat="server" id="txtModelo"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" Display="Dynamic" ForeColor="Red" ControlToValidate="txtModelo" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Número de Série:</td>
                        <td>
                            <asp:TextBox CssClass="form-control"  runat="server" id="txtNrSerie"></asp:TextBox>
                            <asp:RequiredFieldValidator ErrorMessage="*" ForeColor="Red" ControlToValidate="txtNrSerie" Display="Dynamic" runat="server" />
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
    </div>


</asp:Content>

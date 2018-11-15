<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.Master" AutoEventWireup="true" CodeBehind="AllVinculo.aspx.cs" Inherits="BEPiD.Private.AllVinculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div class="row">
      <h3>Máquinas vinculadas</h3>
      <asp:HiddenField ID="hdIdAluno" runat="server" />  
      <asp:HiddenField ID="hdIdMaquina" runat="server" />
      <div class="col-md-5">
            <p>
                <h3>Vincular</h3>
                <table>
                    <tr>
                        <td>Tipo:</td>
                        <td>
                            <asp:DropDownList CssClass="form-control" ID="cmbTipo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbTipo_SelectedIndexChanged">

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
                            <asp:Button Text="Atualizar" class="btn btn-primary btn-large" ID="cmdAtualizar" runat="server" OnClick="cmdAtualizar_Click" />
                            <input type="button" class="btn btn-primary btn-large" id="cmdVoltar" value="Voltar" onclick="javascript: location.href = 'AllUser';" />
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
        <div class="col-md-6">
            <p>
                <asp:Label ID="lblNumeroAluno" runat="server" Font-Size="Larger"></asp:Label>
                <br /><br />
                <asp:Label ID="lblImagem" runat="server"></asp:Label><br />
                <asp:Label ID="lblNomeAluno" runat="server"></asp:Label><br />
                <asp:Label ID="lblEmailAluno" runat="server"></asp:Label><br />
                <br /><br />                
            </p>
        </div>
    </div>



</asp:Content>

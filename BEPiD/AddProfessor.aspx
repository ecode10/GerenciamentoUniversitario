<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProfessor.aspx.cs" Inherits="BEPiD.AddProfessor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


  <div class="row">
        <h3>Cadastrar Professor</h3>
        
      <div class="col-md-6">
            <p>
                <table style="width:60%;">
                    <tr>
                        <td>Nome:</td>
                        <td>
                            <asp:TextBox runat="server" CssClass="form-control" id="txtNome" Width="368px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Email:</td>
                        <td>
                            <asp:TextBox runat="server" CssClass="form-control" id="txtEmail" Width="270px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Senha:</td>
                        <td>
                            <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" id="txtPW" Width="229px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <br />  
                            <asp:Button Text="Enviar" class="btn btn-primary btn-large" ID="cmdEnviar" runat="server" OnClick="cmdEnviar_Click" />
                        </td>
                    </tr>
                </table>
            </p>
        </div>
        <div class="col-md-6">
            <p>
                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>                
            </p>
        </div>
    </div>

</asp:Content>

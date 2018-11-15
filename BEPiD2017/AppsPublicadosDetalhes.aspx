<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppsPublicadosDetalhes.aspx.cs" Inherits="BEPiD2017.AppsPublicadosDetalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="w3-container" style="padding:128px 16px" id="about">

        <asp:GridView runat="server" ID="gridAplicativos" GridLines="None" AutoGenerateColumns="false" Width="100%" CellPadding="10" CellSpacing="10" ShowHeader="false">
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td style="align-content:center; vertical-align:top;">
                                    <b><%# Eval("NomeAplicativo") %></b><br />
                                    <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo") %>" style="border-radius:20px;" />
                                </td>
                                <td style="vertical-align:top;">
                                    Grupo de desenvolvimento: <Br />
                                    <%# Eval("NomeGrupoAplicativo") %>
                                    
                                    <br /><br />
                                    Challenge: <br />
                                    <%# Eval("Challenge")%>
                                </td>
                                <td style="text-align:left;">
                                    <a href="<%#Eval("LinkAplicativo") %>" target="_blank"><img src="Images/itunes-app-store-logo.png" style="border:0px; width:200px;" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    Descrição do aplicativo: <br />
                                    <%# Eval("DescricaoAplicativo") %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    
                                    
                                    <div style="overflow-x:auto; overflow-y:auto; height:400px; width:100%;" runat="server" Visible='<%# !Eval("ImagemAplicativo1").ToString().Equals("")%>'>
                                        <div style="overflow-x:scroll; height:400px; width:150%;">
                                            <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo1") %>" /> &nbsp;
                                            <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo2") %>" /> &nbsp;
                                            <img src="http://s3.amazonaws.com/BEPiD/<%# Eval("ImagemAplicativo3") %>" /> &nbsp;
                                        </div>
                                    </div>
                                    
                                </td>
                            </tr>
                        </table>
                        
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
        </asp:GridView>
        <div style="text-align:center;">
            <asp:Button Text="Voltar" ID="cmdVoltar" OnClick="cmdVoltar_Click" runat="server" />
        </div>
    </div>

</asp:Content>

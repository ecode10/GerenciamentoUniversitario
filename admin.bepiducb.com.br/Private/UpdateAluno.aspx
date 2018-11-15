<%@ Page Title="" Language="C#" MasterPageFile="~/LogadoNovo.Master" AutoEventWireup="true" CodeBehind="UpdateAluno.aspx.cs" Inherits="admin.bepiducb.com.br.Private.UpdateAluno" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <script src="../Scripts/funcoes.js"></script>
    <br /><br />

    <div class="row">
        <div class="col-md-4">
            <h3>Alterar dados pessoais</h3>
            <p>
                <asp:Table ID="tbCadastro" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            Nome:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" ID="txtNome" placeholder="Digite o nome completo"  MaxLength="100" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNome" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            E-mail:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" ID="txtEmail" MaxLength="200" placeholder="Digite um e-mail válido" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtEmail" Display="Dynamic" runat="server" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>
                        </asp:TableCell>
                    </asp:TableRow>
                    
                    <asp:TableRow>
                        <asp:TableCell>
                            Telefone:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" onBlur="f_sValMasTel(this)" ID="txtTelefone" placeholder="Exemplo: 61-33333333" MaxLength="12" onKeyPress="f_bSoNumero(event.keyCode)" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Celular:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" onBlur="f_sValMasTel(this)" ID="txtCelular" placeholder="Exemplo: 61-9999999" MaxLength="12" onKeyPress="f_bSoNumero(event.keyCode)" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtCelular" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            CEP:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtCEP" placeholder="Exemplo: 70.000-000" MaxLength="10" onKeyPress="f_sMascaraCEP(event.keyCode,null);" onKeyUp="f_sMascaraCEP(null,this);" runat="server" Width="120"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    
                    <asp:TableRow>
                        <asp:TableCell>
                            Endereço:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtEndereco" placeholder="Exemplo: Rua X Qd. Y2" MaxLength="500" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Cidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtCidade" placeholder="Exemplo: Brasília" MaxLength="50" Width="150" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Estado:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList runat="server" ID="cmbEstado" CssClass="form-control">
                                <asp:ListItem Text=" Selecione " Value="" />
                                <asp:ListItem Text="Acre" Value="AC" />
                                <asp:ListItem Text="Alagoas" Value="AL" />  
                                <asp:ListItem Text="Amapá" Value="AP" />
                                <asp:ListItem Text="Amazonas" Value="AM"/>
                                <asp:ListItem Text="Bahia" Value="BA" />
                                <asp:ListItem Text="Ceará" Value="CE" />
                                <asp:ListItem Text="Distrito Federal" Value="DF" />
                                <asp:ListItem Text="Espírito Santo" Value="ES" />
                                <asp:ListItem Text="Goiás" Value="GO" />
                                <asp:ListItem Text="Maranhão" Value="MA" />
                                <asp:ListItem Text="Mato Grosso" Value="MT" />
                                <asp:ListItem Text="Mato Grosso do Sul" Value="MS" />
                                <asp:ListItem Text="Minas Gerais" Value="MG" />
                                <asp:ListItem Text="Pará" Value="PA" />
                                <asp:ListItem Text="Paraíba" Value="PB" />
                                <asp:ListItem Text="Paraná" Value="PR" />
                                <asp:ListItem Text="Pernambuco" Value="PE" />
                                <asp:ListItem Text="Piauí" Value="PI" />
                                <asp:ListItem Text="Rio de Janeiro" Value="RJ" />
                                <asp:ListItem Text="Rio Grande do Norte" Value="RN" />
                                <asp:ListItem Text="Rio Grande do Sul" Value="RS" />
                                <asp:ListItem Text="Rondônia" Value="RO" />
                                <asp:ListItem Text="Roraima" Value="RR" />
                                <asp:ListItem Text="Santa Catarina" Value="SC" />
                                <asp:ListItem Text="São Paulo" Value="SP" />
                                <asp:ListItem Text="Sergipe" Value="SE" />
                                <asp:ListItem Text="Tocantins" Value="TO" />
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="cmbEstado" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Universidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtUniversidade" MaxLength="150" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*"  Display="Dynamic" ControlToValidate="txtUniversidade" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            CPF:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" Enabled="false" placeholder="Digite apenas números" onKeyPress="f_sMascaraCPF(event.keyCode,null);" onKeyUp="f_sMascaraCPF(null,this);" ID="txtCPF" MaxLength="15" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCPF" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Identidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtIdentidade" placeholder="Exemplo: 123440" onKeyPress="f_bSoNumero(event.keyCode)" MaxLength="20" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtIdentidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Órgão exp.:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtOrgao" MaxLength="30" placeholder="Exemplo: SSP-DF" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtOrgao" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Data Expedição:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" placeholder="Exemplo: 10/02/1982" onBlur="f_bValidaData(this);" ID="txtDataExpedicao" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtIdentidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Nacionalidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtNacionalidade" placeholder="Exemplo: Brasileira" MaxLength="50" runat="server"></asp:TextBox>
                            Ex: Brasileira
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNacionalidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                           Data Nasc.:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" placeholder="Exemplo: 10/02/1982" onBlur="f_bValidaData(this);" ID="txtDataNascimento" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtDataNascimento" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                           Estado Civil:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:dropdownlist runat="server" ID="cmbEstadoCivil" CssClass="form-control">
                                <asp:listitem text="Selecione" Selected="True" Value="" />
                                <asp:listitem text="Solteiro(a)" Value="Solteiro(a)" />
                                <asp:listitem text="Casado(a)" Value="Casado(a)" />
                                <asp:ListItem Text="Divorciado(a)" Value="Divorciado(a)" />
                                <asp:ListItem Text="Viúvo(a)" Value="Viúvo(a)" />
                            </asp:dropdownlist>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="cmbEstadoCivil" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    
                </asp:Table>
            </p>
            <%--<p>
                <a class="btn btn-default" href="#">Veja mais &raquo;</a>
            </p>--%>
        </div>
        <div class="col-md-4">
            <h3>Dados bancários</h3>
            <p>
                <asp:Table ID="Table1" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            Nome do Banco:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtNomeBanco" Width="220" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNomeBanco" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Número do Banco:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtNrBanco" onKeyPress="f_bSoNumero(event.keyCode)" MaxLength="10" Width="90" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNrBanco" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableCell>
                            Agência:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtAgencia" onKeyPress="f_bSoNumero(event.keyCode)" MaxLength="10" Width="90" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*"  Display="Dynamic" ControlToValidate="txtAgencia" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableCell>
                            Conta:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtConta" onKeyPress="f_bSoNumero(event.keyCode)" MaxLength="30"  runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtConta" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                            <br /><br />
                            <asp:button text="Atualizar" class="btn btn-primary btn-large" OnClick="cmdCadastrar_Click" ID="cmdCadastrar" runat="server" />
                            
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </p>
        </div>

        <div class="col-md-4">
            <h3>Resultado</h3>
            <p>
                Veja aqui o resultado depois de enviar seus dados.<br />
                <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </div>


</asp:Content>

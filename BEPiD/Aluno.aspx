<%@ Page Title="Cadastro de Aluno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="BEPiD.Aluno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <script src="Scripts/funcoes.js"></script>
    <div class="jumbotron">
        <h1>Atenção</h1>
        <p class="lead">O aluno deve preencher os dados abaixo e aguardar nossa confirmação por e-mail.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h3>Dados pessoais</h3>
            <p>
                <asp:Table ID="tbCadastro" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>
                            Nome:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtNome"  MaxLength="100" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNome" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            E-mail:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtEmail" MaxLength="200" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtEmail" Display="Dynamic" runat="server" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Senha:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtPassword" MaxLength="100" TextMode="Password" runat="server" Width="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtPassword" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Telefone:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" onBlur="f_sValMasTel(this)" ID="txtTelefone" MaxLength="12" onKeyPress="f_bSoNumero(event.keyCode)" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Celular:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" onBlur="f_sValMasTel(this)" ID="txtCelular" MaxLength="12" onKeyPress="f_bSoNumero(event.keyCode)" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtCelular" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            CEP:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtCEP" MaxLength="10" onKeyPress="f_sMascaraCEP(event.keyCode,null);" onKeyUp="f_sMascaraCEP(null,this);" runat="server" Width="120"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    
                    <asp:TableRow>
                        <asp:TableCell>
                            Endereço:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtEndereco" MaxLength="500" runat="server" Width="220"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Cidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtCidade" MaxLength="50" Width="150" runat="server"></asp:TextBox>
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
                            <asp:TextBox CssClass="form-control" onKeyPress="f_sMascaraCPF(event.keyCode,null);" onKeyUp="f_sMascaraCPF(null,this);" ID="txtCPF" MaxLength="15" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCPF" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Identidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtIdentidade" onKeyPress="f_bSoNumero(event.keyCode)" MaxLength="20" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtIdentidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Órgão exp.:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtOrgao" MaxLength="30" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtOrgao" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            Nacionalidade:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control"  ID="txtNacionalidade" MaxLength="50" runat="server"></asp:TextBox>
                            Ex: Brasileira
                            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNacionalidade" Display="Dynamic" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                           Data Nasc.:
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox CssClass="form-control" onBlur="f_bValidaData(this);" ID="txtDataNascimento" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox> Ex.:10/02/1984
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
                            <asp:button text="Cadastrar" class="btn btn-primary btn-large" OnClick="cmdCadastrar_Click" ID="cmdCadastrar" runat="server" />
                            &nbsp;<asp:button text="Limpar" class="btn btn-primary btn-large" ID="cmdLimpar" ValidationGroup="Limpar" OnClick="cmdLimpar_Click" runat="server" />
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

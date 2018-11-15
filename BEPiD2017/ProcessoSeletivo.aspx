<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProcessoSeletivo.aspx.cs" Inherits="BEPiD2017.ProcessoSeletivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<script src="TemplateBEPiD_files/funcoes.js"></script>
    
    <div class="w3-container" style="padding:128px 16px" id="about">
            <p style="text-align:center;">
                <h1 style="text-align:center;">Processo Seletivo</h1>
                
                    <div style="text-align:center;">
                        Existem campos obrigatórios. *
                        <asp:Label ID="lblResultado" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                        <asp:Button ID="cmdVoltar" runat="server" Text="Voltar" Visible="false" CssClass="btn btn-primary btn-large" OnClick="cmdVoltar_Click" />
                    </div>

                    
                    <asp:Table ID="tbCadastro" runat="server" Width="50%" HorizontalAlign="Center">
                        <asp:TableRow>
                            <asp:TableCell>
                                Tipo: <asp:RequiredFieldValidator ErrorMessage="Escolha o tipo." ControlToValidate="rdTipoAluno" Display="Dynamic" ForeColor="Red" runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:RadioButtonList runat="server" ID="rdTipoAluno" Width="420" RepeatDirection="Horizontal" AutoPostBack="true" OnSelectedIndexChanged="rdTipoAluno_SelectedIndexChanged">
                                    <asp:ListItem Text="Designer" Value="1" />
                                    <asp:ListItem Text="Desenvolvedor" Value="2" />
                                </asp:RadioButtonList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Nome: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtNome" runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" placeholder="Digite seu nome completo"  ID="txtNome"  MaxLength="200" runat="server" Width="420"></asp:TextBox>
                                <br />
                            </asp:TableCell></asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Nacionalidade: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="cmbNacionalidade" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:DropDownList runat="server" ID="cmbNacionalidade" CssClass="form-control">
                                    <asp:ListItem Text=" Selecione " Value="" />
                                    <asp:ListItem Text="Brasileira" Value="Brasileira" />
                                    <asp:ListItem Text="Americana" Value="Americana" />  
                                    <asp:ListItem Text="Outra" Value="Outra" />
                                </asp:DropDownList>
                                
                                <br />
                            </asp:TableCell></asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Natural: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNatural" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox ID="txtNatural" placeholder="Digite o local de nascimento." onpaste="return false" MaxLength="50" runat="server" CssClass="form-control"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Sexo: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="cmbNacionalidade" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:DropDownList runat="server" ID="cmbSexo" CssClass="form-control">
                                    <asp:ListItem Text=" Selecione " Value="" />
                                    <asp:ListItem Text="Masculino" Value="M" />
                                    <asp:ListItem Text="Feminino" Value="F" />  
                                </asp:DropDownList>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                               Estado Civil: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="cmbEstadoCivil" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:dropdownlist runat="server" ID="cmbEstadoCivil" CssClass="form-control">
                                    <asp:listitem text="Selecione" Selected="True" Value="" />
                                    <asp:listitem text="Solteiro(a)" Value="Solteiro(a)" />
                                    <asp:listitem text="Casado(a)" Value="Casado(a)" />
                                    <asp:ListItem Text="Divorciado(a)" Value="Divorciado(a)" />
                                    <asp:ListItem Text="Viúvo(a)" Value="Viúvo(a)" />
                                </asp:dropdownlist>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                               Data de Nascimento: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtDataNascimento" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Exemplo: 10/02/1984" onBlur="f_bValidaData(this);" ID="txtDataNascimento" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                RG: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtIdentidade" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Digite o registro nacional, apenas números"  ID="txtIdentidade"  MaxLength="50" runat="server"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Órgão expedidor: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtOrgao" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" placeholder="Exemplo: SSP-DF" ID="txtOrgao" MaxLength="30" runat="server"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                               Data de expedição do RG: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtDataExpedicaoRG" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Exemplo: 10/02/1984" onBlur="f_bValidaData(this);" ID="txtDataExpedicaoRG" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                CPF: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCPF" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Digite seu CPF" onKeyPress="f_sMascaraCPF(event.keyCode,null);" onKeyUp="f_sMascaraCPF(null,this);" ID="txtCPF" MaxLength="14" runat="server"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Nome da Mãe: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtNomedaMae" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" ID="txtNomedaMae" placeholder="Digite o nome da mãe completo" MaxLength="200" Width="420" runat="server"></asp:TextBox>
                                
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                E-mail: <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtEmail" Display="Dynamic" runat="server" />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" ID="txtEmail" placeholder="Digite o e-mail válido, mandaremos os aviso por e-mail." MaxLength="200" runat="server" Width="420"></asp:TextBox>
                                
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Telefone:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false"  placeholder="Exemplo: 61-23922200" ID="txtTelefone" MaxLength="20"  runat="server"></asp:TextBox>
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Celular:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false"  placeholder="Exemplo: 61939222000" ID="txtCelular" MaxLength="20" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtCelular" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                CEP:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" ID="txtCEP" MaxLength="10" onKeyPress="f_sMascaraCEP(event.keyCode,null);" placeholder="Exemplo: 71332-100" onKeyUp="f_sMascaraCEP(null,this);" runat="server" Width="320"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Logradouro:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" ID="txtEndereco" placeholder="Digite o endereço." MaxLength="500" runat="server" Width="500"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEndereco" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Cidade:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" ID="txtCidade" placeholder="Digite a cidade onde mora." MaxLength="50" Width="420" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCidade" Display="Dynamic" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Estado:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
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
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                Língua Inglesa:
                            </asp:TableHeaderCell></asp:TableHeaderRow><asp:TableRow>
                            <asp:TableCell>
                                Leitura:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:radiobuttonlist runat="server" ID="rdLeitura" Width="100%" RepeatDirection="Horizontal" BorderStyle="None">
                                    <asp:listitem text="Básico" Value="Basico" Selected="True" />
                                    <asp:listitem text="Intermediário" Value="Intermediario" />
                                    <asp:listitem text="Avançado" Value="Avancado" />
                                </asp:radiobuttonlist>
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Escrita:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:radiobuttonlist runat="server" ID="rdEscrita" Width="100%" RepeatDirection="Horizontal" BorderStyle="None">
                                    <asp:listitem text="Básico" Value="Basico" Selected="True" />
                                    <asp:listitem text="Intermediário" Value="Intermediario" />
                                    <asp:listitem text="Avançado" Value="Avancado" />
                                </asp:radiobuttonlist>
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Comunicação Verbal:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:radiobuttonlist runat="server" ID="rdComunicacaoVerbal" Width="100%" RepeatDirection="Horizontal" BorderStyle="None">
                                    <asp:listitem text="Básico" Value="Basico" Selected="True" />
                                    <asp:listitem text="Intermediário" Value="Intermediario" />
                                    <asp:listitem text="Avançado" Value="Avancado" />
                                </asp:radiobuttonlist>
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Instituição:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:dropdownlist runat="server" ID="cmbInstituicao" CssClass="form-control">
                                    <asp:ListItem Text="Selecione" Value="" />
                                    <asp:listitem text="ESCS" Value="ESCS" />
                                    <asp:listitem text="IFB" Value="IFB" />
                                    <asp:listitem text="IFG" Value="IFG" />
                                    <asp:listitem text="IESPLAN" Value="IESPLAN" />
                                    <asp:listitem text="IESB" Value="IESB" />
                                    <asp:listitem text="UCB" Value="UCB" />
                                    <asp:listitem text="Faculdade Projeção" Value="Faculdade Projeção" />
                                    <asp:listitem text="SENAC"  Value="SENAC"/>
                                    <asp:listitem text="FADM" Value="Faculdade de Artes Dulcina de Moraes" />
                                    <asp:listitem text="FATE" Value="FATE" />
                                    <asp:listitem text="FTB" Value="FTB" />
                                    <asp:listitem text="FACITEC" Value="FACITEC" />
                                    <asp:listitem text="FACIPLAC" Value="FACIPLAC" />
                                    <asp:listitem text="Faculdade AIEC" Value="Faculdade AIEC" />
                                    <asp:listitem text="Faculdade Anhanguera" Value="Faculdade Anhanguera" />
                                    <asp:ListItem Text="Faculdade UNICESUMAR" Value="UNICESUMAR" />
                                    <asp:listitem text="UNIPLAN" Value="UNIPLAN" />
                                    <asp:listitem text="UNIDESC" Value="UNIDESC" />
                                    <asp:listitem text="UNIDF" Value="UNIDF" />
                                    <asp:listitem text="UNOPAR" Value="UNOPAR" />
                                    <asp:listitem text="UNICESP" Value="UNICESP" />
                                    <asp:listitem text="UNIEURO" Value="UNIEURO" />
                                    <asp:listitem text="UNB"  Value="UNB"/>
                                    <asp:listitem text="UNIP" Value="UNIP" />
                                    <asp:listitem text="UPIS" Value="UPIS" />
                                    <asp:listitem text="UNICEUB"  Value="UNICEUB"/>
                                </asp:dropdownlist>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*"  Display="Dynamic" ControlToValidate="cmbInstituicao" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Curso:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Exemplo: Engenharia de Software" ID="txtCurso" MaxLength="100" Width="320" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" ControlToValidate="txtCurso" Display="Dynamic" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Semestre:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:dropdownlist runat="server" ID="cmbSemestre" CssClass="form-control">
                                    <asp:ListItem Text="Selecione" Value="" />
                                    <asp:listitem text="Primeiro" Value="Primeiro" />
                                    <asp:listitem text="Segundo" Value="Segundo" />
                                    <asp:listitem text="Terceiro" Value="Terceiro" />
                                    <asp:listitem text="Quarto" Value="Quarto" />
                                    <asp:listitem text="Quinto" Value="Quinto" />
                                    <asp:listitem text="Sexto" Value="Sexto" />
                                    <asp:listitem text="Sétimo" Value="Sétimo" />
                                    <asp:listitem text="Oitavo" Value="Oitavo" />
                                    <asp:listitem text="Nono" Value="Nono" />
                                    <asp:listitem text="Décimo" Value="Décimo" />
                                    <asp:listitem text="Ou Superior" Value="Ou Superior" />
                                </asp:dropdownlist>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*"  Display="Dynamic" ControlToValidate="cmbSemestre" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                               Previsão de formatura: 
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:TextBox CssClass="form-control" onpaste="return false" placeholder="Exemplo: 10/02/1984" onBlur="f_bValidaData(this);" ID="txtPrevisaoFormatura" onKeyPress="f_sMascaraData(event.keyCode,null);"  onKeyUp="f_sMascaraData(null,this);" runat="server" MaxLength="10"></asp:TextBox> 
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtPrevisaoFormatura" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                Ocupação Atual:
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                            <asp:TableCell>
                                <asp:dropdownlist runat="server" ID="cmbOcupacaoAtual" CssClass="form-control">
                                    <asp:ListItem Text="Selecione" Value="" />
                                    <asp:listitem text="Estudante" Value="Estudante" />
                                    <asp:listitem text="Estagiário" Value="Estagiário" />
                                    <asp:listitem text="Funcionário" Value="Funcionário" />
                                    <asp:listitem text="Autônomo" Value="Autônomo" />
                                </asp:dropdownlist>
                                <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="*"  Display="Dynamic" ControlToValidate="cmbOcupacaoAtual" runat="server" />
                                <br />
                            </asp:TableCell></asp:TableRow><asp:TableRow>
                </asp:TableRow>
               </asp:Table>
                        
                <asp:Table ID="tbDesigner" runat="server" Visible="false" Width="50%" HorizontalAlign="Center">
                    <asp:TableRow>
                        <asp:TableCell>
                            Link do portifólio:
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox ID="txtLinkPortifolio" CssClass="form-control" runat="server" placeholder="Digite aqui o link online do seu portifólio." Width="520" MaxLength="1000" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

                <div style="text-align:center;"><br /><asp:Button ID="cmdEnviar" runat="server" Text="Enviar Inscrição" OnClick="cmdEnviar_Click" class="btn btn-primary btn-large" /><br /></div>
                    </p>
            <%--<p>
                    <a class="btn btn-default" href="#">Veja mais &raquo;</a>
            </p>--%>
            
        </div>

  
</asp:Content>

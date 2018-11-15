<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InscricoesExcel.aspx.cs" Inherits="BEPiD.Private.InscricoesExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BEPiD UCB - Inscrições convertidas para Excel</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>BEPiD UCB Inscrições 2015/1</h2>
        <h2>
            <asp:ImageButton ID="imgButtonExcel" runat="server" ImageUrl="~/Imagem/excel.png" OnClick="imgButtonExcel_Click" ToolTip="Exportar para excel" />
        </h2>
        <br /><br />

        <asp:GridView runat="server" ID="gridAluno"
            CellPadding="3" CellSpacing="3" AutoGenerateColumns="false" OnDataBound="gridAluno_DataBound" OnRowDataBound="gridAluno_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Naturalidade" HeaderText="Natural" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:BoundField DataField="NomeUniversidade" HeaderText="Universidad" />
                <asp:BoundField DataField="CPF" HeaderText="CPF" DataFormatString="{0:D11}" />
                <asp:BoundField DataField="Identidade" HeaderText="RG" />
                <asp:BoundField DataField="Orgao" HeaderText="Órgão Exp." />
                <asp:BoundField DataField="DataExpedicaoIdentidade" HeaderText="Dt. Expedição" />
                <asp:BoundField DataField="DataNascimento" HeaderText="Dt. Nasc." />
                <asp:BoundField DataField="CEP" HeaderText="CEP" />
                <asp:BoundField DataField="EstadoCivil" HeaderText="Estado Civil" />
                <asp:BoundField DataField="Nacionalidade" HeaderText="Nacionalidade" />
                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                <asp:BoundField DataField="NomedaMae" HeaderText="Mãe" />
                <asp:BoundField DataField="LeituraIngles" HeaderText="Ingles Leit." />
                <asp:BoundField DataField="EscritaIngles" HeaderText="Ingles Escrita" />
                <asp:BoundField DataField="ComunicacaoIngles" HeaderText="Ingles Com." />
                <asp:BoundField DataField="Curso" HeaderText="Curso" />
                <asp:BoundField DataField="Semestre" HeaderText="Semestre" />
                <asp:BoundField DataField="Formatura" HeaderText="Formatura" />
                <asp:BoundField DataField="Ocupacao" HeaderText="Ocupação" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>

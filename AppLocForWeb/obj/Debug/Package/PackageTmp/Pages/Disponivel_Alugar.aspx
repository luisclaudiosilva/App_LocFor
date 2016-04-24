<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disponivel_Alugar.aspx.cs" Inherits="AppLocForWeb.Pages.Disponivel_Alugar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Disponivel para Aluguel</title>
    <link type ="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
 <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
     <div class="jumbotron">
        <h1 style="font-size: 40px;">LocFor - Aluguel de Imóveis</h1>
    </div>
   <div class="container">

    <div class="span10 offset1">
            <div class="row">
                <h3 class="well">
                    Disponiveis para Alugar
                </h3>

                 <br />
                <br />

                 <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="False" BackColor="#CCFFCC" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="codigoImovel" HeaderText="Código do Imóvel" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="Bairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="Tipo de Imóvel" SortExpression="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="negocioNome" SortExpression="negocioNome" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="Quantidade de Quarto" SortExpression="quantidadeQuarto"/>
                        <asp:BoundField DataField="tipoSituacao" HeaderText="tipoSituacao" SortExpression="tipoSituacao" />
                        <asp:BoundField DataField="valorImovel" HeaderText="Valor do Imóvel" SortExpression="valorImovel" />
                    </Columns>
                    <EmptyDataTemplate>
        Nenhum registro encontrado.
    </EmptyDataTemplate>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" 
                SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Negocio.negocioNome, Quartos.quantidadeQuarto, situacaoImovel.tipoSituacao, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN Negocio ON Negocio.codigoNegocio = Imovel.codigoNegocio INNER JOIN Quartos ON Quartos.codigoQuarto = Imovel.codigoQuarto INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao WHERE (Bairro.nomeBairro = @nomeBairro) AND (TipoImovel.nomeTipoImovel = @nomeTipoImovel) AND (Quartos.quantidadeQuarto = @quantidadeQuarto) AND (situacaoImovel.tipoSituacao = N'Disponivel') AND (Negocio.negocioNome = N'Aluguel')">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="nomebairro" QueryStringField="nomeBairro" />
                        <asp:QueryStringParameter Name="nomeTipoImovel" QueryStringField="nomeTipoImovel" />
                        <asp:QueryStringParameter Name="quantidadeQuarto" QueryStringField="quantidadeQuarto" />
                    </SelectParameters>
                </asp:SqlDataSource>
                 <br />
                <br />

                <asp:Button ID="Button1" runat="server" Text="Seguinte" CssClass="btn btn-primary"/>
          <a href="/Default.aspx" class="btn btn-default">Inicio</a>
          <br /><br />
            <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
           <footer>
            <p>&copy; 2016 - Projeto Faculdade Evolução</p>
        </footer>


    </div>
    </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compras.aspx.cs" Inherits="AppLocForWeb.Pages.Detalhes1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Compras</title>
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
                    Compras
                </h3>

                

                <br />
                 Bairro: <br />
                <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource5" DataTextField="nomeBairro" DataValueField="codigoBairro" AutoPostBack="True">
                </asp:DropDownList>

                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoBairro], [nomeBairro] FROM [Bairro]"></asp:SqlDataSource>
                <br />
                <br />
                 Tipo de Imovel: <br />
                <asp:DropDownList ID="DropDownList2" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="nomeTipoImovel" DataValueField="codigoTipoImovel" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoTipoImovel], [nomeTipoImovel] FROM [TipoImovel]"></asp:SqlDataSource>
                <br />
                <br />
                 Quantidade de Quartos: <br />

                  <asp:DropDownList ID="DropDownList4" runat="server" 
                  DataSourceID="SqlDataSource3" DataTextField="quantidadeQuarto" DataValueField="codigoQuarto" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoQuarto], [quantidadeQuarto] FROM [Quartos]"></asp:SqlDataSource>

                <br /><br />
                 <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="False" BackColor="#CCFFCC" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="codigoImovel" HeaderText="codigoImovel" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="nomeBairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="nomeTipoImovel" SortExpression="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="negocioNome" SortExpression="negocioNome" />
                        <asp:BoundField DataField="tipoSituacao" HeaderText="tipoSituacao" SortExpression="tipoSituacao" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="quantidadeQuarto" SortExpression="quantidadeQuarto"/>
                        <asp:BoundField DataField="valorImovel" HeaderText="valorImovel" SortExpression="valorImovel" />
                    </Columns>
                    <EmptyDataTemplate>
        Nenhum registro encontrado.
    </EmptyDataTemplate>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" 
                SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Negocio.negocioNome, situacaoImovel.tipoSituacao, Quartos.quantidadeQuarto, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN Negocio ON Negocio.codigoNegocio = Imovel.codigoNegocio INNER JOIN situacaoImovel ON situacaoImovel.codigoSituacao = Imovel.codigoSituacao INNER JOIN Quartos ON Quartos.codigoQuarto = Imovel.codigoQuarto WHERE (Bairro.nomeBairro = @nomeBairro) AND (TipoImovel.nomeTipoImovel = @nomeTipoImovel) AND (Negocio.negocioNome = @nomeNegocio) AND (situacaoImovel.tipoSituacao = @situacaoNegocio) AND (Quartos.quantidadeQuarto = @quantidadeQuarto)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="nomebairro" QueryStringField="nomeBairro" />
                        <asp:QueryStringParameter Name="nomeTipoImovel" QueryStringField="nomeTipoImovel" />
                           <asp:QueryStringParameter Name="nomeNegocio" QueryStringField="nomeNegocio" />
                           <asp:QueryStringParameter Name="situacaoNegocio" QueryStringField="situacaoNegocio" />
                                <asp:QueryStringParameter Name="quantidadeQuarto" QueryStringField="quantidadeQuarto" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Confirmar" CssClass="btn btn-primary"/>
                 <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                

        <br /><br />

        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

     <footer>
            <p>&copy; 2016 - Projeto Faculdade Evolução</p>
        </footer>
              
            </div>
        </div>
    
    </div>
  
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disponivel.aspx.cs" Inherits="AppLocForWeb.Pages.Disponivel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Disponibilidade</title>
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
                    Disponibilidade
                </h3>
                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource1" CssClass="table table-hover table-striped" GridLines="None" BackColor="#ccffcc">
                     <Columns>
                         <asp:BoundField DataField="codigoImovel" HeaderText="Código do Imóvel" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                         <asp:BoundField DataField="nomeBairro" HeaderText="Bairro" SortExpression="nomeBairro" />
                         <asp:BoundField DataField="nomeTipoImovel" HeaderText="Tipo do Imóvel" SortExpression="nomeTipoImovel" />
                         <asp:BoundField DataField="negocioNome" HeaderText="Tipo do Negócio" SortExpression="negocioNome" />
                         <asp:BoundField DataField="quantidadeQuarto" HeaderText="Quantidade de Quarto" SortExpression="quantidadeQuarto" />
                         <asp:BoundField DataField="tipoSituacao" HeaderText="Situação do Imóvel" SortExpression="tipoSituacao" />
                         <asp:BoundField DataField="valorImovel" HeaderText="Valor do Imóvel" SortExpression="valorImovel" />
                     </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT c.codigoImovel, b.nomeBairro, t.nomeTipoImovel, n.negocioNome, q.quantidadeQuarto, s.tipoSituacao, c.valorImovel FROM Imovel AS c INNER JOIN Bairro AS b ON c.codigoBairro = b.codigoBairro INNER JOIN TipoImovel AS t ON c.codigoTipoImovel = t.codigoTipoImovel INNER JOIN Negocio AS n ON c.codigoNegocio = n.codigoNegocio INNER JOIN Quartos AS q ON c.codigoQuarto = q.codigoQuarto INNER JOIN situacaoImovel AS s ON c.codigoSituacao = s.codigoSituacao WHERE (s.tipoSituacao = 'disponivel') ORDER BY c.codigoImovel"></asp:SqlDataSource>
                <br />
                <br />

          <a href="/Default.aspx" class="btn btn-default">Voltar</a>
          <br /><br />
           <footer>
            <p>&copy; 2016 - Projeto Faculdade Evolução</p>
        </footer>
       </div>
        </div>
    </div>
    
    </form>
</body>
</html>

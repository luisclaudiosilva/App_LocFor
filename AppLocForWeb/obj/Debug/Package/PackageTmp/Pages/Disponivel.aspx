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
                     
                <br />
                <br />
               
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="False" BackColor="#CCFFCC">
                    <Columns>
                        <asp:BoundField DataField="codigoImovel" HeaderText="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="negocioNome" SortExpression="negocioNome" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="quantidadeQuarto" />
                        <asp:BoundField DataField="tipoSituacao" HeaderText="tipoSituacao"/>
                        <asp:BoundField DataField="valorImovel" HeaderText="valorImovel" />
                    </Columns>
                </asp:GridView>
                
               
                <br />
                <br />
                <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1">
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                <br />
                
               
                <br />
                <br />

          <a href="/Default.aspx" class="btn btn-default">Voltar</a>
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

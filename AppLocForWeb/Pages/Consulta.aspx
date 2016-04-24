<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="AppLocForWeb.Pages.Consulta1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
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
            <div class="row" style="border-width: 0px;">
                <h3 class="well">
                    Consulta
                </h3>

                 Bairro: <br />
                <asp:DropDownList ID="DropDownList1" runat="server"
                DataSourceID="SqlDataSource3" DataTextField="nomeBairro" 
                DataValueField="codigoBairro" AutoPostBack="True">
                </asp:DropDownList>

                 <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                 ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" 
                 SelectCommand="SELECT [codigoBairro], [nomeBairro] FROM [Bairro]">
                 </asp:SqlDataSource>

                  <br />
                <br />

                Tipo Imovel: <br />
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" 
                DataTextField="nomeTipoImovel" DataValueField="codigoTipoImovel"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoTipoImovel], [nomeTipoImovel] FROM [TipoImovel]"></asp:SqlDataSource>
                <br />
                <br />
                Tipo de Negocio:<br />
                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="negocioNome" DataValueField="codigoNegocio">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoNegocio], [negocioNome] FROM [Negocio]"></asp:SqlDataSource>
                <br />
                <br />
                Situacao do Imovel:<br />
                <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="tipoSituacao" DataValueField="codigoSituacao">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoSituacao], [tipoSituacao] FROM [situacaoImovel]"></asp:SqlDataSource>
                <br />
                <br />
                 Quant. de Quartos:<br />
                <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="quantidadeQuarto" DataValueField="codigoQuarto">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoQuarto], [quantidadeQuarto] FROM [Quartos]"></asp:SqlDataSource>
                <br />
                 <br />
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1"/>
                 <br />

               <%-- <asp:HyperLink ID="hypPagina2" Text="Ir para a página 2" runat="server" NavigateUrl="/Pages/Compras.aspx?Parametro=kkkkkkkk" />--%>



                <br />
               <%-- <asp:Button ID="Button2" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="Button2_Click"/>--%>
                 <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                <br />
                <br />
               <%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="codigoImovel" HeaderText="codigoImovel" SortExpression="codigoImovel" InsertVisible="False" ReadOnly="True" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="nomeBairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="tipoSituacao" HeaderText="tipoSituacao" SortExpression="tipoSituacao" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="nomeTipoImovel" SortExpression="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="negocioNome" SortExpression="negocioNome" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="quantidadeQuarto" SortExpression="quantidadeQuarto" />
                        <asp:BoundField DataField="valorImovel" HeaderText="valorImovel" SortExpression="valorImovel" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, situacaoImovel.tipoSituacao, TipoImovel.nomeTipoImovel, Negocio.negocioNome, Quartos.quantidadeQuarto, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN Negocio ON Imovel.codigoNegocio = Negocio.codigoNegocio INNER JOIN Quartos ON Imovel.codigoQuarto = Quartos.codigoQuarto INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel WHERE (Bairro.nomeBairro = @pBairro) AND (situacaoImovel.tipoSituacao = @pSituacao)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="pBairro" PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="DropDownList2" Name="pSituacao" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" 
                SelectCommand="SELECT * FROM [Imovel]">
                </asp:SqlDataSource>--%>
                <br />

               <%-- %> <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped" 
                GridLines="None" AutoGenerateColumns="false" BackColor="#ccffcc">
                <Columns>
                <asp:BoundField DataField="codigoBairro" HeaderText="Codigo" />
                <asp:BoundField DataField="nomeBairro" HeaderText="Nome" />
               
                </Columns>
                </asp:GridView>--%>

              
             <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
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

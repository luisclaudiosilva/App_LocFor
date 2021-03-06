﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alugar.aspx.cs" Inherits="AppLocForWeb.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
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
                    Alugar
                </h3>

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
                 Tipo de Negocio: <br />

                  <asp:DropDownList ID="DropDownList3" runat="server" 
                  DataSourceID="SqlDataSource2" DataTextField="negocioNome" DataValueField="codigoNegocio" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoNegocio], [negocioNome] FROM [Negocio]"></asp:SqlDataSource>
                <br />
                <br />
                  Quantidade de Quartos: <br />

                  <asp:DropDownList ID="DropDownList4" runat="server" 
                  DataSourceID="SqlDataSource3" DataTextField="quantidadeQuarto" DataValueField="codigoQuarto" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" SelectCommand="SELECT [codigoQuarto], [quantidadeQuarto] FROM [Quartos]"></asp:SqlDataSource>

                <br /><br />
                <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="btn btn-primary"/>
                <br /><br />
              
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

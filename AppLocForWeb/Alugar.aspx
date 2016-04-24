<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Alugar.aspx.cs" Inherits="AppLocForWeb.Alugar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Font-Size="Medium" Width="720px">
        <%--<h1 class="header2"  style="font-weight: bold">Alugar--%>
        
         <div class="header2" >
         <p style="text-align: center; font-size: 26px; width: 496px; font-weight: bold;">Alugue já um imóvel</p>
      
            <a href="Principal.aspx" title="LocFor"><img src="img/Fortaleza-And-Vicinity-77767.jpg" alt="LocFor" border="0" /></a>
            
                
         </div>
     <%-- </h1>--%>
       
        <br />
      
       
        <br />
        <br />
        
        
      
       
        Bairro:
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="radiusInput" DataSourceID="SqlDataSource1" DataTextField="nomeBairro" DataValueField="codigoBairro" Font-Size="Large" Height="35px" Width="95px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [codigoBairro], [nomeBairro] FROM [Bairro]"></asp:SqlDataSource>
                <br />
                <br />
                <br />

                 Tipo de Imovel: <br />
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="radiusInput"
                DataSourceID="SqlDataSource2" DataTextField="nomeTipoImovel" DataValueField="codigoTipoImovel" AutoPostBack="True" Font-Size="Large" Height="33px" Width="95px">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [codigoTipoImovel], [nomeTipoImovel] FROM [TipoImovel]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
                
                  Quantidade de
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; quartos: <br />

                  <asp:DropDownList ID="DropDownList4" runat="server" CssClass="radiusInput"
                  DataSourceID="SqlDataSource3" DataTextField="quantidadeQuarto" 
                  DataValueField="codigoQuarto" AutoPostBack="True" Font-Size="Large" Height="35px" Width="81px">

                      <asp:ListItem></asp:ListItem>

                </asp:DropDownList>

                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [codigoQuarto], [quantidadeQuarto] FROM [Quartos]"></asp:SqlDataSource>

                <br />
                <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                <br /><br />
                <asp:Button ID="Buscar" runat="server" Text="Buscar" CssClass="btnAdd btn" OnClick="Buscar_Click" Height="50px" Width="130px"/>

                <%--<a href="Default.aspx" CssClass="btnAdd btn">Voltar</a>--%>
                <br />
                <br />
               
                <%--<asp:Button ID="Buscar" runat="server" Text="Buscar" CssClass="btnAdd btn" OnClick="Buscar_Click" Height="42px" Width="160px"/>--%>
                <asp:Button ID="Inicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="Inicio_Click" Height="50px" Width="130px"/>
        
    </asp:Panel>

</asp:Content>

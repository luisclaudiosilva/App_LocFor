<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Escolher_Aluguel.aspx.cs" Inherits="AppLocForWeb.Escolher_Aluguel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Font-Size="Large" Width="728px">
        <h1 style="font-weight: bold">Alugar</h1>

                 <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="664px">
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="codigoImovel" HeaderText="Código do Imóvel" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="Bairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="Tipo de Imóvel" SortExpression="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="Tipo de Negócio" SortExpression="negocioNome" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="Quantidade de Quarto" SortExpression="quantidadeQuarto"/>
                        <asp:BoundField DataField="tipoSituacao" HeaderText="Situacao do Imóvel" SortExpression="tipoSituacao" />
                        <asp:BoundField DataField="valorImovel" HeaderText="Valor do Imóvel" SortExpression="valorImovel" />
                    </Columns>
                     <EditRowStyle BackColor="#999999" />
                    <EmptyDataTemplate>
                        Nenhum registro encontrado.
                    </EmptyDataTemplate>
                     <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="#5D7B9D" Font-Size="Small" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#F7F6F3" Font-Size="Small" ForeColor="#333333" />
                     <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#E9E7E2" />
                     <SortedAscendingHeaderStyle BackColor="#506C8C" />
                     <SortedDescendingCellStyle BackColor="#FFFDF8" />
                     <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionString %>" 
                SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Negocio.negocioNome, Quartos.quantidadeQuarto, situacaoImovel.tipoSituacao, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN Negocio ON Negocio.codigoNegocio = Imovel.codigoNegocio INNER JOIN Quartos ON Quartos.codigoQuarto = Imovel.codigoQuarto INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao WHERE (Bairro.nomeBairro = @nomeBairro) AND (TipoImovel.nomeTipoImovel = @nomeTipoImovel) AND (Quartos.quantidadeQuarto = @quantidadeQuarto) AND (situacaoImovel.tipoSituacao = N'Disponivel') AND (Negocio.negocioNome = N'Aluguel')">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="nomebairro" QueryStringField="nomeBairro" />
                        <asp:QueryStringParameter Name="nomeTipoImovel" QueryStringField="nomeTipoImovel" />
                        <asp:QueryStringParameter Name="quantidadeQuarto" QueryStringField="quantidadeQuarto" />
                    </SelectParameters>
                </asp:SqlDataSource>
                 <%--<asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>--%>
         <asp:TextBox ID="txtCodigo" runat="server" Visible="false"></asp:TextBox>
         <br />
         <asp:TextBox ID="txtBairro" runat="server" Visible="false"></asp:TextBox>
          <br />
         <asp:TextBox ID="txtTipoImovel" runat="server" Visible="false"></asp:TextBox>
          <br />
         <asp:TextBox ID="txtTipoNegocio" runat="server" Visible="false"></asp:TextBox>
          <br />
         <asp:TextBox ID="txtQuarto" runat="server" Visible="false"></asp:TextBox>
          <br />
         <asp:TextBox ID="txtValor" runat="server" Visible="false"></asp:TextBox>

       
        
       <%-- <asp:Label ID="Label3" runat="server" Text="Tipo"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Negócio"></asp:Label>
&nbsp;<asp:TextBox ID="txtNegocio" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Quartos"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuarto" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Situação"></asp:Label>
&nbsp;<asp:TextBox ID="txtSituacao" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Valor"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>--%>
        <br />
        <br />
        <p>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
        <br />
        <asp:Button ID="Inicio" runat="server" CssClass="btnAdd btn" OnClick="Inicio_Click" Text="Inicio" />
        &nbsp;
        <asp:Button ID="Voltar" runat="server" CssClass="btnAdd btn" OnClick="Voltar_Click" Text="Voltar" />
        &nbsp;
         <asp:Button ID="btnEscolherAluguel" runat="server" Text="Seguinte" CssClass="btnAdd btn" OnClick="btnEscolherAluguel_Click"/>
          <%--<a href="/Default.aspx" class="btn btn-default">Inicio</a>--%>
         
           
    </asp:Panel>


</asp:Content>

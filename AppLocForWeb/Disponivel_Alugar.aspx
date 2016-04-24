<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Disponivel_Alugar.aspx.cs" Inherits="AppLocForWeb.Disponivel_Alugar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastroD" Visible="true" Font-Size="Large" Width="969px">
        <p style="font-weight: bold; text-align: center; font-size: 26px; width: 715px;">Alugue um imóvel com a LOCFOR!</p>
       
           <br />
       <%-- <div class="header2" style="font-size: 28px; color: #000000;  font-weight: 800; font-family: 'Courier New', Courier, monospace;">--%>
                 <asp:GridView ID="GridView1" CssClass="gridDisponivel" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="907px">
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" SelectText=">" />
                        <asp:BoundField DataField="codigoImovel" HeaderText="Código do Imóvel" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="Bairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="Tipo de Imóvel" SortExpression="nomeTipoImovel" />
                       
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="Quantidade de Quarto" SortExpression="quantidadeQuarto"/>
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
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" 
                SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Quartos.quantidadeQuarto, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN Negocio ON Negocio.codigoNegocio = Imovel.codigoNegocio INNER JOIN Quartos ON Quartos.codigoQuarto = Imovel.codigoQuarto INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao WHERE (situacaoImovel.tipoSituacao = N'Disponivel') AND (Negocio.negocioNome = N'Aluguel')">
                   <%-- <SelectParameters>
                        <asp:QueryStringParameter Name="nomebairro" QueryStringField="nomeBairro" />
                        <asp:QueryStringParameter Name="nomeTipoImovel" QueryStringField="nomeTipoImovel" />
                        <asp:QueryStringParameter Name="quantidadeQuarto" QueryStringField="quantidadeQuarto" />
                    </SelectParameters>--%>
                </asp:SqlDataSource>
               
        <asp:TextBox ID="TextBox1" runat="server" Visible="False">codigo</asp:TextBox>
        <br />
        
        <asp:TextBox ID="TextBox3" runat="server" Visible="False">bairro</asp:TextBox>
        <br />
        <p>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
        <br />
          <%--<a href="/Default.aspx" class="btn btn-default">Inicio</a>--%>
  
        <asp:Button ID="Button1" runat="server" CssClass="btnAdd btn" Text="Seguinte" />
        <%--<a href="/Default.aspx" class="btn btn-default">Inicio</a>--%>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
  <%--  </div>  --%>    
           
    </asp:Panel>

</asp:Content>

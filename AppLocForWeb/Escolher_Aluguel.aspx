<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Escolher_Aluguel.aspx.cs" Inherits="AppLocForWeb.Escolher_Aluguel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <h1 style="font-weight: bold; text-align:center; margin-top:10px;">Sua busca encontrou: <asp:Label ID="lblResultado" runat="server"></asp:Label>Resultados!</h1>

    <asp:Panel runat="server" ID="pnlCadastro" CssClass="panelEscolherAluguel" Visible="true" Font-Size="Large" Width="969px" Height="333px" ScrollBars="Auto">
                 <asp:GridView ID="GridView1" CssClass="gridDisponivel" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="codigoImovel" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="934px">
                     <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="codigoImovel" HeaderText="Código" InsertVisible="False" ReadOnly="True" SortExpression="codigoImovel" />
                        <asp:BoundField DataField="nomeBairro" HeaderText="Bairro" SortExpression="nomeBairro" />
                        <asp:BoundField DataField="nomeTipoImovel" HeaderText="Tipo de Imóvel" SortExpression="nomeTipoImovel" />
                        <asp:BoundField DataField="negocioNome" HeaderText="Tipo de Negócio" SortExpression="negocioNome" />
                        <asp:BoundField DataField="quantidadeQuarto" HeaderText="Quarto" SortExpression="quantidadeQuarto"/>
                        <%--<asp:BoundField DataField="tipoSituacao" HeaderText="Situação" SortExpression="tipoSituacao" />--%>
                        <asp:BoundField DataField="valorImovel" HeaderText="Valor" SortExpression="valorImovel" />
                        <%--<asp:BoundField DataField="foto" HeaderText="Foto" SortExpression="foto" />--%>
                    </Columns>
                     <EditRowStyle BackColor="#999999" />
                    <EmptyDataTemplate>
                        Nenhum registro encontrado.
                    </EmptyDataTemplate>
                     <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="#5D7B9D" Font-Size="Small" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" Width="0px" />
                     <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#F7F6F3" Font-Size="Small" ForeColor="#333333" HorizontalAlign="Center" />
                     <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#E9E7E2" />
                     <SortedAscendingHeaderStyle BackColor="#506C8C" />
                     <SortedDescendingCellStyle BackColor="#FFFDF8" />
                     <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" 
                SelectCommand="SELECT Imovel.codigoImovel, Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Negocio.negocioNome, Quartos.quantidadeQuarto, situacaoImovel.tipoSituacao, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN Negocio ON Negocio.codigoNegocio = Imovel.codigoNegocio INNER JOIN Quartos ON Quartos.codigoQuarto = Imovel.codigoQuarto INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao WHERE (Bairro.nomeBairro = @nomeBairro) AND (TipoImovel.nomeTipoImovel = @nomeTipoImovel) AND (Quartos.quantidadeQuarto = @quantidadeQuarto) AND (Negocio.negocioNome = N'Aluguel')">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="nomebairro" QueryStringField="nomeBairro" />
                        <asp:QueryStringParameter Name="nomeTipoImovel" QueryStringField="nomeTipoImovel" />
                        <asp:QueryStringParameter Name="quantidadeQuarto" QueryStringField="quantidadeQuarto" />
                    </SelectParameters>
                </asp:SqlDataSource>
        
      </asp:Panel> 
    <asp:Panel runat="server" ID="PanelBotoes" Font-Size="Large" Width="723px" Height="50px" CssClass="botoes">  
        
        <asp:Button ID="Inicio" runat="server" CssClass="btnAdd btn" OnClick="Inicio_Click" Text="Inicio" />
        &nbsp;
        <asp:Button ID="btnEscolherAluguel" runat="server" Text="Seguinte" CssClass="btnAdd btn" OnClick="btnEscolherAluguel_Click"/>
     <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
          
    </asp:Panel>     
   
     <asp:TextBox ID="txtCodigo" runat="server" Visible="false"></asp:TextBox>
        
         <asp:TextBox ID="txtBairro" runat="server" Visible="false"></asp:TextBox>
       
         <asp:TextBox ID="txtTipoImovel" runat="server" Visible="false"></asp:TextBox>
         
         <asp:TextBox ID="txtTipoNegocio" runat="server" Visible="false"></asp:TextBox>
      
         <asp:TextBox ID="txtSituacao" runat="server" Visible="false"></asp:TextBox>
         
         <asp:TextBox ID="txtQuarto" runat="server" Visible="false"></asp:TextBox>
         
         <asp:TextBox ID="txtValor" runat="server" Visible="false"></asp:TextBox>


</asp:Content>

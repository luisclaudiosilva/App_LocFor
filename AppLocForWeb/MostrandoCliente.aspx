<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MostrandoCliente.aspx.cs" Inherits="AppLocForWeb.MostrandoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

<asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="95%">
        <h1>Cliente</h1>
    <br />

    <asp:Panel ID="Panel2" CssClass="panelEscolherAluguel" runat="server" Height="310px" Width="100%">
        <br /><br /><br />
        <ul>
            <li>
                <asp:Label  ID="lblNome" Text="Nome Completo" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

             <li>
                <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="tbTelefone" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

            <br />
           
           
             <li>
                <asp:Label ID="lblLogin" runat="server" Text="Nome de Usuario"></asp:Label>
                <asp:TextBox ID="tbLogin" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

              <li>
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="tbSenha" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
   
            <br />

             <li>
                <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="tbCPF" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

             <p>
               <asp:Label ID="lblMensagem" runat="server" ForeColor="#CC3300"></asp:Label><br />
                 <asp:Label ID="lblMensagem2" runat="server" ForeColor="#CC3300"></asp:Label>
                </p>
            </ul>

         <asp:Panel runat="server" ID="panelDetalhes" Width="350px" CssClass="gridDetalhes" ScrollBars="Auto">
                <h1 class="h1Detalhes">Seu(s) de agendamento(s)</h1>
                <asp:GridView ID="GridView1" runat="server"  DataSourceID="SqlDataSource1" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                     <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="dataInicio" HeaderText="Data Inicial" SortExpression="dataInicio" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="dataFim" HeaderText="Data Final" SortExpression="dataFim" DataFormatString="{0:dd/MM/yyyy}" />
                    </Columns>
                    <EmptyDataTemplate>
                        Nenhum registro encontrado.
                    </EmptyDataTemplate>
                </asp:GridView>

                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [dataInicio], [dataFim] FROM [Aluguel] WHERE (([codigoCliente] = @codigoCliente) AND ([dataFim] &gt;= @dataFim)) OR (([codigoCliente] = @codigoCliente) AND ([dataFim] IS NULL)) order by dataInicio asc">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="txtCodigoCliente" Name="codigoCliente" PropertyName="Text" Type="Int32" />
                         <asp:ControlParameter ControlID="txtDataAtual" DbType="Date" Name="dataFim" PropertyName="Text" />
                     </SelectParameters>
                </asp:SqlDataSource>
                    </asp:Panel><br /><br />
         <asp:Panel runat="server" ID="panelExcluir" CssClass="gridExcluir">
        <asp:TextBox ID="txtDataAtual" Visible="false" runat="server"></asp:TextBox>
        <asp:Label ID="lblDataInicial" runat="server" Text="Data Inicial: " Font-Bold="True"></asp:Label>
        <asp:Label ID="lblInicio" runat="server"></asp:Label>
       <%-- <asp:TextBox ID="txtDatInicial" runat="server" Enabled="false" BackColor="White"></asp:TextBox>--%>
        <br />
        <asp:Label ID="lblDataFim" runat="server" Text="Data Final: " Font-Bold="True"></asp:Label>
        <asp:Label ID="lblFim" runat="server"></asp:Label>
        <%--<asp:TextBox ID="txtDatFim" runat="server" Enable="false" BackColor="White"></asp:TextBox>--%>
        <%--<asp:TextBox ID="txtFim" runat="server" Enabled="false"  BackColor="White"></asp:TextBox>--%>
        <br />
        <asp:Button ID="btnExcluir" runat="server" CssClass="btnExcluirData" Text="Excluir" OnClick="btnExcluir_Click" />
             </asp:Panel>
            
            </asp:Panel>
    <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="720px" Height="40px" CssClass="botoes">     
            
            <asp:Button ID="btnInicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="btnInicio_Click"/>
            <asp:Button ID="btnSeguinte" CssClass="btnAdd btn" runat="server" Text="Seguinte" OnClick="btnSeguinte_Click"/>
         
         </asp:Panel>
        
    </asp:Panel>
        
            <asp:TextBox ID="txtCodigoCliente" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtCodigo3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtBairro3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtTipoImovel3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtTipoNegocio3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtQuarto3" runat="server" Visible="False"></asp:TextBox>    
            <asp:TextBox ID="txtValor3" runat="server" Visible="False"></asp:TextBox> 
            <asp:TextBox ID="txtDataIni" runat="server" Visible="False"></asp:TextBox> 
            <asp:TextBox ID="txtDatafim" runat="server" Visible="False"></asp:TextBox> 

</asp:Content>

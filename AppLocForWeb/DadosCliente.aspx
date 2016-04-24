<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DadosCliente.aspx.cs" Inherits="AppLocForWeb.DadosCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
  <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="366px" Width="935px">

            <asp:Panel ID="Panel1" runat="server" Height="235px" Width="250px">
                <h1 style="font-weight: bolder; font-size: 18px">Dados do Cliente</h1>
            <asp:Label ID="Label1" runat="server" Text="Codigo: " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nome: "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Telefone: "></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="CPF: "></asp:Label>
                <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Login: "></asp:Label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Senha: "></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                    
             </asp:Panel> 

            <asp:Panel ID="Panel3" runat="server" Height="245px" Width="238px">
                <h1 style="font-weight: bolder; font-size: 18px">Dados do Imóvel</h1>
                
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                <asp:TextBox ID="txtCodigoImovel" runat="server" Width="120px"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                <asp:TextBox ID="txtBairro" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                <asp:TextBox ID="txtTipo" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                <asp:TextBox ID="txtNegocio" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                <asp:TextBox ID="txtQuarto" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                <asp:TextBox ID="txtValor" runat="server" Width="120px"></asp:TextBox>
            </asp:Panel>
             

              <asp:Panel ID="Panel4" runat="server" Height="90px" Width="238px"  Font-Bold="True" Font-Size="Medium">
                <h1 style="font-weight: bolder; font-size: 18px">Forma de Pagamento</h1>
                  <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="formaPagamento" DataValueField="codigoPagamento" Font-Bold="True" Font-Size="Medium"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [codigoPagamento], [formaPagamento] FROM [Pagamento]"></asp:SqlDataSource>

                 <%--<asp:TextBox ID="txtPagamento" runat="server" Width="120px"></asp:TextBox>--%>
              </asp:Panel>
            
        <asp:Panel ID="Panel2" runat="server">
       <h1 style="font-weight: bolder; font-size: 18px">Data de entrega</h1>
        <br />
        <asp:TextBox ID="txtdataFim" runat="server" Width="120px"></asp:TextBox>
        </asp:Panel>
      
         <%--<asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Confirmar Aluguel" OnClick="btnCadastrar_Click"/>--%>
               <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
         <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click" />
                  <p>
                <asp:Label ID="lblMensagem" runat="server" Font-Size="Larger" Font-Bold="True" ForeColor="Red"></asp:Label>
                </p>
    </asp:Panel>
</asp:Content>

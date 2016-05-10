<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MostrandoDadosAluguel.aspx.cs" Inherits="AppLocForWeb.MostrandoDadosAluguel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
      <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="376px">

         

            <asp:Panel ID="Panel1" runat="server" Height="235px" Width="241px">
                <h1>Dados do Cliente</h1><br />
                
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

            <asp:Panel ID="Panel3" runat="server" Height="235px" Width="238px">
                <h1>Dados do Imóvel</h1><br />
                
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                <asp:TextBox ID="txtCodigo5" runat="server" Width="120px"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                <asp:TextBox ID="txtBairro5" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                <asp:TextBox ID="txtTipoImovel5" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                <asp:TextBox ID="txtTipoNegocio5" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                <asp:TextBox ID="txtQuarto5" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                <asp:TextBox ID="txtValor5" runat="server" Width="120px"></asp:TextBox>
            </asp:Panel>
            

              <asp:Panel ID="Panel4" runat="server" Height="235px" Width="219px">
                <h1>Forma de Pagamento</h1>
                  <asp:TextBox ID="txtPagamento" runat="server"></asp:TextBox>
            </asp:Panel>
            
        <asp:Panel ID="Panel2" runat="server">
            <br />
            <br />
            <br />
            <br />
        <asp:Label ID="lbldata" runat="server" Text="Data de Aluguel" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br />
        <asp:Label ID="lbldataInicio" runat="server" Font-Size="Medium"></asp:Label>
            <asp:TextBox ID="txtDataInicial" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lbldataFim" runat="server" Text="Data de Entrega" Font-Bold="True" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtDataFim" runat="server"></asp:TextBox>
        </asp:Panel>
      
       
<%--         <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Confirmar Aluguel" OnClick="btnCadastrar_Click"/>--%>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnInicio" runat="server" CssClass="btnAdd btn" Text="Inicio" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<%--         <asp:Button ID="btnImprimir" runat="server" CssClass="btnAdd btn" Text="Imprimir" OnClientClick="javascript:imprimePanel()"/>--%>
         <%-- <asp:HyperLink NavigateUrl="FaleConosco.aspx" ID="HyperLink3" runat="server" Font-Size="X-Large" CssClass="hyp" Font-Bold="True">Fale Conosco</asp:HyperLink>
         --%>       
        <br />
                  <p>
                      &nbsp;</p>
            <p>
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Red"></asp:Label>
            </p>

          <script type="text/jscript">
function imprimePanel() {
var printContent = document.getElementById("<%= pnlCadastro.ClientID%>");
       var windowUrl = 'about:blank';
       var uniqueName = new Date();
       var windowName = 'Print' + uniqueName.getTime();
       var printWindow = window.open(windowUrl, windowName, 'left=50000,top=50000,width=0,height=0');

       printWindow.document.write(printContent.innerHTML);
       printWindow.document.close();
       printWindow.focus();
       printWindow.print();
       printWindow.close();
}

</script>

    </asp:Panel>
</asp:Content>

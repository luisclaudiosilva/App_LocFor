<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DadosGerais.aspx.cs" Inherits="AppLocForWeb.DadosGerais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
   
     <asp:Panel runat="server" ID="pnl" Height="362px" Width="951px" >
         <br />
          <h1>Dados do Aluguel</h1>
    <br />
         

         <asp:Panel ID="Panel2" Enabled="false" CssClass="panelEscolherAluguel" runat="server" Height="270px" Width="100%">

            <asp:Panel CssClass="painel" runat="server" Height="238px" Width="256px">
                
                <h1 style="font-style: normal; font-weight: bold; font-size: 18px;">Dados do Cliente</h1><br />
                <asp:Label ID="Label1" runat="server" Text="Codigo: " Font-Bold="True"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigo" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Nome: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNome" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Telefone: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTelefone" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="CPF: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCPF" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Login: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtLogin" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Senha: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSenha" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>     
             </asp:Panel> 

            <asp:Panel CssClass="painel" runat="server" Height="238px" Width="258px">
                
                <h1 style="font-weight: bold; font-size: 18px; font-style: normal;">Dados do Imóvel</h1><br />
                
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigo5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBairro5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtTipoImovel5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTipoNegocio5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtQuarto5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtValor5" runat="server" Width="120px" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
            </asp:Panel>
            

              <asp:Panel CssClass="painel2" runat="server" Height="81px" Width="320px">
                  
                  <br />
                <h1 style="font-size: 18px; font-weight: bold; font-style: normal;">Forma de Pagamento</h1>
                  &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="txtPagamento" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
            </asp:Panel>
            
        <asp:Panel CssClass="painel2" runat="server" Width="320px">
            
        <h1 style="font-size: 17px; font-weight: bold; font-style: normal;">Data de aquisição do imóvel</h1>
        &nbsp;&nbsp;&nbsp;&nbsp;   
        <asp:TextBox ID="txtDataInicial" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
        <br />
        <h1 style="font-size: 17px; font-weight: bold; font-style: normal;">Data de entrega do imóvel</h1>
        &nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="txtDataFim" runat="server" BorderStyle="None" Font-Italic="True" BackColor="White"></asp:TextBox>
        <asp:Button ID="btnMudarData" CssClass="btnMudarData" Visible="false" runat="server" Text="Editar" />
        </asp:Panel>
       
       </asp:Panel>
         
     </asp:Panel>
    <asp:Label ID="lblMensagem2" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Red"></asp:Label>
    <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Red"></asp:Label>
    <asp:Panel runat="server" Height="50px">

         <asp:Button ID="btnReserva" runat="server" CssClass="btnAdd btn" Visible="false" Text="Consultar Reserva" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnGravar" runat="server" CssClass="btnAdd btn" OnClick="btnGravar_Click" Text="Confirmar Aluguel" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnExcluir" Visible="false" runat="server" CssClass="btnAdd btn" Text="Cancelar Contrato" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Voltar" OnClick="btnVoltar_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnInicio" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnInicio_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnImprimir" runat="server" CssClass="btnAdd btn" Text="Imprimir" OnClientClick="javascript:imprimePanel()"/>        
         
         </asp:Panel>
   
  <%--  <asp:Panel ID="pnlPopUp" Style="display:none;" runat="server">
        <div>
        <br /><br /><br /><h2>Novo popup</h2><br /><br /><br />
        </div>
    </asp:Panel>
    <asp:Label ID="lblTeste" runat="server"></asp:Label>

<asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
        BackgroundCssClass="modalBackground"
        CancelControlID="cmdFechar" DropShadow="true"
        PopupControlID="pnlPopUp" PopupDragHandleControlID="panel3"
        TargetControlID="lblTeste">
    </asp:ModalPopupExtender>--%>


    
       <script type="text/jscript">
           function imprimePanel() {
               var printContent = document.getElementById("<%= pnl.ClientID%>");
    var windowUrl = 'about:blank';
    var uniqueName = new Date();
    var windowName = 'Print' + uniqueName.getTime();
    var printWindow = window.open(windowUrl, windowName, 'left=50000,top=50000,width=3000,height=3000');

    printWindow.document.write(printContent.innerHTML);
    printWindow.document.close();
    printWindow.focus();
    printWindow.print();
    printWindow.close();
}

</script>


</asp:Content>


       

    


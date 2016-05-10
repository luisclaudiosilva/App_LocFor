<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormaPagamento.aspx.cs" Inherits="AppLocForWeb.FormaPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

      <asp:Panel ID="pnlCadastro" runat="server" Height="97%" Width="95%">
              
         
             <h1>Forma de Pagamento</h1>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Pagamento: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="false" BackColor="White" Font-Italic="true"></asp:TextBox>
               
            
        <asp:Panel ID="Panel2" CssClass="panelEscolherAluguel" runat="server" Height="293px" Width="100%">
        <br /><br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel5" CssClass="pagescolha" runat="server" Height="200px">
           <div class="divpag">
            <asp:RadioButton ID="RadioButton1" value="avista" runat="server" GroupName="pag" Height="123px" style="background-image: url('../img/avista.png')" Width="216px" OnCheckedChanged="RadioButton_CheckedChanged" AutoPostBack="true"/>
         <br />
               <h1 style="text-align:center" id="boleto">À Vista</h1>
           </div>

          
             <div class="divpag">
         <asp:RadioButton ID="RadioButton2" ValidationGroup="boleto" runat="server" GroupName="pag" Height="123px" style="background-image: url('../img/boleto.png')" Width="216px" OnCheckedChanged="RadioButton_CheckedChanged" AutoPostBack="true" />
            <br /> 
                 <h1 style="text-align:center">Boleto</h1>
                
                  </div>

                  
          <div class="divpag">
          <asp:RadioButton ID="RadioButton3" ValidationGroup="cartao" GroupName="pag" runat="server"  style="background-image:url('../img/cartao.png')" Height="123px" Width="216px" OnCheckedChanged="RadioButton_CheckedChanged" AutoPostBack="true"/>
          <br />
              <h1 style="text-align:center">Cartão</h1>
              </div>
                </asp:Panel>
            <br />
             
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Red"></asp:Label>
            
              
           </asp:Panel>
           </asp:Panel>
               
    <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="720px" Height="42px" CssClass="botoes"> 
            &nbsp;&nbsp;
   
            <asp:Button ID="Button1" runat="server" CssClass="btnAdd btn" Text="Seguinte" OnClick="btnSeguinte_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button2" runat="server" CssClass="btnAdd btn" Text="Voltar"/>

           </asp:Panel> 
  
</asp:Content>

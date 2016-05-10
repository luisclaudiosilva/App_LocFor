<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="AppLocForWeb.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

 <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="450px" Width="983px">
         <p style="font-size: 20px; font-weight: bold">Escolha da data</p>
     <asp:Label ID="lblMensagem1" runat="server" ForeColor="Red" Font-Size="Small"></asp:Label>
     <br />

<asp:Panel runat="server" ID="Panel1" CssClass="panelEscolherAluguel" Visible="true" Height="320px" Width="950px">
  <asp:Panel ID="Panel3" CssClass="data" runat="server" Height="300px" Width="371px">
        <asp:Label ID="Label2" runat="server" Text="Dia do inicio do aluguel: " Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Label id="Selecao2" runat="server"/>
        
        <asp:Calendar id="Calendario2" runat="server"
  ForeColor="black"
  
  Width="218px"
  BorderColor="black"
  BorderStyle="Double"
  ShowGridLines="True"
  DayNameFormat="Full"
  FirstDayOfWeek="Sunday"
  NextMonthText="Próximo"
  PrevMonthText="Anterior"
  SelectionMode="Day"
  SelectMonthText="Mês" 
  OnSelectionChanged="Calendario2_SelectionChanged" Height="109px" />  
    </asp:Panel>

  
           <%-- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
        
     <asp:Panel ID="Panel2" runat="server" Height="300px" Width="443px">
         
         <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Dia do fim do aluguel: "></asp:Label>
         <asp:Label ID="Selecao" runat="server" Width="141px" />
         <asp:Calendar ID="Calendario1" 
         runat="server" 
         BorderColor="black" 
         BorderStyle="Double" 
         DayNameFormat="Full" 
         FirstDayOfWeek="Sunday" 
         ForeColor="black" Height="30px" 
         NextMonthText="Próximo" 
         OnSelectionChanged="Calendario_Change" 
         PrevMonthText="Anterior" SelectionMode="Day" 
         SelectMonthText="Mês" ShowGridLines="True" Width="349px" CssClass="odd" />
   </asp:Panel>
    </asp:Panel>
         <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="912px" Height="50px" CssClass="botoesdata">  
         <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Seguinte" OnClick="btnCadastrar_Click" />
     <%--  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
    <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click" />
     
             </asp:Panel>
</asp:Panel>

<%-- dados do imovel e cliente da outra página --%>
  <asp:TextBox ID="txtCodigo4" runat="server" Width="120px" Visible="false"></asp:TextBox>
   <asp:TextBox ID="txtBairro4" runat="server" Width="120px" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtTipoImovel4" runat="server" Width="120px" Visible="false"></asp:TextBox>
     <asp:TextBox ID="txtTipoNegocio4" runat="server" Width="120px" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtQuarto4" runat="server" Width="120px" Visible="false"></asp:TextBox>
       <asp:TextBox ID="txtValor4" runat="server" Width="120px" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtDataIni" runat="server" Visible="false"></asp:TextBox>
         <asp:TextBox ID="txtDatafim" runat="server" Visible="false"></asp:TextBox>

  <asp:TextBox ID="txtCodigo" runat="server" Width="120px" Visible="false"></asp:TextBox>
   <asp:TextBox ID="txtNome" runat="server" Width="120px" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtTelefone" runat="server" Width="120px" Visible="false"></asp:TextBox>
     <asp:TextBox ID="txtCPF" runat="server" Width="120px" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtLogin" runat="server" Width="120px" Visible="false"></asp:TextBox>
       <asp:TextBox ID="txtSenha" runat="server" Width="120px" Visible="false"></asp:TextBox>


</asp:Content>

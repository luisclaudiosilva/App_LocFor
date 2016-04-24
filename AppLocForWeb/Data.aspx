<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="AppLocForWeb.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

 <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="454px" Width="1001px">
         <p style="font-size: 20px; font-weight: bold">Escolha da data</p><br />

  <asp:Panel ID="Panel3" runat="server" Height="322px" Width="367px">
        <asp:Label ID="Label2" runat="server" Text="Dia do inicio do aluguel: " Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Label id="Selecao2" runat="server"/>
        
        <asp:Calendar id="Calendario2" runat="server"
  ForeColor="black"
  Height="71px"
  Width="349px"
  BorderColor="black"
  BorderStyle="Double"
  ShowGridLines="True"
  DayNameFormat="Full"
  FirstDayOfWeek="Sunday"
  NextMonthText="Próximo"
  PrevMonthText="Anterior"
  SelectionMode="Day"
  SelectMonthText="Mês" 
  OnSelectionChanged="Calendario2_SelectionChanged" />  
    </asp:Panel>

  
              <%--  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
         <%-- <asp:Panel ID="Panel3" runat="server" Height="235px" Width="238px" Visible="false">
                <h1>Dados do Imóvel</h1>
                
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                <asp:TextBox ID="txtCodigo4" runat="server" Width="120px"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                <asp:TextBox ID="txtBairro4" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                <asp:TextBox ID="txtTipoImovel4" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                <asp:TextBox ID="txtTipoNegocio4" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                <asp:TextBox ID="txtQuarto4" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                <asp:TextBox ID="txtValor4" runat="server" Width="120px"></asp:TextBox>
            </asp:Panel>--%>
     <asp:Panel ID="Panel2" runat="server" Height="327px" Width="371px">
         
         <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Dia do fim do aluguel: "></asp:Label>
         <asp:Label ID="Selecao" runat="server" />
         <asp:Calendar ID="Calendario1" 
         runat="server" 
         BorderColor="black" 
         BorderStyle="Double" 
         DayNameFormat="Full" 
         FirstDayOfWeek="Sunday" 
         ForeColor="black" Height="71px" 
         NextMonthText="Próximo" 
         OnSelectionChanged="Calendario_Change" 
         PrevMonthText="Anterior" SelectionMode="Day" 
         SelectMonthText="Mês" ShowGridLines="True" Width="349px" />
   </asp:Panel>

    
         <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Seguinte" OnClick="btnCadastrar_Click" />
     <%--  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
    <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click" />
     <asp:Label ID="lblMensagem1" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
</asp:Panel>

<%-- dados do imovel e cliente da outra página --%>
  <asp:TextBox ID="txtCodigo4" runat="server" Width="120px" Visible="false"></asp:TextBox>
   <asp:TextBox ID="txtBairro4" runat="server" Width="120px" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtTipoImovel4" runat="server" Width="120px" Visible="false"></asp:TextBox>
     <asp:TextBox ID="txtTipoNegocio4" runat="server" Width="120px" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtQuarto4" runat="server" Width="120px" Visible="false"></asp:TextBox>
       <asp:TextBox ID="txtValor4" runat="server" Width="120px" Visible="false"></asp:TextBox>

  <asp:TextBox ID="txtCodigo" runat="server" Width="120px" Visible="false"></asp:TextBox>
   <asp:TextBox ID="txtNome" runat="server" Width="120px" Visible="false"></asp:TextBox>
    <asp:TextBox ID="txtTelefone" runat="server" Width="120px" Visible="false"></asp:TextBox>
     <asp:TextBox ID="txtCPF" runat="server" Width="120px" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtLogin" runat="server" Width="120px" Visible="false"></asp:TextBox>
       <asp:TextBox ID="txtSenha" runat="server" Width="120px" Visible="false"></asp:TextBox>


</asp:Content>

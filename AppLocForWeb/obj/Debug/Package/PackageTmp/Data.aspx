<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="AppLocForWeb.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

 <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="454px">

  <asp:Panel ID="Panel1" runat="server" Height="235px" Width="225px" Visible="false">
                <h1>Dados do Cliente</h1>
            <asp:Label ID="Label2" runat="server" Text="Codigo: " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Nome: "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Telefone: "></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="CPF: "></asp:Label>
                <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Login: "></asp:Label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Senha: "></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                    
             </asp:Panel>

             <asp:Panel ID="Panel3" runat="server" Height="235px" Width="238px" Visible="false">
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
            </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" Height="361px">
        <asp:Label ID="Label13" runat="server" Text="Data de Aluguel: " Font-Bold="True" Font-Size="Larger"></asp:Label>
       
        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Dia do fim do aluguel: " Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Label id="Selecao" runat="server"/>
        
        <asp:Calendar id="Calendario1" runat="server"
  ForeColor="black"
  Height="300px"
  Width="665px"
  BorderColor="black"
  BorderStyle="Double"
  ShowGridLines="True"
  DayNameFormat="Full"
  FirstDayOfWeek="Sunday"
  NextMonthText="Próximo"
  PrevMonthText="Anterior"
  SelectionMode="Day"
  SelectMonthText="Mês"
  OnSelectionChanged="Calendario_Change"/>   
    </asp:Panel>

    <asp:Label ID="lblMensagem1" runat="server"></asp:Label>

         <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Seguinte" OnClick="btnCadastrar_Click" />
              <%--  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
         <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click" />
    </asp:Panel>

</asp:Content>

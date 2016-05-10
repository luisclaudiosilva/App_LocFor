<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MostrandoCliente2.aspx.cs" Inherits="AppLocForWeb.MostrandoCliente2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    
<asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="95%">
        <h1>Cadastro de Clientes</h1>
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

              <li>
                <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="tbCPF" CssClass="radiusInput" runat="server"></asp:TextBox>
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
             </ul>
               
             <p>
                <asp:Label ID="lblMensagem" runat="server" ForeColor="#CC3300"></asp:Label>
                </p>
         </asp:Panel>
    <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="720px" Height="40px" CssClass="botoes">     
             
           
            <asp:Button ID="btnInicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="btnInicio_Click"/>
           
            <asp:Button ID="btnSeguinte" CssClass="btnAdd btn" runat="server" Text="Confirmar" OnClick="btnSeguinte_Click"/>

            <asp:Button ID="btnAlugar" CssClass="btnAdd btn" runat="server" Visible="false" Text="Alugar" OnClick="btnAlugar_Click"/>
         </asp:Panel>
    </asp:Panel>
     <asp:TextBox ID="txtCodigoCliente" runat="server" Visible="False"></asp:TextBox>

</asp:Content>

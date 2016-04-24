<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="AppLocForWeb.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

 <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <h1>Cadastro de Clientes</h1>
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
            </li><br />
           
           
             <li>
                <asp:Label ID="lblLogin" runat="server" Text="Nome de Usuario"></asp:Label>
                <asp:TextBox ID="tbLogin" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

              <li>
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="tbSenha" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
   
             <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                
            <li>
            <asp:Button ID="btnInicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="btnInicio_Click"/>
            </li>

            <li> 
                <asp:Button ID="btnCadastrar" CssClass="btnAdd btn" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click"/>
            </li>

        </ul>
    </asp:Panel>

</asp:Content>

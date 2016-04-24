<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppLocForWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 163px;
            height: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

<asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="306px">
        <h1>Login</h1>

 

        <ul>
            <li>
                <asp:Label  ID="lbllogin" Text="Usuário" runat="server"></asp:Label>
                <asp:TextBox ID="tbLogin" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
                
            </li>
            <br />
            <li>
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="tbSenha" runat="server" CssClass="radiusInput"></asp:TextBox>
            </li>
          <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>

            
                 <br />
                 <br />
            <li>
            <asp:Button ID="btnInicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="btnInicio_Click"/>
            </li>

            <li> 
                <asp:Button ID="btnEntrar" CssClass="btnAdd btn" runat="server" Text="Buscar" OnClick="btnEntrar_Click"/>
            </li>

        </ul>

         
    </asp:Panel>

</asp:Content>

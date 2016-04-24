<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cliente_Alugar.aspx.cs" Inherits="AppLocForWeb.Cliente_Alugar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

<asp:Panel runat="server" ID="pnlCadastro" Visible="True" Height="386px" Width="713px">
        <h1 style="font-weight: bold">Clientes</h1>
        
        <asp:Panel ID="Panel2" runat="server" Height="301px" Width="264px" BorderStyle="None" BackColor="#FEF8F1">

            <asp:Label ID="Label1" runat="server" Text="Entrar" Font-Italic="True" Font-Size="Large"></asp:Label>
            <ul>    
             <li>
                <asp:Label ID="lblLogin" runat="server" Text="Nome de Usuario"></asp:Label>
                <asp:TextBox ID="tbLogin" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
              <br />
              <li>
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="tbSenha" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

             <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                
            
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btnAdd btn2" Height="46px" Width="102px" OnClick="btnConfirmar_Click" />
            <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn2" Height="46px" Text="Voltar" Width="102px" OnClick="btnVoltar_Click"/>
                
                <br>
            </br>

            </ul>
        </asp:Panel>
      
        <asp:Panel ID="Panel1" runat="server" Height="301px" Width="264px" BackColor="#FEF8F1" Visible="True">

            <asp:Label ID="Label2" runat="server" Text="Cadastrar novo cliente" Font-Italic="True" Font-Size="Large"></asp:Label>
            <br />
            <br />
            <br />
            <br>
            <br>
            <br></br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn2" Height="46px" Text="Cadastrar" Width="196px" OnClick="btnCadastrar_Click"/>
            <%--<a href="Cliente2.aspx" style="color: #000000; text-decoration: none; font-size: 20px; text-align: center;" title="Entrar">Ir para página de cadastro</a>--%>
            <br>
            <br></br>
            <br></br>
            </br>
            </br>
            </br>
        </asp:Panel>
    
      <asp:TextBox ID="txtCodigo2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtBairro2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtTipoImovel2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtTipoNegocio2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtQuarto2" runat="server" Visible="False"></asp:TextBox>    
      <asp:TextBox ID="txtValor2" runat="server" Visible="False"></asp:TextBox>  
      
      <asp:TextBox ID="txtClienteCodigo" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteNome" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteTelefone" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteCPF" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteLogin" runat="server" Visible="false"></asp:TextBox>    
      <asp:TextBox ID="txtClienteSenha" runat="server" Visible="false"></asp:TextBox>  
           
    </asp:Panel>

</asp:Content>

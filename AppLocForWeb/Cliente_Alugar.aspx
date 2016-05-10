<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cliente_Alugar.aspx.cs" Inherits="AppLocForWeb.Cliente_Alugar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    
<asp:Panel runat="server" ID="pnlCadastro" Visible="True" Height="450px" Width="95%">
        <h1 style="font-weight: bold">Cliente</h1>
    <br />
        
        <asp:Panel ID="Panel2" CssClass="panelEscolherAluguel" runat="server" Height="320px" Width="100%">

          <asp:Panel runat="server" ID="Panel1" Visible="true" Font-Size="Large" Width="921px" Height="200px" CssClass="login"> 
                <asp:Label ID="lblLogin" runat="server" Text="Usuário"></asp:Label>

                <br />
                <asp:TextBox ID="tbLogin" runat="server" CssClass="radiusInput" Height="31px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <br />
                <asp:TextBox ID="tbSenha" runat="server" CssClass="radiusInput" Height="31px" Width="215px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnConfirmar" runat="server" CssClass="btnAdd btn2" Height="46px" OnClick="btnConfirmar_Click" Text="Entrar" Width="102px" />
                &nbsp;

                <p>
                <asp:Label ID="lblMensagem" ForeColor="Red" runat="server"></asp:Label>
                </p>

          </asp:Panel>
           <img src="img/login.png" alt="login" border="0" style="height: 215px; width: 230px; top: -251px; left: -57px;" class="loginfoto"/>
        </asp:Panel>
    

     <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="720px" Height="40px" CssClass="botoes"> 
           
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           
            
            <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn2" Height="46px" Text="Voltar" Width="102px" OnClick="btnVoltar_Click"/>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn2" Height="46px" Text="Cadastrar Novo" Width="196px" OnClick="btnCadastrar_Click"/>   
                
            <br />

            
      
        </asp:Panel>
           
        </asp:Panel>
    
      <asp:TextBox ID="txtCodigo2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtBairro2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtTipoImovel2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtTipoNegocio2" runat="server" Visible="False"></asp:TextBox>
      <asp:TextBox ID="txtQuarto2" runat="server" Visible="False"></asp:TextBox>    
      <asp:TextBox ID="txtValor2" runat="server" Visible="False"></asp:TextBox>  
      <asp:TextBox ID="txtDataIni" runat="server" Visible="False"></asp:TextBox>  
      <asp:TextBox ID="txtDatafim" runat="server" Visible="False"></asp:TextBox>  
      
      <asp:TextBox ID="txtClienteCodigo" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteNome" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteTelefone" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteCPF" runat="server" Visible="false"></asp:TextBox>
      <asp:TextBox ID="txtClienteLogin" runat="server" Visible="false"></asp:TextBox>    
      <asp:TextBox ID="txtClienteSenha" runat="server" Visible="false"></asp:TextBox>  
           
   

</asp:Content>

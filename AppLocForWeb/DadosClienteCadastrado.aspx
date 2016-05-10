<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DadosClienteCadastrado.aspx.cs" Inherits="AppLocForWeb.DadosClienteCadastrado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    
<asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="426px" Width="715px">
          <asp:Panel ID="Panel3" runat="server" Height="406px" Width="658px">
                <h1>Dados do Cliente</h1>

                 <br />
                <br />
        
                <asp:Label  ID="lblNome" Text="Nome Completo" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" runat="server"  Width="120px"></asp:TextBox>
             

              <br />
                <br />
                 <br />
                
        
                <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="tbTelefone" runat="server"></asp:TextBox>

              <br />
                <br />
                 <br />
           
                <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
                <asp:TextBox ID="tbCPF" runat="server"></asp:TextBox>
          <br />
                <br />
                 <br />
           
           
             
                <asp:Label ID="lblLogin" runat="server" Text="Nome de Usuario"></asp:Label>
                <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>

             <br />
                <br />
                 <br />
         
                <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="tbSenha" runat="server"></asp:TextBox>
           
   
        <br />
                <br />
                 <br />
                
           
            <asp:Button ID="btnInicio" runat="server" Text="Inicio" CssClass="btnAdd btn" OnClick="btnInicio_Click"/>
          
                <asp:Button ID="btnSeguinte" CssClass="btnAdd btn" runat="server" Text="Seguinte" OnClick="btnSeguinte_Click"/>
           

             <p>
                <asp:Label ID="lblMensagem" runat="server" ForeColor="#CC3300"></asp:Label>
                </p>
 </asp:Panel>
      
    </asp:Panel>
        
            <asp:TextBox ID="txtCodigoCliente" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtCodigo3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtBairro3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtTipoImovel3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtTipoNegocio3" runat="server" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtQuarto3" runat="server" Visible="False"></asp:TextBox>    
            <asp:TextBox ID="txtValor3" runat="server" Visible="False"></asp:TextBox> 

</asp:Content>

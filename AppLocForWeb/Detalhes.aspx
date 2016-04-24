<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="AppLocForWeb.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

 <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="426px" Width="715px">

            <asp:Panel ID="Panel3" runat="server" Height="406px" Width="658px">
                <h1>Dados do Imóvel</h1>
                
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                <asp:TextBox ID="txtCodigo" runat="server" Width="120px"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                <asp:TextBox ID="txtBairro" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                <asp:TextBox ID="txtTipoImovel" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                <asp:TextBox ID="txtTipoNegocio" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />  
                 <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Situação: "></asp:Label>
                <asp:TextBox ID="txtSituacao" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                <asp:TextBox ID="txtQuarto" runat="server" Width="120px"></asp:TextBox>
                 <br />
                <br />
                 <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                <asp:TextBox ID="txtValor" runat="server" Width="120px"></asp:TextBox>
                    <br />
                <br />
                 <asp:Label ID="lbldataFim" runat="server" Font-Bold="True" Text="Data de entrega: "></asp:Label>
                <asp:TextBox ID="txtdataFim" runat="server" Width="120px"></asp:TextBox>
          
             <br />
      <br />
            
      <%--  <asp:Panel ID="Panel2" runat="server">
            <br />
            <br />
            <br />
            <br />
        <asp:Label ID="Label14" runat="server" Text="Data de Aluguel" Font-Bold="True" Font-Size="Medium"></asp:Label>
            <br />
        <asp:Label ID="dataInicio" runat="server"></asp:Label>
       
        <asp:Label ID="Label15" runat="server" Text="Data de Entrega" Font-Bold="True" Font-Size="Medium"></asp:Label><br />
        <asp:Label ID="dataFim" runat="server"></asp:Label>
        </asp:Panel>--%>
            <br />
      <br />
                <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" Text="Seguinte" OnClick="btnCadastrar_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnResevar" runat="server" CssClass="btnAdd btn" Text="Agendar" Visible="false" OnClick="btnResevar_Click" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" />
           <br />
                <br />
                  <p>
                <asp:Label ID="lblMensagem" runat="server" Font-Size="Larger" Font-Bold="True" ForeColor="Red"></asp:Label>
                </p>
                  </asp:Panel>
    </asp:Panel>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="AppLocForWeb.Empresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="400px" Width="618px">
        <h1>Quem Somos</h1>
     <%--   <asp:Panel ID="Panel1" runat="server" Height="300px" Width="800px" BackColor="#99ccff">
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
             <asp:TextBox ID="txtNomeArquivo" runat="server"></asp:TextBox>
          <br />

            <asp:Label ID="Label2" runat="server" Text="Arquivo"></asp:Label>
            <asp:FileUpload ID="fupld" runat="server" />
            <br />

            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <br />
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
            <br />
            <asp:HyperLink ID="hplnkExibeImagem" runat="server">Clique aqui para Exibir a Imagem</asp:HyperLink>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Somente arquivo .gif e .jpg."></asp:Label>
        </asp:Panel>--%>
    </asp:Panel>
</asp:Content>

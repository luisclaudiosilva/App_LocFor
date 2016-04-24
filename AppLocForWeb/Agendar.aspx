<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Agendar.aspx.cs" Inherits="AppLocForWeb.Agendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
      <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Width="961px" BackColor="White" Height="381px">
       
       
     
        <div >
                
                    <img class="inicio" alt="Inicio" src="img/Pagina-em-construcao.png" style="height: 305px; width: 928px"/>
                
                    <br />
                    &nbsp;<asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click" />
      </div>


    
    </asp:Panel>

</asp:Content>

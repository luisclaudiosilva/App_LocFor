<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppLocForWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LocFor</title>
    <link type ="text/css" rel="stylesheet" href="Content/bootstrap.css" />
   
</head>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1 style="font-size: 40px;">LocFor - Aluguel de Imóveis</h1>
        
    </div>

    <div class="container">
       
    <div class="span10 offset1" style="font-size: x-large">

    
     Selecione a opção desejada:
        
   
            
       
        <asp:DropDownList ID="ddlMenu" runat="server">
            <asp:ListItem Value="0" Text="- Escolha uma Opção - " />
            <asp:ListItem Value="1" Text="Alugar" />
            <asp:ListItem Value="2" Text="Vender" />
            <asp:ListItem Value="3" Text="Comprar" />
            <asp:ListItem Value="4" Text="Disponiveis" />
            
        </asp:DropDownList>

       

        <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnAcessar"/>

        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>
        
       
         </div>
         <br /><br /><br /><br /><br /><br />
           <footer>
            <p style="bottom: 26px">&copy; 2016 - Projeto Faculdade Evolução</p>
        </footer>
        </div>
        
    </form>
</body>
</html>

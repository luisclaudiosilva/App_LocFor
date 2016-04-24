<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="AppLocForWeb.Pages.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cliente</title>
    <link type ="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    
</head>
    <script src="Scripts/Mascara.js"></script>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
     <div class="jumbotron">
        <h1 style="font-size: 40px;">LocFor - Aluguel de Imóveis</h1>
    </div>
     <div class="container">
        <div class="span10 offset1">
            <div class="row" style="border-width: 0px;">
                <h3 class="well">
                    Cadastro de Cliente
                </h3>

                Nome:<br />
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br /><br />
                Telefone:<br />
                <asp:TextBox ID="txtTelefone" runat="server"
                ></asp:TextBox>
                <br /><br />
                CPF:<br />
                <asp:TextBox ID="txtCPF" runat="server"
                ></asp:TextBox>

                
                <br /><br />

                <a href="/Default.aspx" class="btn btn-default">Voltar</a>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
                <br /><br />
              
                <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                <br /><br />
                <footer>
                    <p>&copy; 2016 - Projeto Faculdade Evolução</p>
                </footer> 
    </div>
    </div>
    </div>
    </form>
</body>
</html>

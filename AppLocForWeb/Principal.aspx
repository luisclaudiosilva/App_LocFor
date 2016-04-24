<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="AppLocForWeb.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Width="961px" BackColor="White" Height="381px">
       
     <%--  
     
        <div >
                
                    <img class="inicio" alt="Inicio" src="img/principal.jpg" style="height: 376px; width: 928px"/>
                
         
      </div>--%>

        	<div id="games">
		
			<%--<a href="http://www.minininjas.com/" target="_blank">
				<img src="img/principal.jpg" alt="Mini Ninjas" />
				<span>
					<b>Mini Ninjas</b><br />
					Your quest to defeat the Evil Samurai Warlord has begun. Control the powers of nature, possess creatures, use your
					furious Ninja skills to free your Ninja friends.
				</span>
			</a>--%>
			
			<a href="#" target="_blank" style="text-align: center">
				<img src="img/como-alugar-um-imovel.jpg" alt="Price of Persia" />
                <span>
					<b>Titulo</b><br />
                   Texto aqui
				</span>
			</a>
			
			<a href="#" target="_blank">
				<img src="img/compar-ou-alugar-imovel2222.jpg" alt="Spiderman: Shattered Dimensions" />
                <span>
					<b>Titulo</b><br />
                    Texto aqui
				</span>
			</a>
			
			<a href="#" target="_blank">
				<img src="img/Fortaleza-289-anos.jpg" alt="Brink" />
                <span>
					<b>Titulo</b><br />
                    Texto aqui
				</span>
			</a>
		
			<a href="#" target="_blank" >
				<img src="img/principal.jpg" alt="God of War III" />
                <span>
					<b>Titulo</b><br />
                    Texto aqui
				</span>
			</a>
			
			<a href="#" target="_blank">
				<img src="img/small-apartment-design-by-suto-interior-architects2.jpg" alt="Borderlands" />
				<span>
					<b>Titulo</b><br />
                    Texto aqui
				</span>
			</a>
			
			
			
		</div>
		<script>
			$('#games').coinslider();
		</script>

  
    
    </asp:Panel>

</asp:Content>

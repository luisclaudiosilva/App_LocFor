<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="AppLocForWeb.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">

    <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
 <asp:Panel runat="server" ID="pnlCadastro" Visible="true" Height="450px" Width="983px">

     <h1 style="font-size: 18px; text-align:center; font-weight: bold">Dados do Imóvel</h1>
     <br />
            <asp:Panel ID="Panel3" CssClass="panelEscolherAluguel" runat="server" Height="300px" Width="970px">
               
                
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Código: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCodigo" runat="server" Width="120px" Font-Italic="True" Enabled="false" BackColor="White"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Bairro: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBairro" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Tipo de Imóvel: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTipoImovel" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Negócio: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtTipoNegocio" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Situação: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSituacao" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Quartos: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtQuarto" runat="server" BackColor="White" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Valor: "></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtValor" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txtDataAtual" runat="server" Visible="false"></asp:TextBox>
                <asp:Label ID="lbldataFim" runat="server" Font-Bold="True" Text="Data de entrega: "></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="txtdataFim" runat="server" BackColor="White" Enabled="false" Font-Italic="True" Width="120px"></asp:TextBox>

                <asp:Panel runat="server" ID="panelDetalhes" CssClass="gridDetalhes" ScrollBars="Auto">
                <h1 class="h1Detalhes">Data(s) de agendamento</h1>
                <asp:GridView ID="GridView1" runat="server"  DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                     <Columns>
                        <asp:BoundField DataField="dataInicio" HeaderText="Data Inicial" SortExpression="dataInicio" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="dataFim" HeaderText="Data Final" SortExpression="dataFim" DataFormatString="{0:dd/MM/yyyy}" />
                    </Columns>
                    <EmptyDataTemplate>
                        Nenhum registro encontrado.
                    </EmptyDataTemplate>
                </asp:GridView>

                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Projeto_LocacaoConnectionStringAcer %>" SelectCommand="SELECT [dataInicio], [dataFim] FROM [Aluguel] WHERE (([codigoImovel] = @codigoImovel) AND ([dataFim] &gt;= @dataFim)) OR (([codigoImovel] = @codigoImovel) AND ([dataFim] IS NULL)) order by dataInicio asc">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="txtCodigo" Name="codigoImovel" PropertyName="Text" Type="Int32" />
                         <asp:ControlParameter ControlID="txtDataAtual" DbType="Date" Name="dataFim" PropertyName="Text" />
                     </SelectParameters>
                </asp:SqlDataSource>
                    </asp:Panel><br />
                 <br />
                <br />
                 <asp:Label ID="lblMensagem2" runat="server" ForeColor="Red" ></asp:Label>  
                 </asp:Panel>
               
      <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>  
              
             <asp:Panel runat="server" ID="PanelBotoes" Visible="true" Font-Size="Large" Width="720px" Height="40px" CssClass="botoes">  
                  
                <asp:Button ID="btnCadastrar" runat="server" CssClass="btnAdd btn" OnClick="btnCadastrar_Click" Text="Seguinte" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnResevar" runat="server" CssClass="btnAdd btn" OnClick="btnResevar_Click" Text="Agendar" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVoltar" runat="server" CssClass="btnAdd btn" Text="Inicio" OnClick="btnVoltar_Click"/>
 
               
               
                  </asp:Panel>
    </asp:Panel>
     <asp:TextBox ID="txtDataIni" runat="server" Visible="false"></asp:TextBox>
</asp:Content>

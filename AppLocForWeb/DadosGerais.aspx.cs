using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppLocForWeb
{
    public partial class DadosGerais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Request.QueryString["codigoCliente"];
            txtNome.Text = Request.QueryString["nomeCliente"];
            txtTelefone.Text = Request.QueryString["telefoneCliente"];
            txtCPF.Text = Request.QueryString["cpfCliente"];
            txtLogin.Text = Request.QueryString["loginCliente"];
            txtSenha.Text = Request.QueryString["senhaCliente"];

            txtCodigo5.Text = Request.QueryString["codigoImovel"];
            txtBairro5.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel5.Text = Request.QueryString["tipo"];
            txtTipoNegocio5.Text = Request.QueryString["negocio"];
            txtQuarto5.Text = Request.QueryString["quarto"];
            txtValor5.Text = Request.QueryString["valor"];

            txtPagamento.Text = Request.QueryString["pagamento"];

            txtDataInicial.Text = Request.QueryString["dataInicio"];
            txtDataFim.Text = Request.QueryString["dataFim"];

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Tudo ok!";
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
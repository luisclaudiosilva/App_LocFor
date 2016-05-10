using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace AppLocForWeb
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            txtCodigo.Text = Request.QueryString["codigoImovel"];
            txtBairro.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel.Text = Request.QueryString["tipo"];
            txtTipoNegocio.Text = Request.QueryString["negocio"];
            txtSituacao.Text = Request.QueryString["situacao"];
            txtQuarto.Text = Request.QueryString["quarto"];
            txtValor.Text = Request.QueryString["valor"];

            DateTime dataAtual = DateTime.Now.Date;

            txtDataAtual.Text = Convert.ToString(dataAtual);

            lbldataFim.Visible = false;
            txtdataFim.Visible = false;
            btnCadastrar.Visible = false;

                int codigo = Convert.ToInt32(txtCodigo.Text);
                DateTime di = DateTime.Now.Date;
                
           
                AluguelDAL dal = new AluguelDAL();
                Alugados lu = dal.PesquisarCodImovelDataFim(codigo);

                if (lu == null)
                {
                    //lblMensagem.Text = "imovel nao existe em aluguel";
                    txtSituacao.Text = "Disponivel";
                }
                else
                {
                    lblMensagem.Text = "* Imóvel sem Data de entrega definida!";
                    btnCadastrar.Visible = false;
                    btnResevar.Visible = false;
                    txtSituacao.Text = "Indisponivel";
                }
                      
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Cliente_Alugar.aspx");

            if (txtCodigo.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string bairro = txtBairro.Text;
                string tipo = txtTipoImovel.Text;
                string negocio = txtTipoNegocio.Text;
                string situacao = txtSituacao.Text;
                int quarto = Convert.ToInt32(txtQuarto.Text);
                float valor = Convert.ToUInt32(txtValor.Text);
                string url = null;

                if (codigo == 0)
                {
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    url = "Cliente_Alugar.aspx?codigoImovel=" + codigo + "&nomeBairro=" + bairro + "&tipo=" + tipo + "&negocio=" + negocio + "&situacao=" + situacao + "&quarto=" + quarto + "&valor=" + valor;

                }
                Response.Redirect(url);
            }
            else
            {
                lblMensagem.Text = "Escolha uma opção! ";
            }
        }

        protected void btnResevar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Agendar.aspx");

            if (txtCodigo.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string bairro = txtBairro.Text;
                string tipo = txtTipoImovel.Text;
                string negocio = txtTipoNegocio.Text;
                string situacao = txtSituacao.Text;
                int quarto = Convert.ToInt32(txtQuarto.Text);
                float valor = Convert.ToUInt32(txtValor.Text);
                string dataini = txtDataIni.Text;
                string datafim = txtdataFim.Text;
                string url = null;

                if (codigo == 0)
                {
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    url = "Cliente_Alugar.aspx?codigoImovel=" + codigo + "&nomeBairro=" + bairro + "&tipo=" + tipo + "&negocio=" + negocio + "&situacao=" + situacao + "&quarto=" + quarto + "&valor=" + valor + "&dataIni=" + dataini + "&datafim=" + datafim;

                }
                Response.Redirect(url);
            }
            else
            {
                lblMensagem.Text = "Escolha uma opção! ";
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
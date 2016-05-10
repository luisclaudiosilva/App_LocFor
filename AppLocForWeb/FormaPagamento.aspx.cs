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
    public partial class FormaPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtCodigo.Text = Request.QueryString["codigoCliente"];
            //txtNome.Text = Request.QueryString["nomeCliente"];
            //txtTelefone.Text = Request.QueryString["telefoneCliente"];
            //txtCPF.Text = Request.QueryString["cpfCliente"];
            //txtLogin.Text = Request.QueryString["loginCliente"];
            //txtSenha.Text = Request.QueryString["senhaCliente"];

            //txtCodigo5.Text = Request.QueryString["codigoImovel"];
            //txtBairro5.Text = Request.QueryString["nomeBairro"];
            //txtTipoImovel5.Text = Request.QueryString["tipo"];
            //txtTipoNegocio5.Text = Request.QueryString["negocio"];
            //txtQuarto5.Text = Request.QueryString["quarto"];
            //txtValor5.Text = Request.QueryString["valor"];

            //dataInicio.Text = Request.QueryString["dataInicio"];
            //dataFim.Text = Request.QueryString["dataFim"];
          

        }

        protected void btnSeguinte_Click(object sender, EventArgs e)
        {

            int codigoCliente = Convert.ToInt32(Request.QueryString["codigoCliente"]);
            string nome = Request.QueryString["nomeCliente"];
            int telefone = Convert.ToInt32(Request.QueryString["telefoneCliente"]);
            int cpf = Convert.ToInt32(Request.QueryString["cpfCliente"]);
            string login = Request.QueryString["loginCliente"];
            string senha = Request.QueryString["senhaCliente"];

            int codigoImovel = Convert.ToInt32(Request.QueryString["codigoImovel"]);
            string bairro = Request.QueryString["nomeBairro"];
            string tipo = Request.QueryString["tipo"];
            string negocio = Request.QueryString["negocio"];
            int quarto = Convert.ToInt32(Request.QueryString["quarto"]);
            float valor = Convert.ToUInt32(Request.QueryString["valor"]);

            string dataIni = Request.QueryString["dataInicio"];
            string dataFim = Request.QueryString["dataFim"];

            string pag = TextBox1.Text;

            if (pag == "")
            {
                lblMensagem.Text = "Por favor " + nome + " escolha uma forma de pagamento!";
            }
            else
            {
                switch (pag)
                {
                    case "À vista":
                        pag = "1";
                        break;
                    
                    case "Boleto":
                        pag = "2";
                        break;

                    case "Cartão":
                        pag = "3";
                        break;
                }

                try
                {

                    string url = null;

                    url = "DadosGerais.aspx?codigoImovel=" + codigoImovel + "&nomeBairro=" + bairro + "&tipo=" + tipo + "&negocio=" + negocio + "&quarto=" + quarto + "&valor=" + valor + "&dataInicio=" + dataIni + "&dataFim=" + dataFim + "&codigoCliente=" + codigoCliente + "&nomeCliente=" + nome + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha + "&pagamento=" + pag;

                    Response.Redirect(url);
                }
                catch (Exception)
                {

                    lblMensagem.Text = "Erro na url";
                }
            }
        
        }

        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                TextBox1.Text = "À vista";
            }
            if (RadioButton2.Checked == true)
            {
                TextBox1.Text = "Boleto";
            }
            if (RadioButton3.Checked == true)
            {
                TextBox1.Text = "Cartão";
            }
           
        }

  

       

      

       

       

       

       
    }
}
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
    public partial class DadosClienteCadastrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo3.Text = Request.QueryString["codigoImovel"];
            txtBairro3.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel3.Text = Request.QueryString["tipo"];
            txtTipoNegocio3.Text = Request.QueryString["negocio"];
            txtQuarto3.Text = Request.QueryString["quarto"];
            txtValor3.Text = Request.QueryString["valor"];

            txtCodigoCliente.Text = Request.QueryString["codigoCliente"];
            tbNome.Text = Request.QueryString["nomeCliente"];
            tbTelefone.Text = Request.QueryString["telefoneCliente"];
            tbCPF.Text = Request.QueryString["cpfCliente"];
            tbLogin.Text = Request.QueryString["loginCliente"];
            tbSenha.Text = Request.QueryString["senhaCliente"];

            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            tbCPF.Enabled = false;
            tbLogin.Enabled = false;
            tbSenha.Enabled = false;

            int codigo = Convert.ToInt32(txtCodigoCliente.Text);

            AluguelDAL aludal = new AluguelDAL();
            Alugados alugado = aludal.PesquisarCodigoCliente(codigo);

            try
            {

                int codigoaluguel = alugado.codigoAluguel;


                lblMensagem.Text = "Cliente " + tbNome.Text + " já possui um imóvel alugado!";
                btnSeguinte.Visible = false;
            }
            catch (Exception)
            {


            }

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

        protected void btnSeguinte_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCodigoCliente.Text != "")
                {
                    int codigo3 = Convert.ToInt32(txtCodigo3.Text);
                    string bairro3 = txtBairro3.Text;
                    string tipo3 = txtTipoImovel3.Text;
                    string negocio3 = txtTipoNegocio3.Text;
                    int quarto3 = Convert.ToInt32(txtQuarto3.Text);
                    float valor3 = Convert.ToUInt32(txtValor3.Text);


                    int codigo = Convert.ToInt32(txtCodigoCliente.Text);
                    string nomeCliente = tbNome.Text;
                    int telefone = Convert.ToInt32(tbTelefone.Text);
                    int cpf = Convert.ToInt32(tbCPF.Text);
                    string login = tbLogin.Text;
                    string senha = tbSenha.Text;
                    string url = null;

                    if (codigo == 0)
                    {
                        Response.Redirect("Principal.aspx");
                    }
                    else
                    {
                        url = "Data.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                    }
                    Response.Redirect(url);
                }
                else
                {
                    lblMensagem.Text = "Escolha uma opção! ";
                }

            }
            catch (Exception)
            {

                lblMensagem.Text = "Preencha o(s) campo(s)! ";
            }
        }

       
    }


}
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
    public partial class MostrandoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo3.Text = Request.QueryString["codigoImovel"];
            txtBairro3.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel3.Text = Request.QueryString["tipo"];
            txtTipoNegocio3.Text = Request.QueryString["negocio"];
            txtQuarto3.Text = Request.QueryString["quarto"];
            txtValor3.Text = Request.QueryString["valor"];
            txtDataIni.Text = Request.QueryString["dataIni"];
            txtDatafim.Text = Request.QueryString["datafim"];

            txtCodigoCliente.Text = Request.QueryString["codigoCliente"];
            tbNome.Text = Request.QueryString["nomeCliente"];
            tbTelefone.Text = Request.QueryString["telefoneCliente"];
            tbCPF.Text = Request.QueryString["cpfCliente"];
            tbLogin.Text = Request.QueryString["loginCliente"];
            tbSenha.Text = Request.QueryString["senhaCliente"];



            DateTime dataAtual = DateTime.Now.Date;
            txtDataAtual.Text = Convert.ToString(dataAtual);

            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            tbCPF.Enabled = false;
            tbLogin.Enabled = false;
            tbSenha.Enabled = false;

                
                    int codigo = Convert.ToInt32(txtCodigoCliente.Text);

                    AluguelDAL aludal = new AluguelDAL();
                    Alugados alugado = aludal.PesquisarCodigoClienteData(codigo);

                    if (alugado != null)
                    {
                        lblMensagem2.Text = "Você tem um aluguel sem uma data de entrega definida!  Não pode fazer uma reserva! ";

                        btnSeguinte.Visible = false;
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
                    string dataini = txtDataIni.Text;
                    string datafim = txtDatafim.Text;


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
                        url = "Data.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataIni=" + dataini + "&datafim=" + datafim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblInicio.Text = GridView1.SelectedRow.Cells[1].Text;
            lblFim.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {


            try
            {
                Alugados alu = new Alugados();
             
                alu.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
                alu.dataInicio = Convert.ToDateTime(lblInicio.Text);

                AluguelDAL aludal = new AluguelDAL();

                aludal.Excluir(alu); //excluindo aluguel

                lblInicio.Text = "";
                lblFim.Text = "";


                lblMensagem2.Text = "Excluido com sucesso!";
            }
            catch (Exception)
            {

                lblMensagem.Text = "Erro ao excluir!";
            }
                
        


        }
    }
}
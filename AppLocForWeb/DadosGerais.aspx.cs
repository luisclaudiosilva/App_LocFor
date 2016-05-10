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
    public partial class DadosGerais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

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

            txtDataInicial.Text = Request.QueryString["dataInicio"];
            txtDataFim.Text = Request.QueryString["dataFim"];

            string pagamento = Request.QueryString["pagamento"];
            switch (pagamento)
            {
                case "1":
                    pagamento = "À vista";
                    break;

                case "2":
                    pagamento = "Boleto";
                    break;

                case "3":
                    pagamento = "Cartão";
                    break;
            }

            txtPagamento.Text = pagamento;

            int codCli = Convert.ToInt32(txtCodigo.Text);
            DateTime dataAtual = DateTime.Now.Date;
          
          
        }


        protected void btnGravar_Click(object sender, EventArgs e)
        {

            //int codicli = Convert.ToInt32(txtCodigo.Text);
            
            try
            {
                if (txtDataFim.Text == "")
                {
                   

                    Alugados alu = new Alugados();
                    alu.codigoImovel = Convert.ToInt32(txtCodigo5.Text);
                    alu.codigoCliente = Convert.ToInt32(txtCodigo.Text);
                    alu.dataInicio = Convert.ToDateTime(txtDataInicial.Text);
                    
                    alu.pagamento = Convert.ToInt32(Request.QueryString["pagamento"]);

                    AluguelDAL aludal = new AluguelDAL();

                    aludal.Gravar2(alu); //gravando aluguel

                    int codigo5 = Convert.ToInt32(txtCodigo5.Text);
                    //Imovel2 i = new Imovel2();

                    ImovelDAL imovdal = new ImovelDAL();
                    imovdal.Atualizar(codigo5);//aqui é passado o id do imovel para mudar a situação do imovel para alugado.


                    btnVoltar.Visible = false;
                    btnGravar.Visible = false;
                    btnImprimir.Visible = true;
                    

                    lblMensagem.Text = "Aluguel registrado com sucesso!";
                }
                else
                {
                    Alugados alu = new Alugados();
                    alu.codigoImovel = Convert.ToInt32(txtCodigo5.Text);
                    alu.codigoCliente = Convert.ToInt32(txtCodigo.Text);
                    alu.dataInicio = Convert.ToDateTime(txtDataInicial.Text);
                    alu.dataFim = Convert.ToDateTime(txtDataFim.Text);
                    alu.pagamento = Convert.ToInt32(Request.QueryString["pagamento"]);

                    AluguelDAL aludal = new AluguelDAL();

                    aludal.Gravar(alu); //gravando aluguel

                    int codigo5 = Convert.ToInt32(txtCodigo5.Text);
                    //Imovel2 i = new Imovel2();

                    ImovelDAL imovdal = new ImovelDAL();
                    imovdal.Atualizar(codigo5);//aqui é passado o id do imovel para mudar a situação do imovel para alugado.


                    btnVoltar.Visible = false;
                    btnGravar.Visible = false;
                    btnImprimir.Visible = true;

                    lblMensagem.Text = "Aluguel registrado com sucesso!";
                }


            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;

            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "voltar";
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

       
    }
}
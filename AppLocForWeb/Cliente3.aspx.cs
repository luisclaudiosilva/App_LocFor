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
    public partial class Cliente3 : System.Web.UI.Page
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

            dataInicio.Text = Request.QueryString["dataInicio"];
            dataFim.Text = Request.QueryString["dataFim"];

         

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

             string pagamento = DropDownList1.SelectedValue.ToString();

            if (pagamento == "Selecione:")
            {
                lblMensagem.Text = txtNome.Text + " não escolheu forma de pagamento!";
            }
            else
            {

                try
                {
                    Alugados alu = new Alugados();
                    alu.codigoImovel = Convert.ToInt32(txtCodigo5.Text);
                    alu.codigoCliente = Convert.ToInt32(txtCodigo.Text);
                    alu.dataInicio = Convert.ToDateTime(dataInicio.Text);
                    alu.dataFim = Convert.ToDateTime(dataFim.Text);
                    alu.pagamento = Convert.ToInt32(DropDownList1.SelectedValue);

                    AluguelDAL aludal = new AluguelDAL();

                    aludal.Gravar(alu); //gravando aluguel

                    int codigo5 = Convert.ToInt32(txtCodigo5.Text);
                    //Imovel2 i = new Imovel2();

                    ImovelDAL imovdal = new ImovelDAL();
                    imovdal.Atualizar(codigo5);

                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    txtCPF.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";

                    txtCodigo5.Text = "";
                    txtBairro5.Text = "";
                    txtTipoImovel5.Text = "";
                    txtTipoNegocio5.Text = "";
                    txtQuarto5.Text = "";
                    txtValor5.Text = "";

                    dataInicio.Text = "";
                    dataFim.Text = "";

                    pagamento = "Selecione:";
                    DropDownList1.Enabled = false;

                    btnCadastrar.Enabled = false;

                    lblMensagem.Text = "Aluguel registrado com sucesso!";


                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;

                }
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
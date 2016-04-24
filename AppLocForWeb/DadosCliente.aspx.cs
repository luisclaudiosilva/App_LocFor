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
    public partial class DadosCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Request.QueryString["codigoCliente"];
            txtNome.Text = Request.QueryString["nomeCliente"];
            txtTelefone.Text = Request.QueryString["telefoneCliente"];
            txtCPF.Text = Request.QueryString["cpfCliente"];
            txtLogin.Text = Request.QueryString["loginCliente"];
            txtSenha.Text = Request.QueryString["senhaCliente"];

            //txtCodigo5.Text = Request.QueryString["codigoImovel"];
            //txtBairro5.Text = Request.QueryString["nomeBairro"];
            //txtTipoImovel5.Text = Request.QueryString["tipo"];
            //txtTipoNegocio5.Text = Request.QueryString["negocio"];
            //txtQuarto5.Text = Request.QueryString["quarto"];
            //txtValor5.Text = Request.QueryString["valor"];

            //dataInicio.Text = Request.QueryString["dataInicio"];
            //dataFim.Text = Request.QueryString["dataFim"];
            

            //pegando dados da tabela aluguel atraves do codigo
            int codigo = Convert.ToInt32(txtCodigo.Text);
           AluguelDAL d = new AluguelDAL();
           Alugados c = d.PesquisarCodigoCliente(codigo);

            if (c != null)
            {
                txtCodigoImovel.Text = Convert.ToString(c.codigoImovel);
                txtdataFim.Text = c.dataFimAluguel;
                DropDownList1.SelectedValue = Convert.ToString(c.pagamento);
                DropDownList1.Enabled = false;  
            }


            //pegando valor da tabela imovel atraves do codigo
            int codigoImovel = Convert.ToInt32(c.codigoImovel);
            ImovelDAL aludal = new ImovelDAL();
            Imovel alu = aludal.PesquisarCodigoImovel(codigoImovel);

            if (alu != null)
            {
               txtBairro.Text = Convert.ToString(alu.nomeBairro);
               txtNegocio.Text = Convert.ToString(alu.negocioNome);
               txtTipo.Text = Convert.ToString(alu.nomeTipoImovel);
               txtQuarto.Text = Convert.ToString(alu.quantidadeQuarto);
               txtValor.Text = Convert.ToString(alu.valorImovel);
            }


        }

        //protected void btnCadastrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Alugados alu = new Alugados();
        //        alu.codigoImovel = Convert.ToInt32(txtCodigo5.Text);
        //        alu.codigoCliente = Convert.ToInt32(txtCodigo.Text);
        //        alu.dataInicioAluguel = dataInicio.Text;
        //        alu.dataFimAluguel = dataFim.Text;
        //        alu.pagamento = Convert.ToInt32(DropDownList1.SelectedValue);

        //        AluguelDAL aludal = new AluguelDAL();

        //        aludal.Gravar(alu); //gravando aluguel

        //        int codigo5 = Convert.ToInt32(txtCodigo5.Text);
        //        //Imovel2 i = new Imovel2();

        //        ImovelDAL imovdal = new ImovelDAL();
        //        imovdal.Atualizar(codigo5);

        //        txtCodigo.Text = "";
        //        txtNome.Text = "";
        //        txtTelefone.Text = "";
        //        txtCPF.Text = "";
        //        txtLogin.Text = "";
        //        txtSenha.Text = "";

        //        txtCodigo5.Text = "";
        //        txtBairro5.Text = "";
        //        txtTipoImovel5.Text = "";
        //        txtTipoNegocio5.Text = "";
        //        txtQuarto5.Text = "";
        //        txtValor5.Text = "";

        //        dataInicio.Text = "";
        //        dataFim.Text = "";

        //        btnCadastrar.Enabled = false;

        //        lblMensagem.Text = "Aluguel registrado com sucesso!";


        //    }
        //    catch (Exception ex)
        //    {

        //        lblMensagem.Text = ex.Message;

        //    }
        //}

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
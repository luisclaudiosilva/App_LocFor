using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace AppLocForWeb.Pages
{
    public partial class Detalhes1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // pnlDados.Visible = false;
            //ImovelDAL imov = new ImovelDAL();
            //string valor = Request.QueryString["nomeBairro"];

            //GridView1.DataSource = imov.PesquisarPorBairro(valor); //popular o grid
            //GridView1.DataBind(); //exibir o conteudo do grid

            //if (valor != null)
            //{
            //    lblValorQueryString.Text = "Bairro: " + valor;
            //}

            //foreach (String item in Request.QueryString.Keys)
            //{
            //    lblValorQueryString.Text += "Chave= " + item + " --> " + Request.QueryString[item] + "<br>";
            //}
            



        }

        //protected void gdvImoveis_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        /* protected void btnExcluir_Click1(object sender, EventArgs e)
         {
             try
             {
                 int Id = Convert.ToInt32(txtCodigo.Text);
                 Pessoa p = new Pessoa();
                 PessoaDAL d = new PessoaDAL();

                 d.Excluir(Id);

                 lblMensagem.Text = "Cliente exluido com sucesso!";

                 txtCodigo.Text = string.Empty;
                 txtNome.Text = string.Empty;
                 txtEndereco.Text = string.Empty;
                 txtEmail.Text = string.Empty;
             }
             catch (Exception ex)
             {

                 lblMensagem.Text = ex.Message;
             }
         }

         protected void btnAtualizar_Click1(object sender, EventArgs e)
         {
             try
             {
                 Pessoa p = new Pessoa();

                 p.Id = Convert.ToInt32(txtCodigo.Text);
                 p.Nome = Convert.ToString(txtNome.Text);
                 p.Endereco = Convert.ToString(txtEndereco.Text);
                 p.Email = Convert.ToString(txtEmail.Text);

                 PessoaDAL d = new PessoaDAL();
                 d.Atualizar(p);
                 lblMensagem.Text = "Cliente alutalizado com sucesso!";

                 txtCodigo.Text = string.Empty;
                 txtNome.Text = string.Empty;
                 txtEndereco.Text = string.Empty;
                 txtEmail.Text = string.Empty;
             }
             catch (Exception ex)
             {
                 lblMensagem.Text = ex.Message;

             }
         }

         protected void Pesquisar_Click(object sender, EventArgs e)
         {
             try
             {
                 int Id = Convert.ToInt32(txtCodigo.Text);

                 PessoaDAL d = new PessoaDAL();
                 Pessoa p = d.PesquisarPorCodigo(Id);

                 if (p != null)
                 {
                     //pnlDados.Visible = true;

                     txtNome.Text = p.Nome;
                     txtEndereco.Text = p.Endereco;
                     txtEmail.Text = p.Email;
                 }
                 else
                 {
                     txtNome.Text = string.Empty;
                     txtEndereco.Text = string.Empty;
                     txtEmail.Text = string.Empty;
                     lblMensagem.Text = "Cliente não encontrado!";

                 }
             }
             catch (Exception ex)
             {

                 lblMensagem.Text = ex.Message;
             }
         }*/
    }
}
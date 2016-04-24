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
    public partial class GravandoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo3.Text = Request.QueryString["codigoImovel"];
            txtBairro3.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel3.Text = Request.QueryString["tipo"];
            txtTipoNegocio3.Text = Request.QueryString["negocio"];
            txtQuarto3.Text = Request.QueryString["quarto"];
            txtValor3.Text = Request.QueryString["valor"];

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = tbNome.Text;
            string telefonecli = tbTelefone.Text;
            string cpfcli = tbCPF.Text;
            string logincli = tbLogin.Text;
            string senhacli = tbSenha.Text;


            if (nome == "" || telefonecli == "" || cpfcli == "" || logincli == "" || senhacli == "" )
            {
                lblMensagem.Text = "Campo vazio!";
            }
            else
            {

            try
            {
                int cpfCliente = Convert.ToInt32(tbCPF.Text);

                ClienteDAL d = new ClienteDAL();
                CadastroCliente c = d.PesquisarCPF(cpfCliente);
                string nomecli = c.nomeCliente;
            
              
                lblMensagem.Text = "Cliente " + nomecli + " já existe em nossos cadastros!";
            }
              catch(Exception)
            {

                    if (txtCodigo3.Text != "")
                    {
                        int codigo3 = Convert.ToInt32(txtCodigo3.Text);
                        string bairro3 = txtBairro3.Text;
                        string tipo3 = txtTipoImovel3.Text;
                        string negocio3 = txtTipoNegocio3.Text;
                        int quarto3 = Convert.ToInt32(txtQuarto3.Text);
                        float valor3 = Convert.ToUInt32(txtValor3.Text);

                        CadastroCliente cli = new CadastroCliente();
                        cli.nomeCliente = tbNome.Text;
                        cli.telefoneCliente = Convert.ToInt32(tbTelefone.Text);
                        cli.cpfCliente = Convert.ToInt32(tbCPF.Text);
                        cli.loginCliente = tbLogin.Text;
                        cli.senhaCliente = tbSenha.Text;
                        ClienteDAL d = new ClienteDAL();
                        d.Gravar(cli); //gravando o cliente

                        int cpfCliente = Convert.ToInt32(tbCPF.Text);
                        ClienteDAL clidal = new ClienteDAL();
                        CadastroCliente c = clidal.PesquisarCPF(cpfCliente);
                        int codigoCliente = c.codigoCliente;

                        int codigo = Convert.ToInt32(codigoCliente);
                        string nomeCliente = tbNome.Text;
                        int telefone = Convert.ToInt32(tbTelefone.Text);
                        int cpf = Convert.ToInt32(tbCPF.Text);
                        string login = tbLogin.Text;
                        string senha = tbSenha.Text;
                        string url = null;

                        url = "Data.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                        Response.Redirect(url);
                    }
                    else
                    {
                        lblMensagem.Text = "Código do imóvel não informado! ";
                    }



            }
                


            }


            //try
            //{

            //    if (txtCodigoCliente.Text != "")
            //    {
            //        int codigo3 = Convert.ToInt32(txtCodigo3.Text);
            //        string bairro3 = txtBairro3.Text;
            //        string tipo3 = txtTipoImovel3.Text;
            //        string negocio3 = txtTipoNegocio3.Text;
            //        int quarto3 = Convert.ToInt32(txtQuarto3.Text);
            //        float valor3 = Convert.ToUInt32(txtValor3.Text);


            //        int codigo = Convert.ToInt32(txtCodigoCliente.Text);
            //        string nomeCliente = tbNome.Text;
            //        int telefone = Convert.ToInt32(tbTelefone.Text);
            //        int cpf = Convert.ToInt32(tbCPF.Text);
            //        string login = tbLogin.Text;
            //        string senha = tbSenha.Text;
            //        string url = null;

            //        if (codigo == 0)
            //        {
            //            Response.Redirect("Principal.aspx");
            //        }
            //        else
            //        {
            //            url = "Data.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

            //        }
            //        Response.Redirect(url);
            //    }
            //    else
            //    {
            //        lblMensagem.Text = "Escolha uma opção! ";
            //    }

            //}
            //catch (Exception)
            //{

            //    lblMensagem.Text = "Preencha o(s) campo(s)! ";

                

            //}




        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
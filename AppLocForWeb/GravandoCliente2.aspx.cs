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
    public partial class GravandoCliente2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string telefonecli = tbTelefone.Text;
            string cpfcli = tbCPF.Text;
            string logincli = tbLogin.Text;
            string senhacli = tbSenha.Text;

            if (nome == "" || telefonecli == "" || cpfcli == "" || logincli == "" || senhacli == "")
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
                catch (Exception)
                {
                    CadastroCliente cli = new CadastroCliente();
                    cli.nomeCliente = tbNome.Text;
                    cli.telefoneCliente = Convert.ToInt32(tbTelefone.Text);
                    cli.cpfCliente = Convert.ToInt32(tbCPF.Text);
                    cli.loginCliente = tbLogin.Text;
                    cli.senhaCliente = tbSenha.Text;
                    ClienteDAL d = new ClienteDAL();
                    d.Gravar(cli); //gravando o cliente

                    tbNome.Text = null;
                    tbTelefone.Text = null;
                    tbCPF.Text = null;
                    tbLogin.Text = null;
                    tbSenha.Text = null;

                    tbNome.Enabled = true;
                    tbTelefone.Enabled = true;
                    tbCPF.Enabled = true;
                    tbLogin.Enabled = true;
                    tbSenha.Enabled = true;

                    btnCadastrar.Enabled = true;

                    lblMensagem.Text = "Cliente " + cli.nomeCliente + " cadastrado com sucesso!";

                    //int cpfCliente = Convert.ToInt32(tbCPF.Text);
                    //ClienteDAL clidal = new ClienteDAL();
                    //CadastroCliente c = clidal.PesquisarCPF(cpfCliente);
                    //int codigoCliente = c.codigoCliente;

                    //int codigo = Convert.ToInt32(codigoCliente);
                    //string nomeCliente = tbNome.Text;
                    //int telefone = Convert.ToInt32(tbTelefone.Text);
                    //int cpf = Convert.ToInt32(tbCPF.Text);
                    //string login = tbLogin.Text;
                    //string senha = tbSenha.Text;
                    
                  
                }
            }
        }
    }
}
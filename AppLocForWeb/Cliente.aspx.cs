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
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("GravandoCliente2.aspx");
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
             string login = tbLogin.Text;
             string senha = tbSenha.Text;

            if(login == "" || senha == "")
            {
                lblMensagem.Text = "Campos vazios!";
            }
            else 
            { 
                ClienteDAL d = new ClienteDAL();
                CadastroCliente c = d.PesquisarPorlogin(login, senha);

                if(c == null)
                {
                    lblMensagem.Text = "Cliente não encontrado!";
                    tbLogin.Text = "";
                    tbSenha.Text = "";
                }
                else
                {
                    int codigoCliente = c.codigoCliente;
                    string nomeCliente = c.nomeCliente;
                    int telefoneCliente = c.telefoneCliente;
                    int cpfCliente = c.cpfCliente;
                    string loginCliente = c.loginCliente;
                    string senhaCliente = c.senhaCliente;

                    string url = null;
                    url = "MostrandoCliente2.aspx?codigoCliente=" + codigoCliente + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefoneCliente + "&cpfCliente=" + cpfCliente + "&loginCliente=" + loginCliente + "&senhaCliente=" + senhaCliente;
                    Response.Redirect(url);
                }
         }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
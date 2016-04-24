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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void btnEntrar_Click(object sender, EventArgs e)
        {


            try
            {
               
                string login = tbLogin.Text;
                string senha = tbSenha.Text;

                ClienteDAL d = new ClienteDAL();
                CadastroCliente c = d.PesquisarPorlogin(login, senha);
               
                if(c != null)
                {
                   
                    lblMensagem.Text = "Bem vindo(a): "+ login;
                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado!";
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;


            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }
    }
}
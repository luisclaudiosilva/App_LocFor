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
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroCliente cli = new CadastroCliente();
                cli.nomeCliente = txtNome.Text;
                cli.telefoneCliente = Convert.ToInt32(txtTelefone.Text);
                cli.cpfCliente = Convert.ToInt32(txtCPF.Text);

                ClienteDAL d = new ClienteDAL();
                d.Gravar(cli); //gravando a pessoa

                lblMensagem.Text = "Cliente " + cli.nomeCliente + " cadastrado com sucesso!";

                txtNome.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtCPF.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }
    }
    }

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
    public partial class Cliente_Alugar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            txtCodigo2.Text = Request.QueryString["codigoImovel"];
            txtBairro2.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel2.Text = Request.QueryString["tipo"];
            txtTipoNegocio2.Text = Request.QueryString["negocio"];
            txtQuarto2.Text = Request.QueryString["quarto"];
            txtValor2.Text = Request.QueryString["valor"];
            txtDataIni.Text = Request.QueryString["dataIni"];
            txtDatafim.Text = Request.QueryString["datafim"];
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Alugar.aspx");
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Cliente2.aspx");

            if (txtCodigo2.Text != "")
            {

                int codigo2 = Convert.ToInt32(txtCodigo2.Text);
                string bairro2 = txtBairro2.Text;
                string tipo2 = txtTipoImovel2.Text;
                string negocio2 = txtTipoNegocio2.Text;
                int quarto2 = Convert.ToInt32(txtQuarto2.Text);
                float valor2 = Convert.ToUInt32(txtValor2.Text);
                string url = null;

                if (codigo2 == 0)
                {
                    Response.Redirect("Principal.aspx");
                }
                else
                {
                    url = "GravandoCliente.aspx?codigoImovel=" + codigo2 + "&nomeBairro=" + bairro2 + "&tipo=" + tipo2 + "&negocio=" + negocio2 + "&quarto=" + quarto2 + "&valor=" + valor2;

                }
                Response.Redirect(url);
            }
            else
            {
                lblMensagem.Text = "Escolha uma opção! ";
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                string login = tbLogin.Text;
                string senha = tbSenha.Text;

                ClienteDAL d = new ClienteDAL();
                CadastroCliente c = d.PesquisarPorlogin(login, senha);

                if (c != null)
                {

                    txtClienteCodigo.Text = Convert.ToString(c.codigoCliente);
                    txtClienteNome.Text = c.nomeCliente;
                    txtClienteTelefone.Text = Convert.ToString(c.telefoneCliente);
                    txtClienteCPF.Text = Convert.ToString(c.cpfCliente);
                    txtClienteLogin.Text = c.loginCliente;
                    txtClienteSenha.Text = c.senhaCliente;

                    //Response.Redirect("Cliente2.aspx");

                    if (txtCodigo2.Text != "")
                    {

                        int codigoCliente = Convert.ToInt32(txtClienteCodigo.Text);
                        string nomeCliente = txtClienteNome.Text;
                        int telefoneCliente = Convert.ToInt32(txtClienteTelefone.Text);
                        int cpfCliente = Convert.ToInt32(txtClienteCPF.Text);
                        string loginCliente = txtClienteLogin.Text;
                        string senhaCliente = txtClienteSenha.Text;

                        int codigo2 = Convert.ToInt32(txtCodigo2.Text);
                        string bairro2 = txtBairro2.Text;
                        string tipo2 = txtTipoImovel2.Text;
                        string negocio2 = txtTipoNegocio2.Text;
                        int quarto2 = Convert.ToInt32(txtQuarto2.Text);
                        float valor2 = Convert.ToUInt32(txtValor2.Text);
                        string dataini = txtDataIni.Text;
                        string datafim = txtDatafim.Text;
                        string url = null;
                       

                        if (codigo2 == 0)
                        {
                            Response.Redirect("Principal.aspx");
                        }
                        else
                        {
                            url = "MostrandoCliente.aspx?codigoCliente=" + codigoCliente + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefoneCliente + "&cpfCliente=" + cpfCliente + "&loginCliente=" + loginCliente + "&senhaCliente=" + senhaCliente + "&codigoImovel=" + codigo2 + "&nomeBairro=" + bairro2 + "&tipo=" + tipo2 + "&negocio=" + negocio2 + "&quarto=" + quarto2 + "&valor=" + valor2 + "&dataIni=" + dataini + "&datafim=" +datafim;

                        }
                        Response.Redirect(url);
                    }
                    else
                    {
                        int codigoCliente = Convert.ToInt32(txtClienteCodigo.Text);
                        string nomeCliente = txtClienteNome.Text;
                        int telefoneCliente = Convert.ToInt32(txtClienteTelefone.Text);
                        int cpfCliente = Convert.ToInt32(txtClienteCPF.Text);
                        string loginCliente = txtClienteLogin.Text;
                        string senhaCliente = txtClienteSenha.Text;
                        string url2 = null;
                        //lblMensagem.Text = "Escolha uma opção! ";
                        url2 = "DadosCliente.aspx?codigoCliente=" + codigoCliente + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefoneCliente + "&cpfCliente=" + cpfCliente + "&loginCliente=" + loginCliente + "&senhaCliente=" + senhaCliente;
                        Response.Redirect(url2);
                    }
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

       
    }
}
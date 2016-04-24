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
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Request.QueryString["codigoCliente"];
            txtNome.Text = Request.QueryString["nomeCliente"];
            txtTelefone.Text = Request.QueryString["telefoneCliente"];
            txtCPF.Text = Request.QueryString["cpfCliente"];
            txtLogin.Text = Request.QueryString["loginCliente"];
            txtSenha.Text = Request.QueryString["senhaCliente"];

            txtCodigo4.Text = Request.QueryString["codigoImovel"];
            txtBairro4.Text = Request.QueryString["nomeBairro"];
            txtTipoImovel4.Text = Request.QueryString["tipo"];
            txtTipoNegocio4.Text = Request.QueryString["negocio"];
            txtQuarto4.Text = Request.QueryString["quarto"];
            txtValor4.Text = Request.QueryString["valor"];

            
        }

        public void Calendario_Change(object sender, EventArgs e)
        {
            System.DateTime dia = default(System.DateTime);
            Selecao.Text = "";
            foreach (System.DateTime dia_loopVariable in Calendario1.SelectedDates)
            {
                dia = dia_loopVariable;
                Selecao.Text = Selecao.Text + dia;
            }
        }


        protected void Calendario2_SelectionChanged(object sender, EventArgs e)
        {
            System.DateTime dia = default(System.DateTime);
            Selecao2.Text = "";
            foreach (System.DateTime dia_loopVariable in Calendario2.SelectedDates)
            {
                dia = dia_loopVariable;
                Selecao2.Text = Selecao2.Text + dia;
                
            }
            if (Selecao2.Text == "")
            {
                lblMensagem1.Text = "Atenção! campo vazio! ";
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string dataini = Selecao2.Text;
            string datafim = Selecao.Text;

            if(dataini == "")
            {
                lblMensagem1.Text = "Escolha ao menos a data Inicial";
            }
            else 
            { 
        
            DateTime data = DateTime.Now.Date;//gera data atual
            DateTime data2 = Convert.ToDateTime(Selecao2.Text);//dataInicial
           

            if (data > data2) //data atual maior que data inicial
            {
                //comandos
                lblMensagem1.Text = "Data Incial não é válida!";
                Selecao2.Text = null;
                

            }//fecha o if
            else
            {
                if(Selecao.Text != "")//campo data final não for vazio
                {
                    DateTime data3 = Convert.ToDateTime(Selecao.Text);//dataFinal

                    if (data2 > data3)//data inicial maior q data final
                    {
                        lblMensagem1.Text = "Data Final invalida!";
                        Selecao.Text = null;
                    }
                    else
                    {
                        try
                        {

                            if (txtCodigo4.Text != "")
                            {
                                int codigo3 = Convert.ToInt32(txtCodigo4.Text);
                                string bairro3 = txtBairro4.Text;
                                string tipo3 = txtTipoImovel4.Text;
                                string negocio3 = txtTipoNegocio4.Text;
                                int quarto3 = Convert.ToInt32(txtQuarto4.Text);
                                float valor3 = Convert.ToUInt32(txtValor4.Text);

                                string dataInicio = Selecao2.Text;
                                string dataFim = Selecao.Text;


                                int codigo = Convert.ToInt32(txtCodigo.Text);
                                string nomeCliente = txtNome.Text;
                                int telefone = Convert.ToInt32(txtTelefone.Text);
                                int cpf = Convert.ToInt32(txtCPF.Text);
                                string login = txtLogin.Text;
                                string senha = txtSenha.Text;
                                string url = null;

                                if (codigo3 == 0)
                                {
                                    Response.Redirect("Principal.aspx");
                                }
                                else
                                {
                                    url = "Cliente3.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                                }
                                Response.Redirect(url);
                            }
                            else
                            {
                                lblMensagem1.Text = "Escolha uma opção! ";
                            }
                        }//fecha o try
                        catch (Exception ex)
                        {

                            lblMensagem1.Text = ex.Message;

                        }//fecha o catch
                    }
                }
                else
                {
                    try
                    {

                        if (txtCodigo4.Text != "")
                        {
                            int codigo3 = Convert.ToInt32(txtCodigo4.Text);
                            string bairro3 = txtBairro4.Text;
                            string tipo3 = txtTipoImovel4.Text;
                            string negocio3 = txtTipoNegocio4.Text;
                            int quarto3 = Convert.ToInt32(txtQuarto4.Text);
                            float valor3 = Convert.ToUInt32(txtValor4.Text);

                            string dataInicio = Selecao2.Text;
                            string dataFim = Selecao.Text;


                            int codigo = Convert.ToInt32(txtCodigo.Text);
                            string nomeCliente = txtNome.Text;
                            int telefone = Convert.ToInt32(txtTelefone.Text);
                            int cpf = Convert.ToInt32(txtCPF.Text);
                            string login = txtLogin.Text;
                            string senha = txtSenha.Text;
                            string url = null;

                            if (codigo3 == 0)
                            {
                                Response.Redirect("Principal.aspx");
                            }
                            else
                            {
                                url = "Cliente3.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                            }
                            Response.Redirect(url);
                        }
                        else
                        {
                            lblMensagem1.Text = "Escolha uma opção! ";
                        }
                    }//fecha o try
                    catch (Exception ex)
                    {

                        lblMensagem1.Text = ex.Message;

                    }//fecha o catch

            }
            }
        }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {

            lblMensagem1.Text = "Página em construção";
     
        }
    }
}
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
            txtDataIni.Text = Request.QueryString["dataIni"];
            txtDatafim.Text = Request.QueryString["datafim"];

            string dataIni = txtDataIni.Text;
            string datafim = txtDatafim.Text;

            lblMensagem1.Text = "* Só é permitido no minimo um mês de aluguel";
            //if (Selecao2.Text == "")
            //{
            //    Calendario1.Visible = false;
            //    Selecao.Text = "Aperte duas vezes na Data Inicial para escolher a Data de entrega!";

            //}
            //else
            //{
            //    Selecao.Text = "";
            //    Calendario1.Visible = true;
            //}

            if(dataIni != "")
            {
                DateTime df = Convert.ToDateTime(datafim);
                DateTime d = df.AddDays(1);

                string dataAd = Convert.ToString(d);

                string tamanho = dataAd;
                dataAd = tamanho.Remove(10, tamanho.Length - 10);

                Selecao2.Text = dataAd;
                Selecao2.Enabled = false;

                Calendario2.Enabled = false;
            }
        }

        public void Calendario_Change(object sender, EventArgs e)
        {
            System.DateTime dia = default(System.DateTime);
            Selecao.Text = "";
            foreach (System.DateTime dia_loopVariable in Calendario1.SelectedDates)
            {
                dia = dia_loopVariable;
                Selecao.Text = Selecao.Text + dia;
                string tamanho = Selecao.Text;
                Selecao.Text = tamanho.Remove(10, tamanho.Length - 10);
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
                string tamanho = Selecao2.Text;
                Selecao2.Text = tamanho.Remove(10, tamanho.Length - 10);
                
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
            string datafimreserva = txtDatafim.Text; //data final de reserva

            if (datafimreserva == "")//data do fim da reserva estiver vazio
            {

                if (data > data2) //data atual maior que data inicial
                {
                    //comandos
                    lblMensagem1.Text = "Data Incial não é válida!";
                    Selecao2.Text = null;


                }//fecha o if
                else
                {
                    if (Selecao.Text != "")//campo data final não for vazio
                    {
                        DateTime dateIni = Convert.ToDateTime(Selecao2.Text);//data inicial
                        DateTime data3 = Convert.ToDateTime(Selecao.Text);//data Final
                        DateTime dataIniMes = dateIni.AddMonths(1);

                        if (data2 >= data3 || data3<dataIniMes)//data inicial maior q data final
                        {
                            lblMensagem1.Text = "Data Final invalida! (Data de entrega menor que a Data Inicial ou Data de entrega menor que 30 dias da Data Inicial)";
                            Selecao.Text = null;
                        }
                        else
                        {
                            try
                            {
                                int codImov = Convert.ToInt32(txtCodigo4.Text);
                                DateTime dataInicio = Convert.ToDateTime(Selecao2.Text);
                                DateTime dataFim = Convert.ToDateTime(Selecao.Text);

                                AluguelDAL aludal = new AluguelDAL();
                                Alugados alu = aludal.PesquisarCodigoClienteDataValida(codImov, dataInicio, dataFim);
                                DateTime datInicio = alu.dataInicio;
                                Nullable<DateTime> datFim = alu.dataFim;

                                string datIni = Convert.ToString(datInicio);
                                string tamanho = datIni;
                                datIni = tamanho.Remove(10, tamanho.Length - 10);

                                string df = Convert.ToString(datFim);
                                string tamanho2 = df;
                                df = tamanho2.Remove(10, tamanho.Length - 10);

                                lblMensagem1.Text = "* Já existe um agendamento pra essa data! " + datInicio + " até " + datFim + ". Escolha outra data";
                                Selecao.Text = "";
                                Selecao2.Text = "";
                            }
                            catch (Exception)
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


                                url = "FormaPagamento.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                                Response.Redirect(url);
                            }       
                        }
                    }
                    else
                    {

                        try
                        {
                            int codImov = Convert.ToInt32(txtCodigo4.Text);
                            DateTime dataInicio = Convert.ToDateTime(Selecao2.Text);

                            AluguelDAL aludal = new AluguelDAL();
                            Alugados alu = aludal.PesquisarCodigoClienteDataIniValida(codImov, dataInicio);
                            DateTime datInicio = alu.dataInicio;
                            Nullable<DateTime> datFim = alu.dataFim;

                            string datIni = Convert.ToString(datInicio);
                            string tamanho = datIni;
                            datIni = tamanho.Remove(10, tamanho.Length - 10);

                            string df = Convert.ToString(datFim);
                            string tamanho2 = df;
                            df = tamanho2.Remove(10, tamanho.Length - 10);

                            lblMensagem1.Text = "* Já existe um agendamento pra essa data! " + datInicio + " até " + datFim + ". Escolha outra data";
                            Selecao.Text = "";
                            Selecao2.Text = "";
                        }
                        catch (Exception)
                        {

                            int codigo3 = Convert.ToInt32(txtCodigo4.Text);
                            string bairro3 = txtBairro4.Text;
                            string tipo3 = txtTipoImovel4.Text;
                            string negocio3 = txtTipoNegocio4.Text;
                            int quarto3 = Convert.ToInt32(txtQuarto4.Text);
                            float valor3 = Convert.ToUInt32(txtValor4.Text);

                            string dataInicio = Selecao2.Text;
                            string dataFim = null;

                            int codigo = Convert.ToInt32(txtCodigo.Text);
                            string nomeCliente = txtNome.Text;
                            int telefone = Convert.ToInt32(txtTelefone.Text);
                            int cpf = Convert.ToInt32(txtCPF.Text);
                            string login = txtLogin.Text;
                            string senha = txtSenha.Text;
                            string url = null;


                            url = "FormaPagamento.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                            Response.Redirect(url);
                        }                       
                    }
                }
            }
            else
            {
                //repete o codigo sem a data gerada automaticamente
                DateTime datafimre = Convert.ToDateTime(txtDatafim.Text);
                string tamanho = txtDatafim.Text;
                txtDatafim.Text = tamanho.Remove(10, tamanho.Length - 10);
                if (datafimre >= data2) //data fim reserva maior que data inicial
                {
                    //comandos
                    lblMensagem1.Text = "Escolha uma data inicial maior que " + txtDatafim.Text;
                    Selecao2.Text = null;


                }//fecha o if
                else
                {
                    if (Selecao.Text != "")//campo data final não for vazio
                    {
                        DateTime dateIni = Convert.ToDateTime(Selecao2.Text);//data inicial
                        DateTime data3 = Convert.ToDateTime(Selecao.Text);//data Final
                        DateTime dataIniMes = dateIni.AddMonths(1);

                        if (data2 >= data3 || data3 < dataIniMes)//data inicial maior q data final
                        {
                            lblMensagem1.Text = "Data Final invalida! (Data de entrega menor que a Data Inicial ou Data de entrega menor que 30 dias da Data Inicial)";
                            Selecao.Text = null;
                        }
                        else
                        {
                            try
                            {
                                int codImov = Convert.ToInt32(txtCodigo4.Text);
                                DateTime dataInicio = Convert.ToDateTime(Selecao2.Text);
                                DateTime dataFim = Convert.ToDateTime(Selecao.Text);

                                AluguelDAL aludal = new AluguelDAL();
                                Alugados alu = aludal.PesquisarCodigoClienteDataValida(codImov, dataInicio, dataFim);
                                DateTime datInicio = alu.dataInicio;
                                Nullable<DateTime> datFim = alu.dataFim;

                                string datIni = Convert.ToString(datInicio);
                                string tamanho3 = datIni;
                                datIni = tamanho3.Remove(10, tamanho.Length - 10);

                                string df = Convert.ToString(datFim);
                                string tamanho4 = df;
                                df = tamanho4.Remove(10, tamanho.Length - 10);

                                lblMensagem1.Text = "* Já existe um agendamento pra essa data! " + datInicio + " até " + datFim + ". Escolha outra data";
                                Selecao.Text = "";
                                Selecao2.Text = "";
                            }
                            catch (Exception)
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


                                url = "FormaPagamento.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                                Response.Redirect(url);
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            int codImov = Convert.ToInt32(txtCodigo4.Text);
                            DateTime dataInicio = Convert.ToDateTime(Selecao2.Text);


                            AluguelDAL aludal = new AluguelDAL();
                            Alugados alu = aludal.PesquisarCodigoClienteDataIniValida(codImov, dataInicio);
                            DateTime datInicio = alu.dataInicio;
                            Nullable<DateTime> datFim = alu.dataFim;

                            string datIni = Convert.ToString(datInicio);
                            string tamanho5 = datIni;
                            datIni = tamanho5.Remove(10, tamanho.Length - 10);

                            string df = Convert.ToString(datFim);
                            string tamanho6 = df;
                            df = tamanho6.Remove(10, tamanho.Length - 10);

                            lblMensagem1.Text = "* Já existe um agendamento pra essa data! " + datInicio + " até " + datFim + ". Escolha outra data";
                            Selecao.Text = "";
                            Selecao2.Text = "";
                        }
                        catch (Exception)
                        {

                            int codigo3 = Convert.ToInt32(txtCodigo4.Text);
                            string bairro3 = txtBairro4.Text;
                            string tipo3 = txtTipoImovel4.Text;
                            string negocio3 = txtTipoNegocio4.Text;
                            int quarto3 = Convert.ToInt32(txtQuarto4.Text);
                            float valor3 = Convert.ToUInt32(txtValor4.Text);

                            string dataInicio = Selecao2.Text;
                            string dataFim = null;

                            int codigo = Convert.ToInt32(txtCodigo.Text);
                            string nomeCliente = txtNome.Text;
                            int telefone = Convert.ToInt32(txtTelefone.Text);
                            int cpf = Convert.ToInt32(txtCPF.Text);
                            string login = txtLogin.Text;
                            string senha = txtSenha.Text;
                            string url = null;


                            url = "FormaPagamento.aspx?codigoImovel=" + codigo3 + "&nomeBairro=" + bairro3 + "&tipo=" + tipo3 + "&negocio=" + negocio3 + "&quarto=" + quarto3 + "&valor=" + valor3 + "&dataInicio=" + dataInicio + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                            Response.Redirect(url);
                        }
                    }
                }
            }
        }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {

            
     
        }
    }
}
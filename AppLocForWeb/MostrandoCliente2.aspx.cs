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
    public partial class MostrandoCliente2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = Request.QueryString["codigoCliente"];
            tbNome.Text = Request.QueryString["nomeCliente"];
            tbTelefone.Text = Request.QueryString["telefoneCliente"];
            tbCPF.Text = Request.QueryString["cpfCliente"];
            tbLogin.Text = Request.QueryString["loginCliente"];
            tbSenha.Text = Request.QueryString["senhaCliente"];

            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            tbCPF.Enabled = false;
            tbLogin.Enabled = false;
            tbSenha.Enabled = false;

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

        protected void btnSeguinte_Click(object sender, EventArgs e)
        {
                string codigocli = txtCodigoCliente.Text;

            
                    int codigo = Convert.ToInt32(txtCodigoCliente.Text);
                    string nomeCliente = tbNome.Text;
                    int telefone = Convert.ToInt32(tbTelefone.Text);
                    int cpf = Convert.ToInt32(tbCPF.Text);
                    string login = tbLogin.Text;
                    string senha = tbSenha.Text;

                    AluguelDAL aludal = new AluguelDAL();
                    Alugados alu = aludal.PesquisarCodigoCliente(codigo);
                    DateTime datIni = alu.dataInicio;
                    Nullable<DateTime> datFim = alu.dataFim;

                    DateTime di = Convert.ToDateTime(datIni);

                    DateTime data = DateTime.Now.Date;

                    if (di != null)
                    {
                        if (data > di)
                        {
                            //alugado

                            try //entra no try para conferir se tem uma reserva 
                            {
                                //agendado

                                //DateTime data = DateTime.Now.Date;

                                AluguelDAL aludaldata = new AluguelDAL();
                                Alugados aludata = aludaldata.PesquisarAgendado(codigo, data);
                                int codigoclire = aludata.codigoCliente;
                                int codigoImovre = aludata.codigoImovel;
                                int pagamentore = aludata.pagamento;
                                DateTime dataInire = aludata.dataInicio;
                                Nullable<DateTime> dataFimre = aludata.dataFim;

                                ImovelDAL imodal = new ImovelDAL();
                                Imovel imov = imodal.PesquisarCodigoImovel(codigoImovre);
                                string nomeBairrore = imov.nomeBairro;
                                string negociore = imov.negocioNome;
                                string tipore = imov.nomeTipoImovel;
                                int quartore = imov.quantidadeQuarto;
                                float valorre = imov.valorImovel;

                                string pagre = "";
                                switch (pagamentore)
                                {
                                    case 0:
                                        pagre = "Selecione:";
                                        break;
                                    case 1:
                                        pagre = "À Vista";
                                        break;
                                    case 2:
                                        pagre = "Boleto";
                                        break;
                                    case 3:
                                        pagre = "Cartão";
                                        break;
                                }

                                lblMensagem.Text = "cliente possui um aluguel e uma reserva";
                                //string url = null;
                                //url = "DadosGerais.aspx?codigoImovel=" + codigoImovre + "&nomeBairro=" + nomeBairrore + "&tipo=" + tipore + "&negocio=" + negociore + "&quarto=" + quartore + "&valor=" + valorre + "&dataInicio=" + dataInire + "&pagamento=" + pagre + "&dataFim=" + dataFimre + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;
                                //Response.Redirect(url);
                            }
                            catch (Exception) //se nao tiver uma reserva entra no catch, vai mostrar só o alugado.
                            {
                                
                                //throw;

                                AluguelDAL aludaldata = new AluguelDAL();
                                Alugados aludata = aludaldata.PesquisarAlugado(codigo, data);
                                int codigoclidata = aludata.codigoCliente;
                                int codigoImov = aludata.codigoImovel;
                                int pagamento = aludata.pagamento;
                                DateTime dataIni = aludata.dataInicio;
                                Nullable<DateTime> dataFim = aludata.dataFim;

                                ImovelDAL imodal = new ImovelDAL();
                                Imovel imov = imodal.PesquisarCodigoImovel(codigoImov);
                                string nomeBairro = imov.nomeBairro;
                                string negocio = imov.negocioNome;
                                string tipo = imov.nomeTipoImovel;
                                int quarto = imov.quantidadeQuarto;
                                float valor = imov.valorImovel;

                                string pag = "";
                                switch (pagamento)
                                {
                                    case 0:
                                        pag = "Selecione:";
                                        break;
                                    case 1:
                                        pag = "À Vista";
                                        break;
                                    case 2:
                                        pag = "Boleto";
                                        break;
                                    case 3:
                                        pag = "Cartão";
                                        break;
                                }

                                lblMensagem.Text = "cliente possui só um aluguel";
                                //string url = null;
                                //url = "DadosGerais.aspx?codigoImovel=" + codigoImov + "&nomeBairro=" + nomeBairro + "&tipo=" + tipo + "&negocio=" + negocio + "&quarto=" + quarto + "&valor=" + valor + "&dataInicio=" + dataIni + "&pagamento=" + pag + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;
                                //Response.Redirect(url);

                            }

                            
                          
                        }
                        else
                        {
                            //agendado

                            try
                            {
                               // conferir se tem um aluguel

                            AluguelDAL aludaldata = new AluguelDAL();
                            Alugados aludata = aludaldata.PesquisarAlugado(codigo, data);
                            int codigoclidata = aludata.codigoCliente;
                            int codigoImov = aludata.codigoImovel;
                            int pagamento = aludata.pagamento;
                            DateTime dataIni = aludata.dataInicio;
                            Nullable<DateTime> dataFim = aludata.dataFim;

                            ImovelDAL imodal = new ImovelDAL();
                            Imovel imov = imodal.PesquisarCodigoImovel(codigoImov);
                            string nomeBairro = imov.nomeBairro;
                            string negocio = imov.negocioNome;
                            string tipo = imov.nomeTipoImovel;
                            int quarto = imov.quantidadeQuarto;
                            float valor = imov.valorImovel;

                            string pag = "";
                            switch (pagamento)
                            {
                                case 0:
                                    pag = "Selecione:";
                                    break;
                                case 1:
                                    pag = "À Vista";
                                    break;
                                case 2:
                                    pag = "Boleto";
                                    break;
                                case 3:
                                    pag = "Cartão";
                                    break;
                            }

                            lblMensagem.Text = "cliente possui uma reserva e um aluguel";
                                //string url = null;
                                //url = "DadosGerais.aspx?codigoImovel=" + codigoImov + "&nomeBairro=" + nomeBairro + "&tipo=" + tipo + "&negocio=" + negocio + "&quarto=" + quarto + "&valor=" + valor + "&dataInicio=" + dataIni + "&pagamento=" + pag + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;
                                //Response.Redirect(url);



                            }
                            catch (Exception) //entra no catch se nao houver aluguel, mostra a reserva
                            {
                                
                                //throw;

                                //agendado

                                //DateTime data = DateTime.Now.Date;

                                AluguelDAL aludaldata = new AluguelDAL();
                                Alugados aludata = aludaldata.PesquisarAgendado(codigo, data);
                                int codigoclire = aludata.codigoCliente;
                                int codigoImovre = aludata.codigoImovel;
                                int pagamentore = aludata.pagamento;
                                DateTime dataInire = aludata.dataInicio;
                                Nullable<DateTime> dataFimre = aludata.dataFim;

                                ImovelDAL imodal = new ImovelDAL();
                                Imovel imov = imodal.PesquisarCodigoImovel(codigoImovre);
                                string nomeBairrore = imov.nomeBairro;
                                string negociore = imov.negocioNome;
                                string tipore = imov.nomeTipoImovel;
                                int quartore = imov.quantidadeQuarto;
                                float valorre = imov.valorImovel;

                                string pagre = "";
                                switch (pagamentore)
                                {
                                    case 0:
                                        pagre = "Selecione:";
                                        break;
                                    case 1:
                                        pagre = "À Vista";
                                        break;
                                    case 2:
                                        pagre = "Boleto";
                                        break;
                                    case 3:
                                        pagre = "Cartão";
                                        break;
                                }

                                lblMensagem.Text = "cliente possui só uma reserva";
                                //string url = null;
                                //url = "DadosGerais.aspx?codigoImovel=" + codigoImovre + "&nomeBairro=" + nomeBairrore + "&tipo=" + tipore + "&negocio=" + negociore + "&quarto=" + quartore + "&valor=" + valorre + "&dataInicio=" + dataInire + "&pagamento=" + pagre + "&dataFim=" + dataFimre + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;
                                //Response.Redirect(url);

                            }


                                
                            
                        }    
                    }
                    else
                    {
                        lblMensagem.Text = "<br />Cliente não possui imóvel alugado!<br /><br />Clique em Alugar para escolher um imóvel";
                        btnAlugar.Visible = true;
                        btnSeguinte.Visible = false;
                    }

             
                    //string url = null;

                    //url = "Cliente3.aspx?codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                    //Response.Redirect(url);
                

        }

        protected void btnAlugar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Escolher_Aluguel_Todos.aspx");
        }
    }
}
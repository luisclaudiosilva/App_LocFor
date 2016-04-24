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
            try
            {
                   AluguelDAL aludal = new AluguelDAL();
                   Alugados alu = aludal.PesquisarCodigoCliente(codigo);
                   int codigoImov = alu.codigoImovel;
                   int pagamento = alu.pagamento;
                   string dataIni = alu.dataInicioAluguel;
                   string dataFim = alu.dataFimAluguel;

                   ImovelDAL imodal = new ImovelDAL();
                   Imovel imov = imodal.PesquisarCodigoImovel(codigoImov);
                   string nomeBairro = imov.nomeBairro;
                   string negocio = imov.negocioNome;
                   string tipo = imov.nomeTipoImovel;
                   int quarto = imov.quantidadeQuarto;
                   float valor = imov.valorImovel;

                string pag = "";
                  switch(pagamento)
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


                  string url = null;
                  url = "DadosGerais.aspx?codigoImovel=" + codigoImov + "&nomeBairro=" + nomeBairro + "&tipo=" + tipo + "&negocio=" + negocio + "&quarto=" + quarto + "&valor=" + valor + "&dataInicio=" + dataIni + "&pagamento=" + pag + "&dataFim=" + dataFim + "&codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;
                  Response.Redirect(url);
            }
            catch(Exception)
            {
                   lblMensagem.Text = "Codigo do imovel nao encontrado";
            }      
                    //string url = null;

                    //url = "Cliente3.aspx?codigoCliente=" + codigo + "&nomeCliente=" + nomeCliente + "&telefoneCliente=" + telefone + "&cpfCliente=" + cpf + "&loginCliente=" + login + "&senhaCliente=" + senha;

                    //Response.Redirect(url);
                  

                
                

        }
    }
}
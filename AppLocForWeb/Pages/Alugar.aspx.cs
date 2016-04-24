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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnBuscar(object sender, EventArgs e)
        {
            string nomeBairro = Convert.ToString(DropDownList1.SelectedItem);
            string nomeTipoImovel = Convert.ToString(DropDownList2.SelectedItem);
            string quantidadeQuarto = Convert.ToString(DropDownList4.SelectedItem);
            string url = null;

            if (nomeBairro == "")
            {
                Response.Redirect("~/erro/erroGenerico.aspx");
            }
            else
            {
                url = "/Pages/Disponivel_Alugar.aspx?nomeBairro=" + nomeBairro + "&nomeTipoImovel=" + nomeTipoImovel + "&quantidadeQuarto=" + quantidadeQuarto;

            }
            Response.Redirect(url);
        }


        /* protected void Button1_Click(object sender, EventArgs e)
         {

             int codImovel = Convert.ToString(DropDownList1.SelectedValue);

             int codMun = ddlMunicipios.SelectedValue;

             int codBai = ddlBairros.SelectedValue;

             int codNeg = ddlNegocio.SelectedValue;

             string quartos = ddlQuartos.SelectedItem.Text;

             int codCat = ddlCategoria.SelectedValue;

             int nquartos = 0;

             string url = null;

             if (codEst == -1 | codMun == -1 | codBai == -1 | codNeg == -1 | codCat == -1)
             {
                 Response.Redirect("~/erro/erroGenerico.aspx");


             }
             else {
                 url = "Imoveis.aspx?codEstado=" + codEst + "&codMunicipio=" + codMun + "&codNegocio=" + codNeg + "&codCategoria=" + codCat + "&codBairro=" + codBai;

             }




             if (!quartos.Equals("TODOS"))
             {
                 nquartos = ddlQuartos.SelectedIndex;

                 url = url + "&codQuarto=" + nquartos;

             }



             Response.Redirect(url);


         }*/

        /* protected void btnCadastrar(object sender, EventArgs e)
         {
             try
             {
                 Pessoa p = new Pessoa();
                 p.Nome = txtNome.Text;
                 p.Endereco = txtEndereco.Text;
                 p.Email = txtEmail.Text;

                 PessoaDAL d = new PessoaDAL();
                 d.Gravar(p); //gravando a pessoa

                lblMensagem.Text = "Cliente " + p.Nome + " cadastrado com sucesso!";

                txtNome.Text = string.Empty;
                 txtEndereco.Text = string.Empty;
                 txtEmail.Text = string.Empty;
             }
             catch (Exception )
             {

                 lblMensagem.Text = ex.Message;
             }
         }*/
    }
}
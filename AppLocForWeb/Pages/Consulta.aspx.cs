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
    public partial class Consulta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //   /* try
        //    {
        //        int nomeBairro = Convert.ToInt32(DropDownList1.Text);
        //        BairroDAL b = new BairroDAL();

        //        GridView1.DataSource = b.Mostrar(nomeBairro); //popular o grid
        //        GridView1.DataBind(); //exibir o conteudo do grid

        //    }
        //    catch (Exception ex)
        //    {

        //        lblMensagem.Text = ex.Message;
        //    }*/
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    int codBairro = Convert.ToInt32(DropDownList1.SelectedValue);
        //    string url = null;

        //    if (codBairro == -1)
        //    {
        //        Response.Redirect("~/erro/erroGenerico.aspx");


        //    }
        //    else {
        //        url = "/Pages/Compras.aspx?codBairro=" + codBairro;

        //    }

        //}

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string nomeBairro = Convert.ToString(DropDownList1.SelectedItem);
            string nomeTipoImovel = Convert.ToString(DropDownList2.SelectedItem);
            string nomeNegocio = Convert.ToString(DropDownList3.SelectedItem);
            string nomeSituacao = Convert.ToString(DropDownList4.SelectedItem);
            string quantidadeQuarto = Convert.ToString(DropDownList5.SelectedItem);
            string url = null;

            if (nomeBairro == "")
            {
                Response.Redirect("~/erro/erroGenerico.aspx");
            }
            else
            {
                url = "/Pages/Compras.aspx?nomeBairro=" + nomeBairro + "&nomeTipoImovel=" + nomeTipoImovel + "&nomeNegocio=" + nomeNegocio + "&situacaoNegocio=" + nomeSituacao + "&quantidadeQuarto=" + quantidadeQuarto;

            }
            Response.Redirect(url);
        }
    }
}
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
    public partial class Disponivel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ImovelDAL imov = new ImovelDAL();

                GridView1.DataSource = imov.Disponivel(); //popular o grid
                GridView1.DataBind(); //exibir o conteudo do grid 
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}
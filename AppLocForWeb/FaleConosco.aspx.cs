using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AppLocForWeb
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                int imagemID = Convert.ToInt32(Request.QueryString["codigoFoto"]);



                //nomeArquivo], [horaUpload], [MIME], [imagem]

                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {

                    const string SQL = "SELECT [MIME], [imagem] FROM [Imagens] WHERE [codigoFoto] = @codigoFoto";


                    SqlCommand myCommand = new SqlCommand(SQL, Conn);

                    myCommand.Parameters.AddWithValue("@codigoFoto", imagemID);

                    Conn.Open();


                    SqlDataReader myReader = myCommand.ExecuteReader();


                    if (myReader.Read())
                    {


                        //Response.ContentType = myReader["MIME"].ToString();
                        //Response.BinaryWrite((byte[])myReader["imagem"]);

                        pnlCadastro.BackImageUrl = myReader["MIME"].ToString();
                        pnlCadastro.GetRouteUrl((byte[])myReader["imagem"]);

                    }

                    myReader.Close();

                    Conn.Close();

                }

            }

            catch (Exception ex)
            {

                Response.Write(ex.ToString());

            } 
        }
    }
}
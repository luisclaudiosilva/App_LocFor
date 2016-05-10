using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace AppLocForWeb
{
    public partial class Empresa : System.Web.UI.Page
    {

        //string fileType = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            //int codigo = 2;
            //codigo para deixar o Panel da Master desativado
            Panel pnlDaMaster = (Panel)this.Master.FindControl("pnlCadastro");
            pnlDaMaster.Enabled = false;

            //codigo para trazer a Imagem do imovel
          
        }

    //    protected void btnEnviar_Click(object sender, EventArgs e)
    //    {
    //        if (fupld.PostedFile == null || string.IsNullOrEmpty(fupld.PostedFile.FileName) || fupld.PostedFile.InputStream == null)
    //        {
    //            lblmsg.Text = "<br />Erro - Não foi possível enviar o arquivo.<br />";
    //            return;
    //        }
    //        else
    //        {
    //                        //'obtem a extensão do arquivo enviado  
    //        string extensao = Path.GetExtension(fupld.PostedFile.FileName).ToLower();
	
    //    string tipoArquivo = null;

    //                //'efetua a validação do arquivo

    //    switch (extensao )
    //    {
    //        case ".gif":
    //            tipoArquivo= "image/gif";
    //            break;
    //        case ".jpg":
    //        case ".jpeg":
    //        case ".jpe":
    //            tipoArquivo= "image/jpeg";
    //            break;
    //        default:
    //        lblmsg.Text = "<br />Erro - tipo de arquivo inválido.<br />";
    //        return;
    //    }
    //    using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //    {
    //        try
    //        {

    //            const string SQL = "INSERT INTO [Imagens] ([nome], [MIME], [imagem]) VALUES ( @nome,@MIME, @imagem) SELECT SCOPE_IDENTITY()";

    //            SqlCommand cmd = new SqlCommand(SQL, Conn);
                
    //            cmd.Parameters.AddWithValue("@nome", txtNomeArquivo.Text);

    //            cmd.Parameters.AddWithValue("@MIME", fileType);
			    
    //            byte[] imageBytes = new byte[fupld.PostedFile.InputStream.Length + 1];

    //            fupld.PostedFile.InputStream.Read(imageBytes, 0, imageBytes.Length);

    //            cmd.Parameters.AddWithValue("@imagem", imageBytes);
			 
    //            lblmsg.Text = "<br />Arquivo enviado com sucesso <br />";


    //            Conn.Open();
    //            int imagemID = Convert.ToInt16(cmd.ExecuteScalar());

    //            hplnkExibeImagem.NavigateUrl = "~/FaleConosco.aspx?codigoFoto=" + imagemID.ToString();

    //            Conn.Close();
    //        }
    //        catch
    //        {
    //            lblmsg.Text = "Erro ao enviar imagem"; 
    //            Conn.Close();
    //        }
    //    }

    //   }

    //}
    }
}
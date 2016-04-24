using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.NET -> SQL SERVER

namespace DAL.Persistence
{
    public class Conexao
    {

        //Atributos:
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método - Abrir Conexao
        protected void AbrirConexao()
        {
            try
            {
                //Conection String
                Con = new SqlConnection("Data Source=CLAUDIO-ACER;Initial Catalog=Projeto_Locacao;Persist Security Info=True;User ID=sa;Password=6871");
                Con.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //Método - Fechar Conexão
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

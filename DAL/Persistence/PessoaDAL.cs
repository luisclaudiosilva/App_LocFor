using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
     class PessoaDAL : Conexao
    {
        //Método para gravar dados: Insert
        public void Gravar(Pessoa p)
        {
            try
            {
                //Abrir Conexão:
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa (Nome, Endereco, Email) values (@v1, @v2, @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        //Método para atualizar dados: Update
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Id=@v4" , Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Id);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao atualizar o Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para excluir dados: Delete
        public void Excluir(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pessoa where Id=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Id);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao excluir o Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para obter 1 Pessoa pelo Código(Chave Primária)
        public Pessoa PesquisarPorCodigo(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa where Id=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Id);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Pessoa p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Id        = Convert.ToInt32(Dr["Id"]);
                    p.Nome      = Convert.ToString(Dr["Nome"]);
                    p.Endereco  = Convert.ToString(Dr["Endereco"]);
                    p.Email     = Convert.ToString(Dr["Email"]);

                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
    }

        //Método para listar todos os clientes cadastrados:
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa", Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>(); // lista vazia

                while(Dr.Read())
                {
                    Pessoa p    = new Pessoa();
                    p.Id        = Convert.ToInt32(Dr["Id"]);
                    p.Nome      = Convert.ToString(Dr["Nome"]);
                    p.Endereco  = Convert.ToString(Dr["Endereco"]);
                    p.Email     = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }

                return lista;

            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao listar os Clientes: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

       


    }
}

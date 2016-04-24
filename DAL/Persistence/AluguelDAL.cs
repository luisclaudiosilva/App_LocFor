using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class AluguelDAL : Conexao
    {
        //Método para gravar dados: Insert
        public void Gravar(Alugados a)
        {
            try
            {
                //Abrir Conexão:
                AbrirConexao();
                Cmd = new SqlCommand("insert into Aluguel (codigoImovel, codigoCliente, dataInicio, dataFim, codigoPagamento) values (@v1, @v2, @v3, @v4, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", a.codigoImovel);
                Cmd.Parameters.AddWithValue("@v2", a.codigoCliente);
                Cmd.Parameters.AddWithValue("@v3", a.dataInicioAluguel);
                Cmd.Parameters.AddWithValue("@v4", a.dataFimAluguel);
                Cmd.Parameters.AddWithValue("@v5", a.pagamento);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar: " + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        //    //Método para atualizar dados: Update
        //    public void Atualizar(Pessoa p)
        //    {
        //        try
        //        {
        //            AbrirConexao();
        //            Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Id=@v4" , Con);

        //            Cmd.Parameters.AddWithValue("@v1", p.Nome);
        //            Cmd.Parameters.AddWithValue("@v2", p.Endereco);
        //            Cmd.Parameters.AddWithValue("@v3", p.Email);
        //            Cmd.Parameters.AddWithValue("@v4", p.Id);

        //            Cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {

        //            throw new Exception("Erro ao atualizar o Cliente: " + ex.Message);
        //        }
        //        finally
        //        {
        //            FecharConexao();
        //        }
        //    }

        //    //Método para excluir dados: Delete
        //    public void Excluir(int Id)
        //    {
        //        try
        //        {
        //            AbrirConexao();
        //            Cmd = new SqlCommand("delete from Pessoa where Id=@v1", Con);

        //            Cmd.Parameters.AddWithValue("@v1", Id);

        //            Cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {

        //            throw new Exception("Erro ao excluir o Cliente: " + ex.Message);
        //        }
        //        finally
        //        {
        //            FecharConexao();
        //        }
        //    }

        //    //Método para obter 1 Pessoa pelo Código(Chave Primária)
        //    public Pessoa PesquisarPorCodigo(int Id)
        //    {
        //        try
        //        {
        //            AbrirConexao();
        //            Cmd = new SqlCommand("select * from Pessoa where Id=@v1", Con);
        //            Cmd.Parameters.AddWithValue("@v1", Id);
        //            Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

        //            Pessoa p = null; //criando um espaço de memória: ponteiro

        //            if (Dr.Read())
        //            {
        //                p = new Pessoa();

        //                p.Id        = Convert.ToInt32(Dr["Id"]);
        //                p.Nome      = Convert.ToString(Dr["Nome"]);
        //                p.Endereco  = Convert.ToString(Dr["Endereco"]);
        //                p.Email     = Convert.ToString(Dr["Email"]);

        //            }
        //            return p;
        //        }
        //        catch (Exception ex)
        //        {

        //            throw new Exception("Erro ao pesquisar o Cliente: " + ex.Message);
        //        }
        //        finally
        //        {
        //            FecharConexao();
        //        }
        //}

        //    //Método para listar todos os clientes cadastrados:
        //    public List<Pessoa> Listar()
        //    {
        //        try
        //        {
        //            AbrirConexao();
        //            Cmd = new SqlCommand("select * from Pessoa", Con);
        //            Dr = Cmd.ExecuteReader();

        //            List<Pessoa> lista = new List<Pessoa>(); // lista vazia

        //            while(Dr.Read())
        //            {
        //                Pessoa p    = new Pessoa();
        //                p.Id        = Convert.ToInt32(Dr["Id"]);
        //                p.Nome      = Convert.ToString(Dr["Nome"]);
        //                p.Endereco  = Convert.ToString(Dr["Endereco"]);
        //                p.Email     = Convert.ToString(Dr["Email"]);

        //                lista.Add(p);
        //            }

        //            return lista;

        //        }
        //        catch (Exception ex)
        //        {

        //            throw new Exception("Erro ao listar os Clientes: " + ex.Message);
        //        }
        //        finally
        //        {
        //            FecharConexao();
        //        }
        //    }

       
       
        public Alugados PesquisarPorCodigo(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoImovel=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.dataFimAluguel = Convert.ToString(Dr["dataFim"]);
                    //p.Nome = Convert.ToString(Dr["Nome"]);
                    //p.Endereco = Convert.ToString(Dr["Endereco"]);
                    //p.Email = Convert.ToString(Dr["Email"]);

                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar a data " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Alugados PesquisarCodigoCliente(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoCliente=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicioAluguel = Convert.ToString(Dr["dataInicio"]);
                    p.dataFimAluguel = Convert.ToString(Dr["dataFim"]);
                    p.pagamento = Convert.ToInt32(Dr["codigoPagamento"]);

                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar os dados do Cliente " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data.SqlClient;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;



namespace DAL.Persistence
{
    public class ImovelDAL : Conexao
    {
        public List<Imovel> Disponivel()
        {
            try
            {

                AbrirConexao();
                Cmd = new SqlCommand("SELECT Imovel.codigoImovel, Bairro.nomeBairro, Negocio.negocioNome, TipoImovel.nomeTipoImovel, Quartos.quantidadeQuarto, situacaoImovel.tipoSituacao, Imovel.valorImovel FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro INNER JOIN Negocio ON Imovel.codigoNegocio = Negocio.codigoNegocio INNER JOIN Quartos ON Imovel.codigoQuarto = Quartos.codigoQuarto INNER JOIN TipoImovel ON Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel INNER JOIN situacaoImovel ON Imovel.codigoSituacao = situacaoImovel.codigoSituacao", Con);


                Dr = Cmd.ExecuteReader();

                List<Imovel> lista = new List<Imovel>(); // lista vazia

                while (Dr.Read())
                {
                    Imovel p = new Imovel();
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.nomeBairro = Convert.ToString(Dr["nomeBairro"]);
                    p.nomeTipoImovel = Convert.ToString(Dr["nomeTipoImovel"]);
                    p.negocioNome = Convert.ToString(Dr["negocioNome"]);
                    p.tipoSituacao = Convert.ToString(Dr["tipoSituacao"]);
                    p.quantidadeQuarto = Convert.ToInt32(Dr["quantidadeQuarto"]);
                    p.valorImovel = Convert.ToUInt32(Dr["valorImovel"]);

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

        public void Gravar(Imovel i)
        {
            try
            {
                //Abrir Conexão:
                AbrirConexao();
                Cmd = new SqlCommand("insert into Imovel (nomeBairro, nomeTipoImovel, codigoNegocio, codigoSituacao, codigoQuarto, valorImovel) values (@v1, @v2, @v3, @v4, @v5, @v6)", Con);
  
                Cmd.Parameters.AddWithValue("@v1", i.nomeBairro);
                Cmd.Parameters.AddWithValue("@v2", i.nomeTipoImovel);
                Cmd.Parameters.AddWithValue("@v3", i.tipoSituacao);
                Cmd.Parameters.AddWithValue("@v4", i.negocioNome);
                Cmd.Parameters.AddWithValue("@v5", i.quantidadeQuarto);
                Cmd.Parameters.AddWithValue("@v6", i.valorImovel);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar!: " + ex.Message);
            }
            finally
            {
                FecharConexao();

            }
        }

        public Imovel PesquisarPorBairro(string nomeBairro)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT Imovel.codigoImovel, Bairro.nomeBairro FROM Bairro INNER JOIN Imovel ON Bairro.codigoBairro = Imovel.codigoBairro where nomeBairro=@nomeBairro", Con);
                Cmd.Parameters.AddWithValue("@nomeBairro", nomeBairro);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Imovel p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Imovel();

                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.nomeBairro = Convert.ToString(Dr["nomeBairro"]);
                    //p.Endereco = Convert.ToString(Dr["Endereco"]);
                    //p.Email = Convert.ToString(Dr["Email"]);

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

        public Imovel PesquisarPorCodigo(int codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Imovel (codigoSituacao) values (@v1) where codigoImovel=@v2 ", Con);
                Cmd.Parameters.AddWithValue("@v2", codigo);
               
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Imovel p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    int valor = 1;
                    p = new Imovel();

                    p.tipoSituacao = Convert.ToString(Dr[valor]);
                    //p.Endereco = Convert.ToString(Dr["Endereco"]);
                    //p.Email = Convert.ToString(Dr["Email"]);

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

        public Imovel PesquisarCodigoImovel(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select Bairro.nomeBairro, TipoImovel.nomeTipoImovel, Negocio.negocioNome, Quartos.quantidadeQuarto, valorImovel from Imovel inner join Bairro on Imovel.codigoBairro = Bairro.codigoBairro inner join TipoImovel on Imovel.codigoTipoImovel = TipoImovel.codigoTipoImovel inner join Negocio on Imovel.codigoNegocio = Negocio.codigoNegocio inner join Quartos on Imovel.codigoQuarto = Quartos.codigoQuarto where codigoImovel=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

               Imovel p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Imovel();

                    p.nomeBairro = Convert.ToString(Dr["nomeBairro"]);
                    p.negocioNome = Convert.ToString(Dr["negocioNome"]);
                    p.nomeTipoImovel = Convert.ToString(Dr["nomeTipoImovel"]);
                    p.quantidadeQuarto = Convert.ToInt32(Dr["quantidadeQuarto"]);
                    p.valorImovel = Convert.ToUInt32(Dr["valorImovel"]);

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


        

        public void Atualizar(int codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Imovel set codigoSituacao=@v1 where codigoImovel=@v2", Con);

                

                Cmd.Parameters.AddWithValue("@v1", 1);
                Cmd.Parameters.AddWithValue("@v2", codigo);
                

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
    }
    }


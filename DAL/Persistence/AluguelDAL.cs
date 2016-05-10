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
                Cmd.Parameters.AddWithValue("@v3", a.dataInicio);
                Cmd.Parameters.AddWithValue("@v4", a.dataFim);
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


        public void Gravar2(Alugados a)
        {
            try
            {
                //Abrir Conexão:
                AbrirConexao();
                Cmd = new SqlCommand("insert into Aluguel (codigoImovel, codigoCliente, dataInicio, codigoPagamento) values (@v1, @v2, @v3, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", a.codigoImovel);
                Cmd.Parameters.AddWithValue("@v2", a.codigoCliente);
                Cmd.Parameters.AddWithValue("@v3", a.dataInicio);
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


        public void Excluir(Alugados a)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Aluguel where codigoCliente=@v1 and  dataInicio=@v2", Con);
               
                Cmd.Parameters.AddWithValue("@v1", a.codigoCliente);
                Cmd.Parameters.AddWithValue("@v2", a.dataInicio);

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

       
       
        public Alugados PesquisarCodAluguel(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoAluguel=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.dataInicio = Convert.ToDateTime (Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
                    //p.Nome = Convert.ToString(Dr["Nome"]);
                    //p.Endereco = Convert.ToString(Dr["Endereco"]);
                    //p.Email = Convert.ToString(Dr["Email"]);

                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo aluguel" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }



        public Alugados PesquisarCodImovel(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where codigoImovel=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo imovel " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Alugados PesquisarCodImovelDataFim(int codigo)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where codigoImovel=@v1 and dataFim is NULL", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
               
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                   
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo imovel " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Alugados PesquisarCodImovelData(int codigo, DateTime di)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where (codigoImovel=@v1 and dataInicio <= @v2 and dataFim >= @v2) or (codigoImovel=@v1 and dataInicio <= @v2 and dataFim is NULL)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", di);
               
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    


                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo imovel " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Alugados PesquisarCodImovelDataMaior(int codigo, DateTime di)  //Método para obter Código(Chave Primária)
        {
            try
            {


                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where (codigoImovel=@v1 and dataInicio > @v2 and dataFim > @v2) or (codigoImovel=@v1 and dataInicio > @v2 and dataFim is NULL)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", di);

                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                   


                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo imovel " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Alugados PesquisarCodImovelData2(int codigo, DateTime di)  //Método para obter Código(Chave Primária)
        {
            try
            {
                

                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where (codigoImovel = @v1 and dataInicio <= @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", di);
                //Cmd.Parameters.AddWithValue("@v3", df);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);


                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o codigo imovel " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        public Alugados PesquisarImovelClienteDataAlugado(int codigo, int cli, DateTime di)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where codigoImovel=@v1 and codigoCliente=@v2 and (dataInicio <= @v3 and dataFim >= @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", cli);
                Cmd.Parameters.AddWithValue("@v3", di);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);


                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Alugados PesquisarImovelClienteDataAgendar(int codigo, int cli, DateTime di)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel where codigoImovel=@v1 and codigoCliente=@v2 and (dataInicio > @v3 and dataFim > @v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", cli);
                Cmd.Parameters.AddWithValue("@v3", di);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);


                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar " + ex.Message);
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
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
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


        public Alugados PesquisarCodigoClienteDataValida(int codigo, DateTime dataIni, DateTime dataFim)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where (codigoImovel=@v1 and @v2>=dataInicio and @v2<=dataFim) or (codigoImovel=@v1 and @v3>=dataInicio and @v3<=dataFim)", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", dataIni);
                Cmd.Parameters.AddWithValue("@v3", dataFim);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
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


        public Alugados PesquisarCodigoClienteDataIniValida(int codigo, DateTime dataIni)  //Método para obter Código(Chave Primária)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where (codigoCliente=@v1 and (@v2>=dataInicio and @v2<=dataFim)) or (codigoCliente=@v1 and (@v2>=dataInicio and @v2<=dataFim))", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", dataIni);
                
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
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

        public Alugados PesquisarCodigoClienteData(int codigo)  //verificar se o cliente tem um aluguel com data final nula
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoCliente=@v1 and dataFim is NULL", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    
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

        public Alugados PesquisarAlugado(int codigo, DateTime d)  //Método para obter Código(Chave Primária)
        {
            try
            {
                
                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoCliente=@v1 and dataInicio<@v2", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", d);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
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

        public Alugados PesquisarAgendado(int codigo, DateTime d)  //Método para obter Código(Chave Primária)
        {
            try
            {

                AbrirConexao();
                Cmd = new SqlCommand("select * from Aluguel where codigoCliente=@v1 and dataInicio>@v2", Con);
                Cmd.Parameters.AddWithValue("@v1", codigo);
                Cmd.Parameters.AddWithValue("@v2", d);
                Dr = Cmd.ExecuteReader(); //execurção da leitura das informações do BD

                Alugados p = null; //criando um espaço de memória: ponteiro

                if (Dr.Read())
                {
                    p = new Alugados();

                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    p.dataInicio = Convert.ToDateTime(Dr["dataInicio"]);
                    p.dataFim = Convert.ToDateTime(Dr["dataFim"]);
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

        public List<Alugados> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM Aluguel", Con);
                //Cmd.Parameters.AddWithValue("@v1", codigo);
                Dr = Cmd.ExecuteReader();

                List<Alugados> lista = new List<Alugados>(); // lista vazia

                while (Dr.Read())
                {
                    Alugados p = new Alugados();
                    p.codigoAluguel = Convert.ToInt32(Dr["codigoAluguel"]);
                    //p.codigoCliente = Convert.ToInt32(Dr["codigoCliente"]);
                    //p.codigoImovel = Convert.ToInt32(Dr["codigoImovel"]);
                    //p.dataInicioAluguel = Convert.ToDateTime(Dr["dataInicio"]);
                   
                   
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

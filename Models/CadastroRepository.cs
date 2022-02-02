using System;
using System.Collections.Generic;
using MySqlConnector;


namespace atv4.Models
{
    public class CadastroRepository
    {
        private const string DadosConexao = "Database=Atividade4;Data source=localhost; User Id=root";
        public Cadastro validarLogin(Cadastro cadastro)
        {

            cadastro.Senha = Criptografo.TextoCriptografado(cadastro.Senha);
  

            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();



            String Query = "select * from Cadastro where Login=@Login and Senha=@Senha";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Login", cadastro.Login);
            Comando.Parameters.AddWithValue("@Senha", cadastro.Senha); // SQL Injection

            MySqlDataReader Reader = Comando.ExecuteReader();

            Cadastro cadastroEncontrado = null;

            if (Reader.Read())
            {
                cadastroEncontrado = new Cadastro();

                cadastroEncontrado.IdCadastro = Reader.GetInt32("IdCadastro"); // tudo que eu retorno eu uso get e tudo que passo é Set

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeCompleto")))
                    cadastroEncontrado.NomeCompleto = Reader.GetString("NomeCompleto");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cpf")))
                    cadastroEncontrado.Cpf = Reader.GetString("Cpf");

                cadastroEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    cadastroEncontrado.Email = Reader.GetString("Email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    cadastroEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    cadastroEncontrado.Senha = Reader.GetString("Senha");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Rua")))
                    cadastroEncontrado.Rua = Reader.GetString("Rua");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Numero")))
                    cadastroEncontrado.Numero = Reader.GetString("Numero");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Bairro")))
                    cadastroEncontrado.Bairro = Reader.GetString("Bairro");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cep")))
                    cadastroEncontrado.Cep = Reader.GetString("Cep");

            }

            Conexao.Close();

            return cadastroEncontrado;

        }


        public Cadastro buscarPorId(int IdCadastro)
        {

            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "select * from Cadastro where IdCadastro=@IdCadastro";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@IdCadastro", IdCadastro);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Cadastro cadastroEncontrado = new Cadastro();

            if (Reader.Read())
            {

                cadastroEncontrado.IdCadastro = Reader.GetInt32("IdCadastro");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeCompleto")))
                    cadastroEncontrado.NomeCompleto = Reader.GetString("NomeCompleto");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cpf")))
                    cadastroEncontrado.Cpf = Reader.GetString("Cpf");

                cadastroEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    cadastroEncontrado.Email = Reader.GetString("Email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    cadastroEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    cadastroEncontrado.Senha = Reader.GetString("Senha");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Rua")))
                    cadastroEncontrado.Rua = Reader.GetString("Rua");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Numero")))
                    cadastroEncontrado.Numero = Reader.GetString("Numero");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Bairro")))
                    cadastroEncontrado.Bairro = Reader.GetString("Bairro");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Cep")))
                    cadastroEncontrado.Cep = Reader.GetString("Cep");

            }

            Conexao.Close();

            return cadastroEncontrado;

        }


        public void inserir(Cadastro cadastro)
        {
            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            String Query = "insert into Cadastro (NomeCompleto,Cpf,DataNascimento,Email,Login,Senha,Rua,Numero,Bairro,Cep) Values(@NomeCompleto,@Cpf,@DataNascimento,@Email,@Login,@Senha,@Rua,@Numero,@Bairro,@Cep)";

            // Executar comando

            //(@IdUsuario,@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno)

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@NomeCompleto", cadastro.NomeCompleto);
            Comando.Parameters.AddWithValue("@Cpf", cadastro.Cpf);
            Comando.Parameters.AddWithValue("@DataNascimento", cadastro.DataNascimento);
            Comando.Parameters.AddWithValue("@Email", cadastro.Email);
            Comando.Parameters.AddWithValue("@Login", cadastro.Login);
            Comando.Parameters.AddWithValue("@Senha", cadastro.Senha);
            Comando.Parameters.AddWithValue("@Rua", cadastro.Rua);
            Comando.Parameters.AddWithValue("@Numero", cadastro.Numero);
            Comando.Parameters.AddWithValue("@Bairro", cadastro.Bairro);
            Comando.Parameters.AddWithValue("@Cep", cadastro.Cep);

            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();


        }

        public void atualzar(Cadastro cadastro)
        {
            // Abrir conexão com o banco
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            //(@IdUsuario,@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno)

            String Query = "update Cadastro SET NomeCompleto=@NomeCompleto, Cpf=@Cpf, DataNascimento=@DataNascimento, Email=@Email, Login=@Login, Senha=@Senha, Rua=@Rua, Numero=@Numero, Bairro=@Bairro, Cep=@Cep where IdCadastro=@IdCadastro";

            // Executar comando

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdCadastro", cadastro.IdCadastro);
            Comando.Parameters.AddWithValue("@NomeCompleto", cadastro.NomeCompleto);
            Comando.Parameters.AddWithValue("@Cpf", cadastro.Cpf);
            Comando.Parameters.AddWithValue("@DataNascimento", cadastro.DataNascimento);
            Comando.Parameters.AddWithValue("@Email", cadastro.Email);
            Comando.Parameters.AddWithValue("@Login", cadastro.Login);
            Comando.Parameters.AddWithValue("@Senha", cadastro.Senha);
            Comando.Parameters.AddWithValue("@Rua", cadastro.Rua);
            Comando.Parameters.AddWithValue("@Numero", cadastro.Numero);
            Comando.Parameters.AddWithValue("@SenBairroha", cadastro.Bairro);
            Comando.Parameters.AddWithValue("@Cep", cadastro.Cep);


            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();

        }

        public void remover(Cadastro cadastro)
        {
            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            String Query = "delete from Cadastrado where IdCadastro=@IdCadastro";

            // Executar comando

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@IdCadastro", cadastro.IdCadastro); //  Controle para SQL - Injection

            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();
        }


    }
}
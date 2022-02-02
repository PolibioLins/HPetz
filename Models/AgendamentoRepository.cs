using System;
using System.Collections.Generic;
using MySqlConnector;


namespace atv4.Models
{
    public class AgendamentoRepository
    {

        private const string DadosConexao = "Database=Atividade4;Data source=localhost; User Id=root";

        public Agendamento buscarPorId(int IdAgendamento)
        {

            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String Query = "select * from Agendamento where IdAgendamento=@IdAgendamento";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@IdAgendamento", IdAgendamento);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Agendamento agendamentoEncontrado = new Agendamento();

            if (Reader.Read())
            {

                agendamentoEncontrado.IdAgendamento = Reader.GetInt32("IdAgendamento");

                agendamentoEncontrado.IdCadastro = Reader.GetInt32("IdCadastro");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeTutor")))
                    agendamentoEncontrado.NomeTutor = Reader.GetString("NomeTutor");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomePet")))
                    agendamentoEncontrado.NomePet = Reader.GetString("NomePet");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Raca")))
                    agendamentoEncontrado.Raca = Reader.GetString("Raca");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Tamanho")))
                    agendamentoEncontrado.Tamanho = Reader.GetString("Tamanho");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Servico")))
                    agendamentoEncontrado.Servico = Reader.GetString("Servico");

                agendamentoEncontrado.DataHoraAgendamento = Reader.GetDateTime("DataHoraAgendamento");

            }

            Conexao.Close();

            return agendamentoEncontrado;

        }

        public List<Agendamento> listar()
        {
            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            String Query = "select * from Agendamento";

            // Executar comando
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Agendamento> List = new List<Agendamento>();

            while (Reader.Read())
            {
                Agendamento agendamentoEncontrado = new Agendamento();

                agendamentoEncontrado.IdAgendamento = Reader.GetInt32("IdAgendamento");

                agendamentoEncontrado.IdCadastro = Reader.GetInt32("IdCadastro");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeTutor")))
                    agendamentoEncontrado.NomeTutor = Reader.GetString("NomeTutor");

                if (!Reader.IsDBNull(Reader.GetOrdinal("NomePet")))
                    agendamentoEncontrado.NomePet = Reader.GetString("NomePet");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Raca")))
                    agendamentoEncontrado.Raca = Reader.GetString("Raca");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Tamanho")))
                    agendamentoEncontrado.Tamanho = Reader.GetString("Tamanho");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Servico")))
                    agendamentoEncontrado.Servico = Reader.GetString("Servico");

                agendamentoEncontrado.DataHoraAgendamento = Reader.GetDateTime("DataHoraAgendamento");

                List.Add(agendamentoEncontrado);
            }

            Conexao.Close();

            return List;

        }

        public void inserir(Agendamento agendamento)
        {
            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            String Query = "insert into Agendamento (IdCadastro,NomeTutor,NomePet,Raca,Tamanho,Servico,DataHoraAgendamento) Values(@IdCadastro,@NomeTutor,@NomePet,@Raca,@Tamanho,@Servico,@DataHoraAgendamento)";

            // Executar comando

            //(@IdUsuario,@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno)

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdCadastro", agendamento.IdCadastro);
            Comando.Parameters.AddWithValue("@NomeTutor", agendamento.NomeTutor);
            Comando.Parameters.AddWithValue("@NomePet", agendamento.NomePet);
            Comando.Parameters.AddWithValue("@Raca", agendamento.Raca);
            Comando.Parameters.AddWithValue("@Tamanho", agendamento.Tamanho);
            Comando.Parameters.AddWithValue("@Servico", agendamento.Servico);
            Comando.Parameters.AddWithValue("@DataHoraAgendamento", agendamento.DataHoraAgendamento);


            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();


        }

        public void atualzar(Agendamento agendamento)
        {
            // Abrir conexão com o banco
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            //(@IdUsuario,@Nome,@Origem,@Destino,@Atrativos,@Saida,@Retorno)

            String Query = "update Agendamento SET IdCadastro=@IdCadastro, NomeTutor=@NomeTutor, NomePet=@NomePet, Raca=@Raca, Tamanho=@Tamanho, Servico=@Servico, DataHoraAgendamento=@DataHoraAgendamento where IdAgendamento=@IdAgendamento";

            // Executar comando

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@IdAgendamento ", agendamento.IdAgendamento);
            Comando.Parameters.AddWithValue("@IdCadastro", agendamento.IdCadastro);
            Comando.Parameters.AddWithValue("@NomeTutor", agendamento.NomeTutor);
            Comando.Parameters.AddWithValue("@NomePet", agendamento.NomePet);
            Comando.Parameters.AddWithValue("@Raca", agendamento.Raca);
            Comando.Parameters.AddWithValue("@Tamanho", agendamento.Tamanho);
            Comando.Parameters.AddWithValue("@Servico", agendamento.Servico);
            Comando.Parameters.AddWithValue("@DataHoraAgendamento", agendamento.DataHoraAgendamento);

            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();

        }

        public void remover(Agendamento agendamento)
        {
            // Abrir conexão com o banco

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            // Definir a Query

            String Query = "delete from Agendamento where IdAgendamento=@IdAgendamento";

            // Executar comando

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@IdAgendamento", agendamento.IdAgendamento); //  Controle para SQL - Injection

            // Executar no banco 

            Comando.ExecuteNonQuery();

            // Fechar a conexão 
            Conexao.Close();
        }

        
    }
}
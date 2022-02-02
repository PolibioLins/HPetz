using System;

namespace atv4.Models
{
    public class Cadastro
    {
        public int IdCadastro {get; set;}
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }

        public Cadastro() { }

    }
}
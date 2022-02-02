using System;

namespace atv4.Models
{
    public class Agendamento
    {
        public int IdAgendamento { get; set; }
        public int IdCadastro {get;set;}
        public string NomeTutor { get; set; }
        public string NomePet { get; set; }
        public string Raca { get; set; }
        public string Tamanho { get; set; }
        public string Servico { get; set; }
        public DateTime DataHoraAgendamento { get; set; }


        public Agendamento() { }
    }
}
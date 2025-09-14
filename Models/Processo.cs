namespace Case.Models
{
    public class Processo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int? IdPai { get; set; }

        public int IdArea { get; set; }

        public string Descricao { get; set; }

        public string Responsavel { get; set; }

        public bool Status { get; set; }

        public DateTime Criado { get; set; }

        public DateTime Atualizado { get; set; }


    }
}

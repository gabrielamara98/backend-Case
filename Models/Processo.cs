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

        public bool Status { get; set; }= true;

        public DateTime Criado { get; set; } = DateTime.Now;

        public DateTime Atualizado { get; set; } = DateTime.Now;

    }
}

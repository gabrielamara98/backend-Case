namespace Case.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao{ get; set; }

        public string Responsavel { get; set; }

        public bool Status { get; set; } = true;

        public DateTime Criado { get; set; } = DateTime.Now;

        public DateTime Atualizado { get; set; } = DateTime.Now;
    }
}

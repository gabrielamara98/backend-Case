using Case.Models;

namespace Case.Dto
{
    public class ProcessoDto:Processo
    {
        public List<Processo> ProcessosFilhos { get; set; }
    }
}

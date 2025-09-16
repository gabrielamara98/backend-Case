using Case.Dto;
using Case.Models;

namespace Case.Service
{
    public interface IProcessoService
    {
        public Processo GetById(int id);

        public List<Processo> GetPaiAreaById(int id);
        public Processo AddAProcessoPai(Processo novoProcesso);
        public Processo AddAProcessoFilho(Processo novoProcesso);
        public List<Processo> GetByIdPai(int id);
    }
}

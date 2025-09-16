using Case.Data;
using Case.Dto;
using Case.Models;

namespace Case.Service
{
    public class ProcessoService : IProcessoService
    {
        private readonly AppDbContext _context;

        public ProcessoService(AppDbContext context)
        {
            _context = context;
        }

        public Processo AddAProcessoFilho(Processo novoProcesso)
        {
            _context.Processos.Add(novoProcesso);
            _context.SaveChanges();
            return novoProcesso;
        }

        public Processo AddAProcessoPai(Processo novoProcesso)
        {
            _context.Processos.Add(novoProcesso);
            _context.SaveChanges();
            return novoProcesso;
        }

        public Processo GetById(int id)
        {
            return _context.Processos.FirstOrDefault(c=> c.Id ==id);
        }

        public List<Processo> GetByIdPai(int id)
        {
            var idArea = _context.Processos.Where(c => c.IdPai == id).ToList();
            return idArea;
        }

        public List<Processo> GetPaiAreaById(int id)
        {
            var idArea = _context.Processos.Where(c => c.IdArea == id && c.IdPai ==null).ToList();
            return idArea;
        }
    }
}

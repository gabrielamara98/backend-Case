using Case.Dto;

namespace Case.Service
{
    public class ProcessoService : IProcessoService
    {
        public ProcessoDto GetById(int id)
        {
            //var idProcesso = .FirstOrDefault(x => x.Id == id);
            //if (idProcesso == null)
            //{
            //    return NotFound();
            //}
            //var processosFilhos = .Where(x => x.IdPai == id);

            //ProcessoDto response = new ProcessoDto()
            //{
            //    Id = idProcesso.Id,
            //    Nome = idProcesso.Nome,
            //    IdPai = idProcesso.IdPai,
            //    IdArea = idProcesso.IdArea,
            //    Descricao = idProcesso.Descricao,
            //    Responsavel = idProcesso.Responsavel,
            //    Status = idProcesso.Status,
            //    Criado = idProcesso.Criado,
            //    Atualizado = idProcesso.Atualizado,
            //    ProcessosFilhos = processosFilhos.ToList()
            //};
            throw new NotImplementedException();
        }
    }
}

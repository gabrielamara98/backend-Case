using Case.Dto;
using Case.Models;
using Microsoft.AspNetCore.Mvc;

namespace Case.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : Controller
    {
        private static List<Processo> listaProcesso = new List<Processo>()
        {
            new Processo() { Id = 1,Nome = "Infra", Descricao = "Nada",IdArea = 1, Status = true},
            new Processo() { Id = 2,Nome = "Lista Pc", Descricao = "Filho de Infra",IdArea = 1, Status = true, IdPai = 1},
            new Processo() { Id = 5,Nome = "Vendas de PC", Descricao = "Filho de Infra",IdArea = 1, Status = true, IdPai = 1},
            new Processo() { Id = 3,Nome = "Contas", Descricao = "Nada",IdArea = 2, Status = true},
            new Processo() { Id = 4,Nome = "Pendencias", Descricao = "Filho de Contas",IdArea = 2, Status = true, IdPai = 3},
        };

        [HttpGet]
        public ActionResult<List<Processo>> GetAll()
        {
            return Ok(listaProcesso);
        }

        [HttpGet("{id}")]

        public ActionResult <ProcessoDto> GetById(int id)
        {
            var idProcesso = listaProcesso.FirstOrDefault(x => x.Id == id);
            if (idProcesso == null)
            {
                return NotFound();
            }
            var processosFilhos = listaProcesso.Where(x => x.IdPai == id);

            ProcessoDto response = new ProcessoDto()
            {
                Id = idProcesso.Id,
                Nome = idProcesso.Nome,
                IdPai = idProcesso.IdPai,
                IdArea = idProcesso.IdArea,
                Descricao = idProcesso.Descricao,
                Responsavel = idProcesso.Responsavel,
                Status = idProcesso.Status,
                Criado = idProcesso.Criado,
                Atualizado = idProcesso.Atualizado,
                ProcessosFilhos = processosFilhos.ToList()
            };

            return Ok(response);

        }
    }
}

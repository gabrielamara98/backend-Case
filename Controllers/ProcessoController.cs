using Case.Dto;
using Case.Models;
using Case.Service;
using Microsoft.AspNetCore.Mvc;

namespace Case.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoController : Controller
    {
        private readonly IProcessoService _processoService;

        public ProcessoController(IProcessoService processoService)
        {
            _processoService = processoService;
        }

        [HttpGet("processo-filhos/{id}")]
        public ActionResult<List<Processo>> GetByIdPai(int id)
        {
            return Ok(_processoService.GetByIdPai(id));
        }
        [HttpGet]
        public ActionResult<List<Processo>> GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public ActionResult <Processo> GetById(int id)
        {

            return Ok(_processoService.GetById(id));

        }

        [HttpGet("filhos-area/{id}")]
        public ActionResult <List<Processo>> GetPaiAreaById(int id)
        {
            return Ok(_processoService.GetPaiAreaById(id));
        }
        [HttpPost("novo-processo-pai")]
        public ActionResult AddAProcessoPai([FromBody]Processo novoProcesso)
        {
            var processoCriado = _processoService.AddAProcessoPai(novoProcesso);
            return Ok(processoCriado);
        }
        [HttpPost("novo-processo")]
        public ActionResult AddAProcessoFilho([FromBody] Processo novoProcesso)
        {
            var processoCriado = _processoService.AddAProcessoFilho(novoProcesso);
            return Ok(processoCriado);
        }
    }
}

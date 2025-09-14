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
            new Processo() { Id = 3,Nome = "Contas", Descricao = "Nada",IdArea = 2, Status = true},
            new Processo() { Id = 4,Nome = "Pendencias", Descricao = "Filho de Contas",IdArea = 2, Status = true, IdPai = 3},
        };

        [HttpGet]
        public ActionResult<List<Processo>> GetAll()
        {
            return Ok(listaProcesso);
        }
    }
}

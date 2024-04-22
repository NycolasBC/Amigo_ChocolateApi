using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        public GrupoController(IGrupoService grupoService)
        {
            _grupoService = grupoService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_grupoService.BuscarTodos());
        }


        [HttpGet("buscarporid/{id}")]
        public IActionResult GetPorId(int id)
        {
            return Ok(_grupoService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoGrupoViewModel novoGrupo)
        {
            await _grupoService.Inserir(novoGrupo);

            return Ok("Grupo cadastrado com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _grupoService.Excluir(id);

            return Ok("Grupo excluído com sucesso");
        }

        #endregion

        #endregion
    }
}

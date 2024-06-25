using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("[controller]")]
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

        [HttpGet()]
        [ProducesResponseType(typeof(GrupoViewModel), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_grupoService.BuscarTodos());
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GrupoViewModel), StatusCodes.Status200OK)]
        public IActionResult GetPorId(int id)
        {
            return Ok(_grupoService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] NovoGrupoRequest novoGrupo)
        {
            await _grupoService.Inserir(novoGrupo.NovoGrupo, novoGrupo.Id);

            return Created();
        }

        #endregion

        #region - DELETE

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Excluir(int id)
        {
            await _grupoService.Excluir(id);

            return Ok();
        }

        #endregion

        #endregion
    }
}

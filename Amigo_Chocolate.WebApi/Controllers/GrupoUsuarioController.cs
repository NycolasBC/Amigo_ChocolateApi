using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoUsuarioController : ControllerBase
    {
        private readonly IGrupoUsuarioService _grupoUsuarioService;
        public GrupoUsuarioController(IGrupoUsuarioService grupoUsuarioService)
        {
            _grupoUsuarioService = grupoUsuarioService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscarporid/{id}")]
        public async Task<IActionResult> GetPorId(int id)
        {
            return Ok(await _grupoUsuarioService.BuscarPorId(id));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoGrupoUsuarioViewModel novoGrupoUsuario)
        {
            await _grupoUsuarioService.Inserir(novoGrupoUsuario);

            return Ok("Grupo cadastrado com sucesso para o usuário");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _grupoUsuarioService.Excluir(id);

            return Ok("Grupo excluído com sucesso para o usuário");
        }

        #endregion

        #endregion
    }
}

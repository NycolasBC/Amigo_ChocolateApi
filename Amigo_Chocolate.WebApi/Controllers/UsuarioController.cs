using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("buscartodos")]
        public IActionResult Get()
        {
            return Ok(_usuarioService.BuscarTodos());
        }


        [HttpGet("buscarporemail/{email}")]
        public IActionResult GetPorEmail(string email)
        {
            return Ok(_usuarioService.BuscarPorEmail(email));
        }

        #endregion

        #region - POST

        [HttpPost("adicionar")]
        public async Task<IActionResult> Post([FromBody] NovoUsuarioViewModel novoUsuario)
        {
            await _usuarioService.Inserir(novoUsuario);

            return Ok("Usuário cadastrado com sucesso");
        }

        #endregion

        #region - DELETE

        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _usuarioService.Excluir(id);

            return Ok("Usuário excluído com sucesso");
        }

        #endregion

        #endregion
    }
}

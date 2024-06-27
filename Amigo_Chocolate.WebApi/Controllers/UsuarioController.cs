using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Convite;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("[controller]")]
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

        [HttpGet()]
        [ProducesResponseType(typeof(UsuarioViewModel), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_usuarioService.BuscarTodos());
        }


        [HttpGet("convite/{email}")]
        [ProducesResponseType(typeof(ConviteViewModel), StatusCodes.Status200OK)]
        public IActionResult GetPorEmail(string email)
        {
            return Ok(_usuarioService.BuscarPorEmail(email));
        }

        #endregion

        #region - POST

        [HttpPost()]
        [ProducesResponseType(typeof(UsuarioViewModel), StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] NovoUsuarioViewModel novoUsuario)
        {
            await _usuarioService.Inserir(novoUsuario);

            return Created();
        }

        [HttpPost("convite")]
        [ProducesResponseType(typeof(NovoConviteViewModel), StatusCodes.Status201Created)]
        public async Task<IActionResult> PostConvite([FromBody] NovoConviteViewModel novoConvite)
        {
            await _usuarioService.InserirConvite(novoConvite);

            return Created();
        }

        #endregion

        #region - DELETE

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(UsuarioViewModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> Excluir(int id)
        {
            await _usuarioService.Excluir(id);

            return Ok();
        }

        #endregion

        #endregion
    }
}

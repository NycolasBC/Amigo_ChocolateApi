using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Microsoft.AspNetCore.Mvc;

namespace Amigo_Chocolate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        #region - Metódos CRUD

        #region - POST

        [HttpPost("autenticar")]
        public async Task<IActionResult> Post(NovoLoginViewModel login)
        {
            var podeLogar = await _loginService.Autenticar(login);

            if (podeLogar == null)
            {
                return BadRequest("Login inválido");
            }

            return Ok(podeLogar);
        }

        #endregion

        #endregion
    }
}

using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.Services
{
    public class LoginService : ILoginService
    {
        #region - Atributos e Construtores

        private readonly ILoginRepository _loginRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;

        public LoginService(ILoginRepository loginRepository, IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _loginRepository = loginRepository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        #endregion


        public async Task<UsuarioViewModel?> Autenticar(NovoLoginViewModel login)
        {
            var usuarioAutenticado = await _loginRepository
                .Autenticar(login.Email, login.Senha);

            if (usuarioAutenticado != null)
            {
                var usuario = await _usuarioRepository.BuscarPorEmail(login.Email);
                UsuarioViewModel buscaUsuarioPoEmail = _mapper.Map<UsuarioViewModel>(usuario);

                return buscaUsuarioPoEmail;
            }
            else
            {
                return null;
            }
        }
    }
}

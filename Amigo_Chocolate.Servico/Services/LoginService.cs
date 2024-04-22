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


        public Task Atualizar(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginViewModel> BuscarPorId(int id)
        {
            try
            {
                var login = await _loginRepository.BuscarPorId(id);

                LoginViewModel buscaLoginId = _mapper.Map<LoginViewModel>(login);

                return buscaLoginId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar login (service): {ex.Message}");
            }
        }

        public async Task<UsuarioViewModel?> Autenticar(NovoLoginViewModel login)
        {
            var usuarioAutenticado = await _loginRepository
                .Autenticar(login.Email, login.Senha);

            if (usuarioAutenticado != null)
            {
                var usuario = await _usuarioRepository.BuscarPorEmail(login.Email);
                UsuarioViewModel buscaUsuarioEmail = _mapper.Map<UsuarioViewModel>(usuario);

                return buscaUsuarioEmail;
            }
            else
            {
                return null;
            }
        }
    }
}

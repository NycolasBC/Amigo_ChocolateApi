using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Login;
using AutoMapper;

namespace Amigo_Chocolate.Servico.Services
{
    public class LoginService : ILoginService
    {
        #region - Atributos e Construtores

        private readonly ILoginRepository _loginRepository;
        private IMapper _mapper;

        public LoginService(ILoginRepository loginRepository, IMapper mapper)
        {
            _loginRepository = loginRepository;
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

        public async Task<bool> Autenticar(NovoLoginViewModel login)
        {
            var usuarioAutenticado = await _loginRepository
                .Autenticar(login.Email, login.Senha);

            if (usuarioAutenticado == null)
                return false;

            return true;
        }
    }
}

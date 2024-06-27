using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Convite;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.Services
{
    public class UsuarioService : IUsuarioService
    {
        #region - Atributos e Construtores

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        private readonly ILoginRepository _loginRepository;
        private IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IGrupoUsuarioRepository grupoUsuarioRepository, ILoginRepository loginRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _grupoUsuarioRepository = grupoUsuarioRepository;
            _loginRepository = loginRepository;
            _mapper = mapper;
        }

        #endregion


        public async Task Atualizar(UsuarioViewModel usuario)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizarConvite(AtualizaConviteViewModel convite)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ConviteViewModel>> BuscarPorEmail(string email)
        {
            try
            {
                var convites = await _usuarioRepository.BuscarPorEmail(email);

                IEnumerable<ConviteViewModel> listaConvites = _mapper.Map<IEnumerable<ConviteViewModel>>(convites);

                return listaConvites;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar convites do usuário (service): {ex.Message}");
            }           
        }

        public IEnumerable<UsuarioViewModel> BuscarTodos()
        {
            try
            {
                var usuarios = _usuarioRepository.BuscarTodos();
                
                return _mapper.Map<IEnumerable<UsuarioViewModel>>(usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os usuários (service): {ex.Message}");
            }
        }

        public async Task Excluir(int id)
        {
            try
            {
                var buscaUsuario = await _usuarioRepository.BuscarPorId(id);

                if (buscaUsuario == null)
                    throw new ApplicationException("Não é possível excluir um usuário que não existe!");

                var buscaGrupoUsuario = _grupoUsuarioRepository.BuscarPorId(id);

                if (buscaGrupoUsuario == null)
                    await _usuarioRepository.Excluir(buscaUsuario);
                else
                {
                    await _grupoUsuarioRepository.Excluir(buscaGrupoUsuario);
                    await _usuarioRepository.Excluir(buscaUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir usuário (service): {ex.Message}");
            }
            
        }

        public async Task Inserir(NovoUsuarioViewModel usuario)
        {
            try
            {
                var novoUsuario = _mapper.Map<Usuario>(usuario);

                NovoLoginViewModel login = new NovoLoginViewModel
                {
                    Email = novoUsuario.Email,
                    Senha = novoUsuario.Senha,
                };

                var novoLogin = _mapper.Map<Login>(login);

                await _usuarioRepository.Inserir(novoUsuario);
                await _loginRepository.Inserir(novoLogin);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir usuário (service): {ex.Message}");
            }         
        }

        public async Task InserirConvite(NovoConviteViewModel convite)
        {
            try
            {
                var novoConvite = _mapper.Map<Convite>(convite);

                await _usuarioRepository.InserirConvite(novoConvite);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao enviar convite (service): {ex.Message}");
            }
        }
    }
}

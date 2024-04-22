using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.Services
{
    public class GrupoUsuarioService : IGrupoUsuarioService
    {
        #region - Atributos e Construtores

        private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        private IMapper _mapper;

        public GrupoUsuarioService(IGrupoUsuarioRepository grupoUsuarioRepository, IMapper mapper)
        {
            _grupoUsuarioRepository = grupoUsuarioRepository;
            _mapper = mapper;
        }

        #endregion


        public Task Atualizar(GrupoUsuarioViewModel grupoUsuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoUsuarioViewModel> BuscarPorId(int id)
        {
            try
            {
                var gruposUsuario = _grupoUsuarioRepository.BuscarPorId(id);

                return _mapper.Map<IEnumerable<GrupoUsuarioViewModel>>(gruposUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os grupos do usuário (service): {ex.Message}");
            }
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(NovoGrupoUsuarioViewModel grupoUsuario)
        {
            try
            {
                var novoGrupoUsuario = _mapper.Map<GrupoUsuario>(grupoUsuario);
                await _grupoUsuarioRepository.Inserir(novoGrupoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir grupo ao usuário (service): {ex.Message}");
            }
        }
    }
}

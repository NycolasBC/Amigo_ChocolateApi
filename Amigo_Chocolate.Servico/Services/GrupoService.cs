using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.Services
{
    public class GrupoService : IGrupoService
    {
        #region - Atributos e Construtores

        private readonly IGrupoRepository _grupoRepository;
        private IMapper _mapper;

        public GrupoService(IGrupoRepository grupoRepository, IMapper mapper)
        {
            _grupoRepository = grupoRepository;
            _mapper = mapper;
        }

        #endregion


        public Task Atualizar(GrupoViewModel grupo)
        {
            throw new NotImplementedException();
        }

        public async Task<GrupoViewModel> BuscarPorId(int id)
        {
            try
            {
                var grupo = await _grupoRepository.BuscarPorId(id);

                GrupoViewModel buscaGrupoId = _mapper.Map<GrupoViewModel>(grupo);

                return buscaGrupoId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar grupo (service): {ex.Message}");
            }
        }

        public IEnumerable<GrupoViewModel> BuscarTodos()
        {
            try
            {
                var grupos = _grupoRepository.BuscarTodos();

                return _mapper.Map<IEnumerable<GrupoViewModel>>(grupos);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar todos os grupos (service): {ex.Message}");
            }
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(NovoGrupoViewModel grupo)
        {
            try
            {
                var novoGrupo = _mapper.Map<Grupo>(grupo);
                await _grupoRepository.Inserir(novoGrupo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir grupo (service): {ex.Message}");
            }
        }
    }
}

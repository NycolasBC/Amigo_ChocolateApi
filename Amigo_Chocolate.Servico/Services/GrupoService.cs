using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using AutoMapper;
using System.Collections.Generic;

namespace Amigo_Chocolate.Servico.Services
{
    public class GrupoService : IGrupoService
    {
        #region - Atributos e Construtores

        private readonly IGrupoRepository _grupoRepository;
        private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        private IMapper _mapper;

        public GrupoService(IGrupoRepository grupoRepository, IGrupoUsuarioRepository grupoUsuarioRepository, IMapper mapper)
        {
            _grupoRepository = grupoRepository;
            _grupoUsuarioRepository = grupoUsuarioRepository;
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

        public async Task Inserir(NovoGrupoViewModel grupo, int idUsuario)
        {
            try
            {
                var novoGrupo = _mapper.Map<Grupo>(grupo);
                await _grupoRepository.Inserir(novoGrupo);

                int ultimoId = await _grupoRepository.BuscarId();
                var grupoUsuarioViewModel = new NovoGrupoUsuarioViewModel
                {
                    IdGrupo = ultimoId,
                    IdUsuario = idUsuario,
                    Id_Status = 1
                };

                var grupoUsuario = _mapper.Map<GrupoUsuario>(grupoUsuarioViewModel);

                await _grupoUsuarioRepository.Inserir(grupoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir grupo (service): {ex.Message}");
            }
        }
    }
}

using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;
using System.Collections.Generic;

namespace Amigo_Chocolate.Servico.Services
{
    public class GrupoUsuarioService : IGrupoUsuarioService
    {
        #region - Atributos e Construtores

        private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        private readonly IGrupoRepository _grupoRepository;
        private IMapper _mapper;

        public GrupoUsuarioService(IGrupoUsuarioRepository grupoUsuarioRepository, IGrupoRepository grupoRepository, IMapper mapper)
        {
            _grupoUsuarioRepository = grupoUsuarioRepository;
            _grupoRepository = grupoRepository;
            _mapper = mapper;
        }

        #endregion


        public Task Atualizar(GrupoUsuarioViewModel grupoUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GrupoViewModel>> BuscarPorId(int id)
        {
            try
            {
                var gruposUsuario = _grupoUsuarioRepository.BuscarPorId(id);

                if (gruposUsuario != null)
                {
                    List<GrupoViewModel> grupos = new List<GrupoViewModel>();

                    foreach (GrupoUsuario itens in gruposUsuario)
                    {
                        grupos.Add(_mapper.Map<GrupoViewModel>(await _grupoRepository.BuscarPorId(itens.IdGrupo)));
                    }

                    return grupos;
                }
                else
                {
                    throw new Exception("Não foi encontrado nenhum grupo para esse usuário");
                }
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

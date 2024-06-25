using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class GrupoUsuarioRepository : IGrupoUsuarioRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public GrupoUsuarioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public async Task Atualizar(GrupoUsuario grupoUsuario)
        {
            try
            {
                await _contexto.GrupoUsuario.Where(g => g.IdGrupo == grupoUsuario.IdGrupo).ExecuteUpdateAsync(g => g.SetProperty(g => g.Id_Status, 9));
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar grupo: {ex.Message}");
            }
        }

        public IEnumerable<GrupoUsuario> BuscarPorId(int id)
        {
            try
            {
                var grupoUsuario = _contexto.GrupoUsuario.Where(c => c.IdUsuario == id).ToList();

                return grupoUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar grupos do usuário: {ex.Message}");
            }
        }

        public async Task Excluir(IEnumerable<GrupoUsuario> grupoUsuario)
        {
            try
            {
                _contexto.GrupoUsuario.RemoveRange(grupoUsuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir usuário no grupo: {ex.Message}");
            }
        }

        public async Task Inserir(GrupoUsuario grupoUsuario)
        {
            try
            {
                await _contexto.GrupoUsuario.AddAsync(grupoUsuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir usuário no grupo: {ex.Message}");
            }
        }
    }
}

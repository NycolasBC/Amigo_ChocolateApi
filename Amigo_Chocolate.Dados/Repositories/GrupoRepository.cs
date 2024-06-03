using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public GrupoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public async Task Atualizar(Grupo grupo)
        {
            try
            {
                await _contexto.Grupo.Where(g => g.IdGrupo == grupo.IdGrupo).ExecuteUpdateAsync(g => g.SetProperty(g => g, grupo));
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar grupo: {ex.Message}");
            }
        }

        public async Task<Grupo> BuscarPorId(int id)
        {
            try
            {
                var grupo = await _contexto.Grupo.Where(c => c.IdGrupo == id).FirstOrDefaultAsync();

                return grupo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o grupo: {ex.Message}");
            }

        }

        public async Task<int> BuscarId()
        {
            var ultimoId = await _contexto.Grupo.MaxAsync(c => (int?)c.IdGrupo) ?? 0;

            return ultimoId;
        }

        public IEnumerable<Grupo> BuscarTodos()
        {
            try
            {
                var grupos = _contexto.Grupo.Where(c => c.Id_Status != 9).ToList();

                return grupos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os grupos: {ex.Message}");
            }
        }

        public async Task Excluir(Grupo grupo)
        {
            try
            {
                _contexto.Grupo.Remove(grupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir grupo: {ex.Message}");
            }
        }

        public async Task Inserir(Grupo grupo)
        {
            try
            {
                await _contexto.Grupo.AddAsync(grupo);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir grupo: {ex.Message}");
            }
        }
    }
}

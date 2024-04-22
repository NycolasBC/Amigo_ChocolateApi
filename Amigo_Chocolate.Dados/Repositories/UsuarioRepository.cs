using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public UsuarioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public async Task Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            try
            {
                var usuario = await _contexto.Usuario.Where(c => c.IdUsuario == id).FirstOrDefaultAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o usuário: {ex.Message}");
            }
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            try
            {
                var usuarios = _contexto.Usuario.Where(c => c.Id_Status != 9).ToList();

                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os usuários: {ex.Message}");
            }
        }

        public async Task Excluir(Usuario usuario)
        {
            try
            {
                _contexto.Usuario.Remove(usuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir usuário: {ex.Message}");
            }
        }

        public async Task Inserir(Usuario usuario)
        {
            try
            {
                await _contexto.Usuario.AddAsync(usuario);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir usuário: {ex.Message}");
            }
        }
    }
}

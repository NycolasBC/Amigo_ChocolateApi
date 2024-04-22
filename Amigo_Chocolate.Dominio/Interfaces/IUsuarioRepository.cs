using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> BuscarTodos();
        Task<Usuario> BuscarPorEmail(string email);
        Task<Usuario> BuscarPorId(int id);
        Task Inserir(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task Excluir(Usuario usuario);
    }
}

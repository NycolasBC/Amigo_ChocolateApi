using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> BuscarTodos();
        Task<IEnumerable<Convite>> BuscarPorEmail(string email);
        Task<Usuario> BuscarPorId(int id);
        Task Inserir(Usuario usuario);
        Task InserirConvite(Convite convite);
        Task Atualizar(Usuario usuario);
        Task AtualizarConvite(Convite convite);
        Task Excluir(Usuario usuario);
    }
}

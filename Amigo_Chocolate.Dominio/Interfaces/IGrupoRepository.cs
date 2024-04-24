using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IGrupoRepository
    {
        IEnumerable<Grupo> BuscarTodos();
        Task<Grupo> BuscarPorId(int id);
        Task<int> BuscarId();
        Task Inserir(Grupo grupo);
        Task Atualizar(Grupo grupo);
        Task Excluir(Grupo grupo);
    }
}

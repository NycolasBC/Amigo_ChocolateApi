using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface ISorteioRepository
    {
        IEnumerable<Sorteio> BuscarTodos();
        Task<Sorteio> BuscarPorId(int id);
        Task Inserir(Sorteio sorteio);
        Task Atualizar(Sorteio sorteio);
        Task Excluir(Sorteio sorteio);
    }
}

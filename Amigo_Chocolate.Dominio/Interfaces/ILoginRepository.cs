using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface ILoginRepository
    {
        Task<Login> BuscarPorId(int id);
        Task Inserir(Login login);
        Task Atualizar(Login login);
        Task Excluir(Login login);
    }
}

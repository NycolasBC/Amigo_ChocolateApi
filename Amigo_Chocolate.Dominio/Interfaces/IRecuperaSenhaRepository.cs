using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IRecuperaSenhaRepository
    {
        Task<RecuperaSenha> BuscarPorId(int id);
        Task Inserir(RecuperaSenha recuperaSenha);
        Task Atualizar(RecuperaSenha recuperaSenha);
    }
}

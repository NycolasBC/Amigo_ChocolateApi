using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IGrupoUsuarioRepository
    {
        IEnumerable<GrupoUsuario> BuscarPorId(int id);
        IEnumerable<GrupoUsuario> BuscarUsuariosPorId(int id);
        Task Inserir(GrupoUsuario grupoUsuario);
        Task Atualizar(GrupoUsuario grupoUsuario);
        Task Excluir(IEnumerable<GrupoUsuario> grupoUsuario);
    }
}

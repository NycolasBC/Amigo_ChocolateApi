using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IGrupoUsuarioService
    {
        IEnumerable<GrupoUsuarioViewModel> BuscarPorId(int id);
        Task Inserir(NovoGrupoUsuarioViewModel grupoUsuario);
        Task Atualizar(GrupoUsuarioViewModel grupoUsuario);
        Task Excluir(int id);
    }
}

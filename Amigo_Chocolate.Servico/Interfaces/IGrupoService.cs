using Amigo_Chocolate.Servico.ViewModels.Grupo;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IGrupoService
    {
        IEnumerable<GrupoViewModel> BuscarTodos();
        Task<GrupoViewModel> BuscarPorId(int id);
        Task Inserir(NovoGrupoViewModel grupo);
        Task Atualizar(GrupoViewModel grupo);
        Task Excluir(int id);
    }
}

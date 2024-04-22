using Amigo_Chocolate.Servico.ViewModels.Usuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioViewModel> BuscarTodos();
        Task<UsuarioViewModel> BuscarPorId(int id);
        Task Inserir(NovoUsuarioViewModel usuario);
        Task Atualizar(UsuarioViewModel usuario);
        Task Excluir(int id);
    }
}

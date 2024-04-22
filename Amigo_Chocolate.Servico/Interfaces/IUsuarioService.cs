using Amigo_Chocolate.Servico.ViewModels.Usuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioViewModel> BuscarTodos();
        Task<UsuarioViewModel> BuscarPorEmail(string email);
        Task Inserir(NovoUsuarioViewModel usuario);
        Task Atualizar(UsuarioViewModel usuario);
        Task Excluir(int id);
    }
}

using Amigo_Chocolate.Servico.ViewModels.Convite;
using Amigo_Chocolate.Servico.ViewModels.Usuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioViewModel> BuscarTodos();
        Task<IEnumerable<ConviteViewModel>> BuscarPorEmail(string email);
        Task Inserir(NovoUsuarioViewModel usuario);
        Task InserirConvite(NovoConviteViewModel convite);
        Task Atualizar(UsuarioViewModel usuario);
        Task AtualizarConvite(AtualizaConviteViewModel convite);
        Task Excluir(int id);
    }
}

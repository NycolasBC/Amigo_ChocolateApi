using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.Usuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface ILoginService
    {
        Task<UsuarioViewModel?> Autenticar(NovoLoginViewModel login);
        Task<LoginViewModel> BuscarPorId(int id);
        Task Atualizar(LoginViewModel login);
    }
}

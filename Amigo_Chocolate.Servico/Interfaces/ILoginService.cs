using Amigo_Chocolate.Servico.ViewModels.Login;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface ILoginService
    {
        Task<bool> Autenticar(NovoLoginViewModel login);
        Task<LoginViewModel> BuscarPorId(int id);
        Task Atualizar(LoginViewModel login);
    }
}

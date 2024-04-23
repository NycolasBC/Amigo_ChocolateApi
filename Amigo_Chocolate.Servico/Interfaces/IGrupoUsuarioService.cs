using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Amigo_Chocolate.Servico.ViewModels.Usuario;

namespace Amigo_Chocolate.Servico.Interfaces
{
    public interface IGrupoUsuarioService
    {
        Task<List<GrupoViewModel>> BuscarPorId(int id);
        Task Inserir(NovoGrupoUsuarioViewModel grupoUsuario);
        Task Atualizar(GrupoUsuarioViewModel grupoUsuario);
        Task Excluir(int id);
    }
}

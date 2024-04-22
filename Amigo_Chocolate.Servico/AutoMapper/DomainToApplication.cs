using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.RecuperaSenha;
using Amigo_Chocolate.Servico.ViewModels.Sorteio;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Grupo, GrupoViewModel>();
            CreateMap<GrupoUsuario, GrupoUsuarioViewModel>();
            CreateMap<Login, LoginViewModel>();
            CreateMap<RecuperaSenha, RecuperaSenhaViewModel>();
            CreateMap<Sorteio, SorteioViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}

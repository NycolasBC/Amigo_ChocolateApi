using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Servico.ViewModels.Convite;
using Amigo_Chocolate.Servico.ViewModels.Grupo;
using Amigo_Chocolate.Servico.ViewModels.GrupoUsuario;
using Amigo_Chocolate.Servico.ViewModels.Login;
using Amigo_Chocolate.Servico.ViewModels.RecuperaSenha;
using Amigo_Chocolate.Servico.ViewModels.Sorteio;
using Amigo_Chocolate.Servico.ViewModels.Usuario;
using AutoMapper;

namespace Amigo_Chocolate.Servico.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {
            #region - Convite

            CreateMap<ConviteViewModel, Convite>()
               .ConstructUsing(p => new Convite(
                   p.IdConvite,
                   p.IdGrupo,
                   p.NomeGrupo,
                   p.NomeUsuario,
                   p.EmailConvidado,
                   p.Descricao,
                   p.Id_Status
                ));

            CreateMap<NovoConviteViewModel, Convite>()
               .ConstructUsing(p => new Convite(
                   p.IdGrupo,
                   p.NomeGrupo,
                   p.NomeUsuario,
                   p.EmailConvidado,
                   p.Descricao,
                   p.Id_Status
                ));

            CreateMap<AtualizaConviteViewModel, Convite>()
               .ConstructUsing(p => new Convite(
                   p.IdConvite,
                   p.Descricao,
                   p.Id_Status
                ));

            #endregion

            #region - Grupo

            CreateMap<GrupoViewModel, Grupo>()
               .ConstructUsing(p => new Grupo(
                   p.IdGrupo,
                   p.Imagem,
                   p.Nome,
                   p.QtdUsuario,
                   p.Valor,
                   p.DataRevelacao,
                   p.Descricao,
                   p.Id_Status
                ));

            CreateMap<NovoGrupoViewModel, Grupo>()
               .ConstructUsing(p => new Grupo(
                   p.Imagem,
                   p.Nome,
                   p.QtdUsuario,
                   p.Valor,
                   p.DataRevelacao,
                   p.Descricao,
                   p.Id_Status
                ));

            #endregion

            #region - GrupoUsuario

            CreateMap<GrupoUsuarioViewModel, GrupoUsuario>()
               .ConstructUsing(c => new GrupoUsuario(
                   c.IdGrupo,
                   c.IdUsuario,
                   c.Id_Status
                ));

            CreateMap<NovoGrupoUsuarioViewModel, GrupoUsuario>()
               .ConstructUsing(c => new GrupoUsuario(
                   c.IdGrupo,
                   c.IdUsuario,
                   c.Id_Status
                ));

            #endregion

            #region - Login

            CreateMap<LoginViewModel, Login>()
               .ConstructUsing(c => new Login(
                   c.Email,
                   c.Senha
                ));

            CreateMap<NovoLoginViewModel, Login>()
               .ConstructUsing(c => new Login(
                   c.Email,
                   c.Senha
                ));

            #endregion

            #region - RecuperaSenha

            CreateMap<RecuperaSenhaViewModel, RecuperaSenha>()
               .ConstructUsing(d => new RecuperaSenha(
                   d.IdUsuario,
                   d.DataSolicitacao
                ));

            CreateMap<NovoRecuperaSenhaViewModel, RecuperaSenha>()
               .ConstructUsing(d => new RecuperaSenha(
                   d.IdUsuario,
                   DateTime.UtcNow
                ));

            #endregion

            #region - Sorteio

            CreateMap<SorteioViewModel, Sorteio>()
               .ConstructUsing(d => new Sorteio(
                   d.Id_Sorteio,
                   d.Id_Usuario,
                   d.Id_Usuario_Sorteado
                ));

            CreateMap<NovoSorteioViewModel, Sorteio>()
               .ConstructUsing(d => new Sorteio(
                   d.Id_Usuario,
                   d.Id_Usuario_Sorteado
                ));

            #endregion

            #region - Usuario

            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.IdUsuario,
                    u.Foto,
                    u.Nome,
                    u.Email,
                    u.Senha,
                    u.Id_Status
                ));

            CreateMap<NovoUsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.Foto,
                    u.Nome,
                    u.Email,
                    u.Senha,
                    u.Id_Status
                ));

            #endregion
        }
    }
}

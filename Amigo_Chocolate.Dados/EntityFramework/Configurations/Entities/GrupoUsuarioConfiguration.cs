using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class GrupoUsuarioConfiguration : IEntityTypeConfiguration<GrupoUsuario>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuario> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_GRUPO_USUARIO");
            builder.HasKey(f => f.IdGrupoUsuario);

            builder
                .Property(f => f.IdGrupoUsuario)
                .UseIdentityColumn()
                .HasColumnName("ID_GRUPO_USUARIO")
                .HasColumnType("int");

            builder
                .Property(f => f.IdGrupo)
                .HasColumnName("ID_GRUPO")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Grupo)
                .WithMany()
                .HasForeignKey(f => f.IdGrupo);

            builder
                .Property(f => f.IdUsuario)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.IdUsuario);

            builder
                .Property(f => f.Id_Status)
                .HasColumnName("ID_STATUS")
                .HasColumnType("int");   
        }
    }
}

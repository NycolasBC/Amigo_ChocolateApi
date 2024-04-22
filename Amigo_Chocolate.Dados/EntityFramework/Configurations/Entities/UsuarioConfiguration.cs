using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_USUARIO");
            builder.HasKey(u => u.IdUsuario);

            builder
                .Property(u => u.IdUsuario)
                .UseIdentityColumn()
                .HasColumnName("ID_USUARIO")
                .HasColumnType("int");

            builder
                .Property(u => u.Foto)
                .HasColumnName("FOTO")
                .HasColumnType("nvarchar(max)");

            builder
                .Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

            builder
                .Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(255)");

            builder
                .Property(u => u.Senha)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(255)");

            builder
                .Property(u => u.Id_Status)
                .HasColumnName("ID_STATUS")
                .HasColumnType("int");
        }
    }
}

using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_LOGIN");
            builder.HasKey(p => p.IdLogin);

            builder
                .Property(p => p.IdLogin)
                .UseIdentityColumn()
                .HasColumnName("ID_LOGIN")
                .HasColumnType("int");

            builder
                .Property(p => p.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(255)");

            builder
                .Property(p => p.Senha)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(255)");
        }
    }
}

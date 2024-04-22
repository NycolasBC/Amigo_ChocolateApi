using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class RecuperaSenhaConfiguration : IEntityTypeConfiguration<RecuperaSenha>
    {
        public void Configure(EntityTypeBuilder<RecuperaSenha> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_RECUPERA_SENHA");
            builder.HasKey(p => p.IdRecuperaSenha);

            builder
                .Property(p => p.IdRecuperaSenha)
                .UseIdentityColumn()
                .HasColumnName("ID_RECUPERA_SENHA")
                .HasColumnType("int");

            builder
                .Property(p => p.IdUsuario)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.IdUsuario);

            builder
                .Property(p => p.DataSolicitacao)
                .HasColumnName("DATA_SOLICITACAO")
                .HasColumnType("DATETIME");           
        }
    }
}

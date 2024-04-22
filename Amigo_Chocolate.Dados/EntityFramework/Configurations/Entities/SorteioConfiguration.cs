using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class SorteioConfiguration : IEntityTypeConfiguration<Sorteio>
    {
        public void Configure(EntityTypeBuilder<Sorteio> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_SORTEIO");
            builder.HasKey(p => p.Id_Sorteio);

            builder
                .Property(p => p.Id_Sorteio)
                .UseIdentityColumn()
                .HasColumnName("ID_SORTEIO")
                .HasColumnType("int");

            builder
                .Property(p => p.Id_Usuario)
                .HasColumnName("ID_USUARIO")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.Id_Usuario);

            builder
                .Property(p => p.Id_Usuario_Sorteado)
                .HasColumnName("ID_USUARIO_SORTEADO")
                .HasColumnType("int");         

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.Id_Usuario_Sorteado);
        }
    }
}

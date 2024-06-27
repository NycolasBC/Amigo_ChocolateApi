using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class ConviteConfiguration : IEntityTypeConfiguration<Convite>
    {
        public void Configure(EntityTypeBuilder<Convite> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_CONVITE");
            builder.HasKey(c => c.IdConvite);

            builder
                .Property(c => c.IdConvite)
                .UseIdentityColumn()
                .HasColumnName("ID_CONVITE")
                .HasColumnType("int");

            builder
                .Property(c => c.IdGrupo)
                .HasColumnName("ID_GRUPO")
                .HasColumnType("int");

            builder
                .HasOne(c => c.Grupo)
                .WithMany()
                .HasForeignKey(c => c.IdGrupo);

            builder
                .Property(c => c.NomeGrupo)
                .HasColumnName("NOME_GRUPO")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.NomeUsuario)
                .HasColumnName("NOME_USUARIO")
                .HasColumnType("varchar(100)");

            builder
                .Property(c => c.EmailConvidado)
                .HasColumnName("EMAIL_CONVIDADO")
                .HasColumnType("varchar(255)");

            builder
                .Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.Id_Status)
                .HasColumnName("ID_STATUS")
                .HasColumnType("int");   
        }
    }
}

using Amigo_Chocolate.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Amigo_Chocolate.Dados.EntityFramework.Configurations.Entities
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("TB_AMIGO_CHOCO_GRUPO");
            builder.HasKey(g => g.IdGrupo);

            builder
                .Property(g => g.IdGrupo)
                .UseIdentityColumn()
                .HasColumnName("ID_GRUPO")
                .HasColumnType("int");

            builder
                .Property(g => g.Imagem)
                .HasColumnName("IMAGEM")
                .HasColumnType("nvarchar(max)");

            builder
                .Property(g => g.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(50)");

            builder
                .Property(g => g.QtdUsuario)
                .HasColumnName("QUANTIDADE_USUARIO")
                .HasColumnType("int");

            builder
                .Property(g => g.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("decimal(10, 2)");

            builder
                .Property(g => g.DataRevelacao)
                .HasColumnName("DATA_REVELACAO")
                .HasColumnType("date");

            builder
                .Property(g => g.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(300)");

            builder
                .Property(g => g.Id_Status)
                .HasColumnName("ID_STATUS")
                .HasColumnType("int");

        }
    }
}

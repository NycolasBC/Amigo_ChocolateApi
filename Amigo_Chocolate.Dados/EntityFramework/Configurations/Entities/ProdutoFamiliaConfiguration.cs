using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.Entities
{
    public class ProdutoFamiliaConfiguration : IEntityTypeConfiguration<ProdutoFamilia>
    {
        public void Configure(EntityTypeBuilder<ProdutoFamilia> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_PRODUTO_FAMILIA");
            builder.HasKey(p => p.PRODUTO_FAMILIA_ID);

            builder
                .Property(p => p.PRODUTO_FAMILIA_ID)
                .UseIdentityColumn()
                .HasColumnName("PRODUTO_FAMILIA_ID")
                .HasColumnType("int");

            builder
                .Property(p => p.FAMILIA)
                .HasColumnName("FAMILIA")
                .HasColumnType("varchar(80)");

            builder
                .Property(p => p.PRODUTO_CATEGORIA_ID)
                .HasColumnName("PRODUTO_CATEGORIA_ID")
                .HasColumnType("int");

            builder
                .HasOne(p => p.PRODUTO_CATEGORIA)
                .WithMany()
                .HasForeignKey(p => p.PRODUTO_CATEGORIA_ID);
        }
    }
}

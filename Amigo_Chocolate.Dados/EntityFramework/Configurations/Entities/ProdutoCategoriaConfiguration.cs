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
    public class ProdutoCategoriaConfiguration : IEntityTypeConfiguration<ProdutoCategoria>
    {
        public void Configure(EntityTypeBuilder<ProdutoCategoria> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_PRODUTO_CATEGORIA");
            builder.HasKey(p => p.PRODUTO_CATEGORIA_ID);

            builder
                .Property(p => p.PRODUTO_CATEGORIA_ID)
                .UseIdentityColumn()
                .HasColumnName("PRODUTO_CATEGORIA_ID")
                .HasColumnType("int");

            builder
                .Property(p => p.DESCRICAO)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(30)");
        }
    }
}

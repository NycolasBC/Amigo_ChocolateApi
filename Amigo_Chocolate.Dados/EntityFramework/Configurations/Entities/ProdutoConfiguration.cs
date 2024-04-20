using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.Entities
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_PRODUTO");
            builder.HasKey(p => p.PRODUTO_ID);

            builder
                .Property(p => p.PRODUTO_ID)
                .UseIdentityColumn()
                .HasColumnName("PRODUTO_ID")
                .HasColumnType("int");

            builder
                .Property(p => p.PRODUTO_DESC)
                .HasColumnName("PRODUTO_DESC")
                .HasColumnType("varchar(300)");

            builder
                .Property(p => p.PRODUTO_VALOR)
                .HasColumnName("PRODUTO_VALOR")
                .HasColumnType("money");

            builder
                .Property(p => p.PERECIVEL_FLAG)
                .HasColumnName("PERECIVEL_FLAG")
                .HasColumnType("int");

            builder
                .Property(p => p.PESO_ITEM)
                .HasColumnName("PESO_ITEM")
                .HasColumnType("decimal");

            builder
                .Property(p => p.PRODUTO_FAMILIA_ID)
                .HasColumnName("PRODUTO_FAMILIA_ID")
                .HasColumnType("int");

            builder
                .HasOne(p => p.PRODUTO_FAMILIA)
                .WithMany()
                .HasForeignKey(p => p.PRODUTO_FAMILIA_ID);

            builder
                .Property(p => p.ADMINISTRADOR_ID)
                .HasColumnName("ADMINISTRADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(p => p.ADMINISTRADOR)
                .WithMany()
                .HasForeignKey(p => p.ADMINISTRADOR_ID);
        }
    }
}

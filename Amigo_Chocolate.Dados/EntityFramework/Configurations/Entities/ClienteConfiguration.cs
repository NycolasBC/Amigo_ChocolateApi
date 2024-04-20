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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_CLIENTE");
            builder.HasKey(c => c.CLIENTE_ID);

            builder
                .Property(c => c.CLIENTE_ID)
                .UseIdentityColumn()
                .HasColumnName("CLIENTE_ID")
                .HasColumnType("int");

            builder
                .Property(c => c.NOME)
                .HasColumnName("NOME")
                .HasColumnType("varchar(200)");

            builder
                .Property(c => c.FOTO)
                .HasColumnName("FOTO")
                .HasColumnType("varchar(max)");

            builder
                .Property(c => c.ATIVO_FLAG)
                .HasColumnName("ATIVO_FLAG")
                .HasColumnType("int");
        }
    }
}

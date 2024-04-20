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
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_ENDERECO");
            builder.HasKey(e => e.ENDERECO_ID);

            builder
                .Property(e => e.ENDERECO_ID)
                .UseIdentityColumn()
                .HasColumnName("ENDERECO_ID")
                .HasColumnType("int");

            builder
                .Property(e => e.LOGRADOURO)
                .HasColumnName("LOGRADOURO")
                .HasColumnType("varchar(60)");

            builder
                .Property(e => e.NUMERO)
                .HasColumnName("NUMERO")
                .HasColumnType("char(7)");

            builder
                .Property(e => e.COMPLEMENTO)
                .HasColumnName("COMPLEMENTO")
                .HasColumnType("varchar(60)");

            builder
                .Property(e => e.CIDADE)
                .HasColumnName("CIDADE")
                .HasColumnType("varchar(20)");

            builder
                .Property(e => e.CEP)
                .HasColumnName("CEP")
                .HasColumnType("char(8)");

            builder
                .Property(e => e.COLABORADOR_ID)
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(e => e.COLABORADOR)
                .WithMany()
                .HasForeignKey(e => e.COLABORADOR_ID);
        }
    }
}

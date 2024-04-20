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
    public class DoadorConfiguration : IEntityTypeConfiguration<Doador>
    {
        public void Configure(EntityTypeBuilder<Doador> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_DOADOR");
            builder.HasKey(d => d.DOADOR_ID);

            builder
                .Property(d => d.DOADOR_ID)
                .UseIdentityColumn()
                .HasColumnName("DOADOR_ID")
                .HasColumnType("int");

            builder
                .Property(d => d.CPF)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");

            builder
                .Property(d => d.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("char(14)");


            builder
                .Property(d => d.COLABORADOR_ID)
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(d => d.COLABORADOR)
                .WithMany()
                .HasForeignKey(d => d.COLABORADOR_ID);
        }
    }
}

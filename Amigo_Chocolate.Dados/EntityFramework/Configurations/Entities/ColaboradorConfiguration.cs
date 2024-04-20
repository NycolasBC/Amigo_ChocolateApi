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
    public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_COLABORADOR");
            builder.HasKey(c => c.COLABORADOR_ID);

            builder
                .Property(c => c.COLABORADOR_ID)
                .UseIdentityColumn()
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .Property(c => c.NOME)
                .HasColumnName("NOME")
                .HasColumnType("varchar(20)");

            builder
                .Property(c => c.SOBRENOME)
                .HasColumnName("SOBRENOME")
                .HasColumnType("varchar(120)");

            builder
                .Property(c => c.DATA_NASCIMENTO)
                .HasColumnName("DATA_NASCIMENTO")
                .HasColumnType("datetime");

            builder
                .Property(c => c.TIPO)
                .HasColumnName("TIPO")
                .HasColumnType("char(1)");

            builder
                .Property(c => c.CPF)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");

            builder
                .Property(c => c.DATA_CONTRATACAO)
                .HasColumnName("DATA_CONTRATACAO")
                .HasColumnType("datetime");

            builder
                .Property(c => c.DATA_TERMINACAO)
                .HasColumnName("DATA_TERMINACAO")
                .HasColumnType("datetime");

            builder
                .Property(c => c.TERMINACAO_FLAG)
                .HasColumnName("TERMINACAO_FLAG")
                .HasColumnType("int");
        }
    }
}

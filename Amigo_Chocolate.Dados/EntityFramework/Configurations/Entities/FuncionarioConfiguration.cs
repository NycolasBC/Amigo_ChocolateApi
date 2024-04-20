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
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_FUNCIONARIO");
            builder.HasKey(f => f.FUNCIONARIO_ID);

            builder
                .Property(f => f.FUNCIONARIO_ID)
                .UseIdentityColumn()
                .HasColumnName("FUNCIONARIO_ID")
                .HasColumnType("int");
            
            builder
                .Property(f => f.FUNCAO)
                .HasColumnName("FUNCAO")
                .HasColumnType("char(1)");

            builder
                .Property(f => f.SALARIO)
                .HasColumnName("SALARIO")
                .HasColumnType("money");

            builder
                .Property(f => f.COLABORADOR_ID)
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(f => f.COLABORADOR)
                .WithMany()
                .HasForeignKey(f => f.COLABORADOR_ID);
        }
    }
}

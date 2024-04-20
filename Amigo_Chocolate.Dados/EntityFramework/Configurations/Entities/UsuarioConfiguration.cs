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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_USUARIO");
            builder.HasKey(p => p.usuario_id);

            builder
                .Property(p => p.usuario_id)
                .UseIdentityColumn()
                .HasColumnName("USUARIO_ID")
                .HasColumnType("int");

            builder
                .Property(p => p.Login)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");

            builder
                .Property(p => p.Senha)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(MAX)");
        }
    }
}

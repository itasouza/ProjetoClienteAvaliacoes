using Generico.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Generico.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(e => e.EmailCliente).HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.NomeCliente).HasMaxLength(250).IsUnicode(false);


            builder.Property(e => e.CidadeId)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.EstadoId)
                .HasMaxLength(1)
                .IsUnicode(false);


            builder.Property(e => e.Ativo).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.DataCadastro).HasColumnType("datetime");
            builder.Property(e => e.DataAlteracao).HasColumnType("datetime");

            builder.ToTable("Clientes");

        }
    }
}

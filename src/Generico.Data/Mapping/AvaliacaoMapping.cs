using Generico.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generico.Data.Mapping
{
    public class AvaliacaoMapping : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(e => e.Titulo).HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.Descricao).HasColumnType("text");

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Avaliacao)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avaliacao_Cliente");

            builder.HasOne(d => d.Produto)
                .WithMany(p => p.Avaliacao)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Avaliacao_Produto");



            builder.Property(e => e.AvaliacaoUtil).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.Ativo).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.DataCadastro).HasColumnType("datetime");
            builder.Property(e => e.DataAlteracao).HasColumnType("datetime");

            builder.ToTable("Avaliacoes");

        }
    }
}

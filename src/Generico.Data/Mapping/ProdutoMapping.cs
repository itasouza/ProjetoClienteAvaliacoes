﻿using Generico.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Generico.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(e => e.NomeProduto).HasMaxLength(250).IsUnicode(false);
            builder.Property(e => e.ProdutoPromocao).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.FotoProduto).HasMaxLength(200).IsUnicode(false);


            builder.Property(e => e.ValorProduto).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.DataFabricacao).HasColumnType("datetime");
            builder.Property(e => e.DataValidade).HasColumnType("datetime");
            builder.Property(e => e.DescricaoProduto).HasColumnType("text");


            builder.Property(e => e.Ativo).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.DataCadastro).HasColumnType("datetime");
            builder.Property(e => e.DataAlteracao).HasColumnType("datetime");


            builder.ToTable("Produtos");
        }
    }
}

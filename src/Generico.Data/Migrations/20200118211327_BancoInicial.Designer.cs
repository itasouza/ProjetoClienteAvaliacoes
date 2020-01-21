﻿// <auto-generated />
using System;
using Generico.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Generico.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20200118211327_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Generico.Business.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("AvaliacaoUtil")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int>("ProdutoId");

                    b.Property<int?>("QuantidadeEstrela");

                    b.Property<string>("Titulo")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("Generico.Business.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Generico.Business.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("CidadeId")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int?>("CidadeId1");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailCliente")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("EstadoId")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int?>("EstadoId1");

                    b.Property<string>("NomeCliente")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CidadeId1");

                    b.HasIndex("EstadoId1");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Generico.Business.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Sigla")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Generico.Business.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ativo")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataFabricacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DataValidade")
                        .HasColumnType("datetime");

                    b.Property<string>("DescricaoProduto")
                        .HasColumnType("text");

                    b.Property<string>("FotoProduto")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("NomeProduto")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("ProdutoPromocao")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<decimal?>("ValorProduto")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Generico.Business.Models.Avaliacao", b =>
                {
                    b.HasOne("Generico.Business.Models.Cliente", "Cliente")
                        .WithMany("Avaliacao")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("FK_Avaliacao_Cliente")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Generico.Business.Models.Produto", "Produto")
                        .WithMany("Avaliacao")
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("FK_Avaliacao_Produto")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Generico.Business.Models.Cidade", b =>
                {
                    b.HasOne("Generico.Business.Models.Estado", "Estado")
                        .WithMany("Cidade")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Cidade_Estado")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Generico.Business.Models.Cliente", b =>
                {
                    b.HasOne("Generico.Business.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId1")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Generico.Business.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId1")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

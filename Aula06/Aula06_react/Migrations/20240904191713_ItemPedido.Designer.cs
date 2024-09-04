﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MREL.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    [Migration("20240904191713_ItemPedido")]
    partial class ItemPedido
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunosId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinasId")
                        .HasColumnType("int");

                    b.HasKey("AlunosId", "DisciplinasId");

                    b.HasIndex("DisciplinasId");

                    b.ToTable("AlunoDisciplina");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("CEP")
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.Property<double?>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double?>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("AlunoDisciplina", b =>
                {
                    b.HasOne("Aluno", null)
                        .WithMany()
                        .HasForeignKey("AlunosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Disciplina", null)
                        .WithMany()
                        .HasForeignKey("DisciplinasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Endereco", b =>
                {
                    b.HasOne("Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ItemPedido", b =>
                {
                    b.HasOne("Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId");

                    b.HasOne("Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.HasOne("Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}

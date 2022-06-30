﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OOP;

#nullable disable

namespace OOP.Migrations
{
    [DbContext(typeof(EmpresaContext))]
    partial class EmpresaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OOP.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresas", (string)null);
                });

            modelBuilder.Entity("OOP.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ObraId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.ToTable("Fornecedores", (string)null);
                });

            modelBuilder.Entity("OOP.Obra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ParceiroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ParceiroId");

                    b.ToTable("Obras", (string)null);
                });

            modelBuilder.Entity("OOP.Parceiro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<long>("Cnpj")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parceiros", (string)null);
                });

            modelBuilder.Entity("OOP.Fornecedor", b =>
                {
                    b.HasOne("OOP.Obra", "Obra")
                        .WithMany()
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("OOP.Obra", b =>
                {
                    b.HasOne("OOP.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OOP.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("ParceiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Parceiro");
                });
#pragma warning restore 612, 618
        }
    }
}

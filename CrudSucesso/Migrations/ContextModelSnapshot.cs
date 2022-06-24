﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CrudSucesso.Data;

namespace CrudSucesso.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AtividadeParticipante", b =>
                {
                    b.Property<int>("AtividadesId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantesId")
                        .HasColumnType("int");

                    b.HasKey("AtividadesId", "ParticipantesId");

                    b.HasIndex("ParticipantesId");

                    b.ToTable("AtividadeParticipante");
                });

            modelBuilder.Entity("PacoteParticipante", b =>
                {
                    b.Property<int>("PacoteId")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantesId")
                        .HasColumnType("int");

                    b.HasKey("PacoteId", "ParticipantesId");

                    b.HasIndex("ParticipantesId");

                    b.ToTable("PacoteParticipante");
                });

            modelBuilder.Entity("TesteSucessoEventos.Models.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescAtv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Vacancies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("TesteSucessoEventos.Models.Pacote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescPkg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("TesteSucessoEventos.Models.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacoteId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("AtividadeParticipante", b =>
                {
                    b.HasOne("TesteSucessoEventos.Models.Atividade", null)
                        .WithMany()
                        .HasForeignKey("AtividadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TesteSucessoEventos.Models.Participante", null)
                        .WithMany()
                        .HasForeignKey("ParticipantesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PacoteParticipante", b =>
                {
                    b.HasOne("TesteSucessoEventos.Models.Pacote", null)
                        .WithMany()
                        .HasForeignKey("PacoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TesteSucessoEventos.Models.Participante", null)
                        .WithMany()
                        .HasForeignKey("ParticipantesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
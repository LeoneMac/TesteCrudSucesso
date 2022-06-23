﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SucessoCRUD.Data;

#nullable disable

namespace SucessoCRUD.Migrations
{
    [DbContext(typeof(ContextoBanco))]
    [Migration("20220623065704_CreatTableForms")]
    partial class CreatTableForms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SucessoCRUD.Models.Atividades", b =>
                {
                    b.Property<int>("CodAtv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodAtv"), 1L, 1);

                    b.Property<string>("DescAtv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PreçoAtv")
                        .HasColumnType("real");

                    b.Property<int>("Vagas")
                        .HasColumnType("int");

                    b.HasKey("CodAtv");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("SucessoCRUD.Models.AuxParticipanteAtiv", b =>
                {
                    b.Property<int>("AtivId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtivId"), 1L, 1);

                    b.HasKey("AtivId");

                    b.ToTable("AuxParticipanteAtiv");
                });

            modelBuilder.Entity("SucessoCRUD.Models.AuxParticipantePacote", b =>
                {
                    b.Property<int>("ParId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParId"), 1L, 1);

                    b.HasKey("ParId");

                    b.ToTable("AuxParticipantePacote");
                });

            modelBuilder.Entity("SucessoCRUD.Models.Pacotes", b =>
                {
                    b.Property<int>("PackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackId"), 1L, 1);

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preço")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PackId");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("SucessoCRUD.Models.Usuario", b =>
                {
                    b.Property<int>("CodPar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodPar"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodPar");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
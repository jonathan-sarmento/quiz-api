﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizApi.Repositories.Context;

namespace QuizApi.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20211207222734_AdicionandoTabelasPerguntas")]
    partial class AdicionandoTabelasPerguntas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("QuizApi.Domain.Entities.Alternativa", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int>("PerguntaId")
                        .HasColumnType("integer");

                    b.Property<string>("PerguntaId1")
                        .HasColumnType("text");

                    b.Property<bool>("RespostaCerta")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("PerguntaId1");

                    b.ToTable("alternativas");
                });

            modelBuilder.Entity("QuizApi.Domain.Entities.Pergunta", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Enunciado")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("perguntas");
                });

            modelBuilder.Entity("QuizApi.Domain.Entities.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("linkImagem")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int>("pontuacao")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("QuizApi.Domain.Entities.Alternativa", b =>
                {
                    b.HasOne("QuizApi.Domain.Entities.Pergunta", "Pergunta")
                        .WithMany("Alternativas")
                        .HasForeignKey("PerguntaId1");

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("QuizApi.Domain.Entities.Pergunta", b =>
                {
                    b.Navigation("Alternativas");
                });
#pragma warning restore 612, 618
        }
    }
}

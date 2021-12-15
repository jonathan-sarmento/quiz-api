using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;
using System.Collections.Generic;

namespace QuizApi.Repositories.Context
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pergunta>()
                .HasData(new Pergunta
                {
                    Id = 1,
                    Tema = 0,
                    Enunciado = @"Na linguagem C#, para incrementar uma variável sem a utilização de uma equação, é necessário utilizar ""variavel______.""",
                });

            modelBuilder.Entity<Alternativa>()
                .HasData(new List<Alternativa>
                {
                    new Alternativa() {
                        Id = 1,
                        PerguntaId = 1,
                        Descricao = "++;",
                        RespostaCerta = true
                    },
                    new Alternativa() {
                        Id = 2,
                        PerguntaId = 1,
                        Descricao = "--;"
                    },
                    new Alternativa() {
                        Id = 3,
                        PerguntaId = 1,
                        Descricao = "= variavel + 1;"
                    },
                    new Alternativa() {
                        Id = 4,
                        PerguntaId = 1,
                        Descricao = "+"
                    }
                });
        }
    }
}

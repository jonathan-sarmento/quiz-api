using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;
using System.Threading.Tasks;

namespace QuizApi.Repositories.Context
{
    public static class SeedInitializer
    {
        public async static Task Initializer(QuizContext context)
        {
            context.Database.Migrate();
            if(!await context.perguntas.AnyAsync())
            {
                Pergunta pergunta = new Pergunta()
                {
                    Enunciado = @"Na linguagem C#, para incrementar uma variável sem a utilização de uma equação, é necessário utilizar ""variavel______."""
                };
                Alternativa alternativa1 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = "++;",
                    RespostaCerta = true
                };
                Alternativa alternativa2 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = "--;"
                };
                Alternativa alternativa3 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = "= variavel + 1;"
                };
                Alternativa alternativa4 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = "+"
                };
                pergunta.Alternativas.Add(alternativa1);
                pergunta.Alternativas.Add(alternativa2);
                pergunta.Alternativas.Add(alternativa3);
                pergunta.Alternativas.Add(alternativa4);
                await context.perguntas.AddAsync(pergunta);
                Pergunta pergunta2 = new Pergunta()
                {
                    Enunciado = @"Para procurar um elemento HTML na DOM em JavaScript nativo, é possível utilizar:"
                };
                Alternativa alternativa2_1 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = @"documento.procurarElementoPorId(""string"")"
                };
                Alternativa alternativa2_2 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = @"document.createElement(""string"")"
                };
                Alternativa alternativa2_3 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = @"document.getElementById(""string"");",
                    RespostaCerta = true
                };
                Alternativa alternativa2_4 = new Alternativa()
                {
                    Pergunta = pergunta,
                    Descricao = "document.getElementsByClassName();"
                };
                pergunta.Alternativas.Add(alternativa2_1);
                pergunta.Alternativas.Add(alternativa2_2);
                pergunta.Alternativas.Add(alternativa2_3);
                pergunta.Alternativas.Add(alternativa2_4);
                await context.perguntas.AddAsync(pergunta2);
            }
        }
    }
}

using QuizApi.Domain.Entities;
using QuizApi.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services.Abstractions
{
    public interface IPerguntaService
    {
        List<Pergunta> getAllAsync();

        Task<Pergunta> getByIdAsync(int id);

        List<Pergunta> getByTemaAsync(Tema tema);
    }
}

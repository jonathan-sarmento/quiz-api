using QuizApi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services.Abstractions
{
    public interface IPerguntaService
    {
        Task<List<Pergunta>> getAllAsync();

        Task<Pergunta> getByIdAsync(int id);

        Task<List<Pergunta>> getByTemaAsync(string tema);
    }
}

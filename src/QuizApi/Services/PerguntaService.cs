using QuizApi.Domain.Entities;
using QuizApi.Services.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApi.Services
{
    public class PerguntaService : IPerguntaService
    {
        public async Task<List<Pergunta>> getAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Pergunta> getByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Pergunta>> getByTemaAsync(string tema)
        {
            throw new System.NotImplementedException();
        }
    }
}

using QuizApi.Domain.Entities;
using QuizApi.Domain.Enums;
using QuizApi.Repositories.Abstractions;
using QuizApi.Services.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Services
{
    public class PerguntaService : IPerguntaService
    {
        private readonly IPerguntaRepository _repository;
        public PerguntaService(IPerguntaRepository repository) => _repository = repository;
        public List<Pergunta> getAllAsync() 
            => _repository.SelectAll().ToList();

        public async Task<Pergunta> getByIdAsync(int id)
            => await _repository.SelectByIdAsync(id);

        public List<Pergunta> getByTemaAsync(Tema tema)
            => _repository.SelectAll().Where(x => x.Tema == tema).ToList();
    }
}

using QuizApi.Domain.Entities;
using System.Threading.Tasks;

namespace QuizApi.Repositories.Abstractions
{
    public interface IPerguntaRepository : IRepository<Pergunta>
    {
        Task<Pergunta> ObterPergunta(int id);
    }
}
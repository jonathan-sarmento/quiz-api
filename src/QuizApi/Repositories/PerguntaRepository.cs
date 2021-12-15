using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;
using QuizApi.Repositories.Abstractions;
using QuizApi.Repositories.Context;

namespace QuizApi.Repositories
{
    public class PerguntaRepository : Repository<Pergunta>, IPerguntaRepository
    {
       public PerguntaRepository(QuizContext context) : base(context)
       {
           
       }

        public async Task<Pergunta> ObterPergunta(int id)
            => await SelectAll().Include(x => x.Alternativas)
                                .FirstOrDefaultAsync(x => Equals(x.Id, id));
    }
}